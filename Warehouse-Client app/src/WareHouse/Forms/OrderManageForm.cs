using System;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Managers;
using Bunifu.UI.WinForms;

namespace WareHouse.Forms
{
    public partial class OrderManageForm : Form
    {
        #region Delegate

        /// <summary>
        /// Delegate to change current client. 
        /// </summary>
        public Action<Client> OnClientChange;

        #endregion

        public OrderManageForm()
        {
            InitializeComponent();
            FormDock.SubscribeControlsToDragEvents(new Control[]
            {
                LogoLabel, ToolsPanel, MainPanel, Pages, ClientsPanel, OrdersPanel,
            });
            OnClientChange += ClientChanged;
        }

        #region Form manage

        /// <summary>
        /// Set data and localization.
        /// </summary>
        private void OrderManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                ShowUsers();
                LogoLabel.Text = ApplicationStrings.OrderManageFormLogoLabelText;
                ClientsButton.Text = ApplicationStrings.ClientsButtonText;
                OrdersButton.Text = ApplicationStrings.OrdersButtonText;
                ActiveLabel.Text = ApplicationStrings.ActiveLabelText;
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Save data.
        /// </summary>
        private void OrderManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Manager.SaveWarehouse();
            }
            catch
            {
                // ignored
            }
        }


        /// <summary>
        /// Close form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Role or hide form.
        /// </summary>
        private void RollButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Controls manage

        /// <summary>
        /// Show users.
        /// </summary>
        private void ClientsButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowUsers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show all users - internal method.
        /// </summary>
        private void ShowUsers()
        {
            Pages.SetPage("ClientsPage");
            ClientsPanel.Controls.Clear();
            var tag = 0;

            foreach (var client in ClientManager.GetClients())
            {
                try
                {
                    if (client.LoginType == Login.Worker) continue;
                    ClientsPanel.Controls.Add(new ClientView(client, this)
                    {
                        Margin = new Padding(20, 10, 20, 10),
                        Tag = tag++
                    });
                }
                catch
                {
                    // ignored
                }
            }
        }


        /// <summary>
        /// Show all orders.
        /// </summary>
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pages.SetPage("OrdersPage");
                OrdersPanel.Controls.Clear();
                foreach (var client in ClientManager.GetClients())
                {
                    SetOrders(client);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set client's orders data.
        /// </summary>
        /// <param name="client">Client</param>
        private void SetOrders(Client client)
        {
            // Set data.
            var tag = OrdersPanel.Controls.Count;
            // Get products which contains filter name.
            foreach (var order in OrderManager.GetOrders(client))
            {
                try
                {
                    if (OnlyActiveOrdersToggle.Checked && order.Status.HasFlag(OrderStatus.Completed)) continue;

                    OrdersPanel.Controls.Add(new OrderView(order, Manager.CurrentClient)
                    {
                        Margin = new Padding(50, 10, 20, 10),
                        Tag = tag++
                    });
                }
                catch
                {
                    // ignored
                }
            }
        }


        /// <summary>
        /// Change current client.
        /// </summary>
        /// <param name="client">New client.</param>
        private void ClientChanged(Client client)
        {
            Pages.SetPage("OrdersPage");
            OrdersPanel.Controls.Clear();
            SetOrders(client);
        }

        /// <summary>
        /// Change settings of orders.
        /// </summary>
        private void OnlyActiveOrdersToggle_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            try
            {
                ShowUsers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Create CSV report.
        /// </summary>
        private void CreateCSVButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var csvReport = new ClientCSVReportForm())
                {
                    csvReport.ShowDialog();
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