using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Managers;

namespace WareHouse.Forms
{
    public partial class ClientView : UserControl
    {
        /// <summary>
        /// Current client.
        /// </summary>
        private readonly Client _currentClient;
        /// <summary>
        /// Form owner.
        /// </summary>
        private readonly Form _owner;

        private ClientView()
        {
            InitializeComponent();
        }

        public ClientView(Client client, Form owner) : this()
        {
            _currentClient = client;
            _owner = owner;
        }
        /// <summary>
        /// Set data and localization.
        /// </summary>
        private void ClientView_Load(object sender, EventArgs e)
        {
            // Set data and localization.
            CreateReportButton.Text = ApplicationStrings.ReportText;
            OrdersButton.Text = ApplicationStrings.OrdersButtonText;
            ClientLoginTextBox.Text = _currentClient.Login;
            ClientOrdersQuantityTextBox.Text = OrderManager.GetOrders(_currentClient).Count.ToString();

            ToolTip.SetToolTip(ClientLoginTextBox, ApplicationStrings.UserNameTextBoxToolTip);
            ToolTip.SetToolTipTitle(ClientLoginTextBox, ApplicationStrings.UserNameTextBoxToolTipTitle);

            ToolTip.SetToolTip(CreateReportButton, ApplicationStrings.CreateReportButtonToolTip);
            ToolTip.SetToolTipTitle(CreateReportButton, ApplicationStrings.CreateReportButtonToolTipTitle);

            ToolTip.SetToolTip(OrdersButton, ApplicationStrings.OrdersButtonToolTip);
            ToolTip.SetToolTipTitle(OrdersButton, ApplicationStrings.OrdersButtonToolTipTitle);

            ToolTip.SetToolTip(ClientOrdersQuantityTextBox, ApplicationStrings.ClientOrdersQuantityTextBoxToolTip);
            ToolTip.SetToolTipTitle(ClientOrdersQuantityTextBox,ApplicationStrings.ClientOrdersQuantityTextBoxToolTipTitle);
        }

        /// <summary>
        /// Show client orders in owner form.
        /// </summary>
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            (_owner as OrderManageForm)?.OnClientChange?.Invoke(_currentClient);
        }

        /// <summary>
        /// Create user report.
        /// </summary>
        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveDialog = new SaveFileDialog { Filter = ApplicationStrings.SaveFileFilter })
                {
                    if (saveDialog.ShowDialog() != DialogResult.OK) return;

                    using (var fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (var streamWriter = new StreamWriter(fileStream))
                        {
                            var orders = OrderManager.GetOrders(_currentClient);

                            // Create report strings.
                            var csvString = new StringBuilder();
                            csvString.AppendLine("Time Creation;Order ID;Order Quantity;User Phone;User Name");


                            // Set data.
                            foreach (var str in orders.Select(order =>
                                $"{order.TimeFormed:s};{order.ID};{order.Quantity};{order.OrderClient.PhoneNumber};{order.OrderClient.Login}")
                            )
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
    }
}