using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Enums;
using WareHouse.Exceptions;
using WareHouse.Managers;

namespace WareHouse.Forms
{
    public partial class ClientCSVReportForm : Form
    {
        public ClientCSVReportForm()
        {
            InitializeComponent();
            FormDock.SubscribeControlsToDragEvents(new Control[]
            {
                LogoLabel, MainPanel
            });
        }

        /// <summary>
        /// Close form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Save report.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(ProductPriceTextBox.Text.Trim(), out var minPrice) && minPrice < 0)
                {
                    throw new CustomDataException(ApplicationStrings.PriceMinimumException);
                }

                using (var saveDialog = new SaveFileDialog {Filter = ApplicationStrings.SaveFileFilter})
                {
                    if (saveDialog.ShowDialog() != DialogResult.OK) return;

                    using (var fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (var streamWriter = new StreamWriter(fileStream))
                        {
                            // Create report strings.
                            var csvString = new StringBuilder();
                            csvString.AppendLine("User Name;User Phone;Orders Quantity;Orders Total Price");
                            var clients = ClientManager.GetClients().Where(x => x.LoginType == Login.User).ToList();
                            clients.Sort((x, y) =>
                                OrderManager.GetOrders(x).Sum(order =>
                                    order.OrderProducts.Values.Sum(value => value.Item1)).CompareTo(OrderManager
                                    .GetOrders(y).Sum(order =>
                                        order.OrderProducts.Values.Sum(value => value.Item1))));


                            foreach (var str in from client in clients
                                let orders = OrderManager.GetOrders(client)
                                let sum = orders.Sum(order =>
                                    order.OrderProducts.Values.Sum(value => value.Item1))
                                let ordersQuantity = orders.Sum(order =>
                                    order.Quantity)
                                where !(sum < minPrice)
                                select $"{client.Login};{client.PhoneNumber};{ordersQuantity};{sum}")
                            {
                                csvString.AppendLine(str);
                            }


                            // Save report.
                            streamWriter.Write(csvString);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Forbid enter more than digits.
        /// </summary>
        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }
    }
}