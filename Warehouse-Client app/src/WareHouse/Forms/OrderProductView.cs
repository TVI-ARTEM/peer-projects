using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Managers;

namespace WareHouse.Forms
{
    public partial class OrderProductView : UserControl
    {
        #region Properties

        /// <summary>
        /// Current product.
        /// </summary>
        private Product OrderProduct { get; }
        /// <summary>
        /// Product total price.
        /// </summary>
        private double TotalValue { get; }
        /// <summary>
        /// Product quantity.
        /// </summary>
        private int Quantity { get; }
        /// <summary>
        /// Client login type.
        /// </summary>
        private Login ClientLogin { get; }

        #endregion

        public OrderProductView()
        {
            InitializeComponent();
        }

        public OrderProductView(Product product, (double, int) values, Login clientLogin) : this()
        {
            OrderProduct = product;
            var (totalValue, quantity) = values;
            TotalValue = totalValue;
            Quantity = quantity;
            ClientLogin = clientLogin;
        }

        #region Form manage

        /// <summary>
        /// Set data and localization.
        /// </summary>
        private void OrderProductView_Load(object sender, EventArgs e)
        {
            ProductTitleTextBox.Text = OrderProduct.Name;
            ProductPriceTextBox.Text = $"{TotalValue} {OrderProduct.Currency}";
            ProductQuantityTextBox.Text = Quantity.ToString();
            CreateReportButton.Text = ApplicationStrings.ReportText;
            CreateReportButton.Visible = ClientLogin == Login.Worker;

            ToolTip.SetToolTip(ProductTitleTextBox, ApplicationStrings.ProductTitleTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductTitleTextBox, ApplicationStrings.ProductTitleTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductPriceTextBox, ApplicationStrings.ProductPriceTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductPriceTextBox, ApplicationStrings.ProductPriceTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductQuantityTextBox, ApplicationStrings.ProductQuantityTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductQuantityTextBox, ApplicationStrings.ProductQuantityTextBoxToolTipTitle);

            ToolTip.SetToolTip(CreateReportButton,ApplicationStrings.CreateReportButtonToolTip);
            ToolTip.SetToolTipTitle(CreateReportButton, ApplicationStrings.CreateReportButtonToolTipTitle);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create CSV report.
        /// </summary>
        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveDialog = new SaveFileDialog {Filter = ApplicationStrings.SaveFileFilter})
                {
                    if (saveDialog.ShowDialog() != DialogResult.OK) return;

                    using (var fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (var streamWriter = new StreamWriter(fileStream))
                        {
                            // Get products which quantity less than minimum quantity or equals.
                            var orders = OrderManager.GetOrders()
                                .Where(order => order.OrderProducts.Any(x=>x.Key.Equals(OrderProduct)));

                            // Create report strings.
                            var csvString = new StringBuilder();
                            csvString.AppendLine("Time Creation;Order ID;User Name;User Phone;Product Name");


                            // Set data.
                            foreach (var order in orders)
                            {
                                // Add new string to report.
                                var str =
                                    $"{order.TimeFormed:s};{order.ID};{order.OrderClient.Login};{order.OrderClient.PhoneNumber};{OrderProduct.Name}";
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

        #endregion
    }
}