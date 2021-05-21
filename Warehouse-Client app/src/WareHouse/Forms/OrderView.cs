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
    public partial class OrderView : UserControl
    {
        #region Properties

        /// <summary>
        /// Current order.
        /// </summary>
        private Order CurrentOrder { get; }

        /// <summary>
        /// Current client.
        /// </summary>
        private Client CurrentClient { get; }

        #endregion

        private OrderView()
        {
            InitializeComponent();
        }

        public OrderView(Order order) : this()
        {
            CurrentOrder = order;
            CurrentClient = CurrentOrder.OrderClient;
        }

        public OrderView(Order order, Client currentClient) : this(order)
        {
            CurrentOrder = order;
            CurrentClient = currentClient;
        }

        #region Control manage

        /// <summary>
        /// Set data and localization.
        /// </summary>
        private void OrderView_Load(object sender, EventArgs e)
        {
            UserNameTextBox.Text = CurrentOrder.OrderClient.Login;
            OrderIDTextBox.Text = CurrentOrder.ID.ToString();
            OrderStatusTextBox.Text = CurrentOrder.Status.ToString();
            OrderTimeTextBox.Text = CurrentOrder.TimeFormed.ToString("G");

            ShapeButton.Text = ApplicationStrings.ChangeButtonText_Shape;
            ProcessButton.Text = ApplicationStrings.ChangeButtonText_Process;
            PayButton.Text = ApplicationStrings.ChangeButtonText_Pay;
            ShipButton.Text = ApplicationStrings.ChangeButtonText_Ship;
            ExecuteButton.Text = ApplicationStrings.ChangeButtonText_Execute;
            CreateReportButton.Text = ApplicationStrings.ReportText;

            ToolTip.SetToolTip(UserNameTextBox, ApplicationStrings.UserNameTextBoxToolTip);
            ToolTip.SetToolTipTitle(UserNameTextBox, ApplicationStrings.UserNameTextBoxToolTipTitle);

            ToolTip.SetToolTip(CreateReportButton, ApplicationStrings.CreateReportButtonToolTip);
            ToolTip.SetToolTipTitle(CreateReportButton, ApplicationStrings.CreateReportButtonToolTipTitle);

            ToolTip.SetToolTip(OrderIDTextBox, ApplicationStrings.OrderIDTextBoxToolTip);
            ToolTip.SetToolTipTitle(OrderIDTextBox, ApplicationStrings.OrderIDTextBoxToolTipTitle);

            ToolTip.SetToolTip(OrderStatusTextBox, ApplicationStrings.OrderStatusTextBoxToolTip);
            ToolTip.SetToolTipTitle(OrderStatusTextBox, ApplicationStrings.OrderStatusTextBoxToolTipTitle);

            ToolTip.SetToolTip(OrderTimeTextBox, ApplicationStrings.OrderTimeTextBoxToolTip);
            ToolTip.SetToolTipTitle(OrderTimeTextBox, ApplicationStrings.OrderTimeTextBoxToolTipTitle);


            CreateReportButton.Visible = CurrentClient.LoginType == Login.Worker;
            ChangeButtonsVisible();
            SetData();
        }

        /// <summary>
        /// Set data - internal method.
        /// </summary>
        private void SetData()
        {
            ProductsPanel.Controls.Clear();
            var tag = 0;
            // Get products which contains filter name.
            foreach (var product in CurrentOrder.OrderProducts)
            {
                try
                {
                    ProductsPanel.Controls.Add(
                        new OrderProductView(product.Key, product.Value, CurrentClient.LoginType)
                        {
                            Margin = new Padding(20, 5, 10, 5),
                            Tag = tag++
                        });
                }
                catch
                {
                    // ignored
                }
            }
        }

        #endregion


        #region Change order status

        /// <summary>
        /// Change order status to formed.
        /// </summary>
        private void ShapeButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.ChangeStatus(OrderStatus.Formed);
                OrderStatusTextBox.Text = CurrentOrder.Status.ToString();

                ChangeButtonsVisible();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change order status to processed.
        /// </summary>
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.ChangeStatus(OrderStatus.Processed);
                OrderStatusTextBox.Text = CurrentOrder.Status.ToString();

                ChangeButtonsVisible();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change order status to paidUp.
        /// </summary>
        private void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.ChangeStatus(OrderStatus.PaidUp);
                OrderStatusTextBox.Text = CurrentOrder.Status.ToString();

                ChangeButtonsVisible();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change order status to shipped.
        /// </summary>
        private void ShipButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.ChangeStatus(OrderStatus.Shipped);
                OrderStatusTextBox.Text = CurrentOrder.Status.ToString();

                ChangeButtonsVisible();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change order status to complete.
        /// </summary>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.ChangeStatus(OrderStatus.Completed);
                OrderStatusTextBox.Text = CurrentOrder.Status.ToString();

                ChangeButtonsVisible();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change buttons visibility.
        /// </summary>
        private void ChangeButtonsVisible()
        {
            ShapeButton.Visible = !CurrentOrder.Status.HasFlag(OrderStatus.Formed) &&
                                  CurrentClient.LoginType == Login.User;
            ProcessButton.Visible = CurrentOrder.Status.HasFlag(OrderStatus.Formed) &&
                                    !CurrentOrder.Status.HasFlag(OrderStatus.Processed) &&
                                    CurrentClient.LoginType == Login.Worker;
            PayButton.Visible = CurrentOrder.Status.HasFlag(OrderStatus.Processed) &&
                                !CurrentOrder.Status.HasFlag(OrderStatus.PaidUp) &&
                                CurrentClient.LoginType == Login.User;
            ShipButton.Visible = CurrentOrder.Status.HasFlag(OrderStatus.PaidUp) &&
                                 !CurrentOrder.Status.HasFlag(OrderStatus.Shipped) &&
                                 CurrentClient.LoginType == Login.Worker;
            ExecuteButton.Visible = CurrentOrder.Status.HasFlag(OrderStatus.Shipped) &&
                                    !CurrentOrder.Status.HasFlag(OrderStatus.Completed) &&
                                    CurrentClient.LoginType == Login.Worker;
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
                            var orders = OrderManager.GetOrders(CurrentOrder.OrderClient);

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

        #endregion
    }
}