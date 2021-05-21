using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Helpers;
using WareHouse.Managers;

namespace WareHouse.Forms
{
    public partial class MainUser : Form
    {
        #region Fields

        /// <summary>
        /// Current product.
        /// </summary>
        private Product CurrentProduct { get; set; }

        #endregion

        #region Delegates

        /// <summary>
        /// Delegate to change current product.
        /// </summary>
        public Action<Product> OnProductChange;

        #endregion

        public MainUser()
        {
            InitializeComponent();
            FormDock.SubscribeControlsToDragEvents(new Control[]
            {
                ToolsPanel, LogoLabel, MainPanel, UserNameTextBox,
                Separator, Separator2, Separator3, Separator4, UserNameTextBox,
                ProductsPanel, Pages, ProductPage, BasketPage, OrdersPanel
            });

            OnProductChange += ProductChange;
        }

        #region Form manage

        /// <summary>
        /// Load and set data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainUser_Load(object sender, EventArgs e)
        {
            try
            {
                Manager.LoadWarehouse();
                AppLoad();
                SetLocalization();
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Create nodes from load data.
        /// </summary>
        private void AppLoad()
        {
            UserNameTextBox.Text = Manager.CurrentClient.Login;
            // Get sections and sort by path length.
            var tempSections = SectionManager.GetSections();
            tempSections.Sort((a, b) => a.Path.Count.CompareTo(b.Path.Count));

            // Create roots.
            foreach (var section in tempSections.Where(x => x.Path.Count == 1))
            {
                ProductTreeView.Nodes.Add(new CustomNode(section.Name, section.Path) {Text = section.Name});
            }

            // Create child sections.
            foreach (var section in tempSections.Where(x => x.Path.Count > 1))
            {
                var parentNode = NodeHelper.ToList(ProductTreeView.Nodes).OfType<CustomNode>().First(x =>
                    x.Path.Count + 1 == section.Path.Count &&
                    SectionManager.Get(x.SectionName, x.Path).IsSubSection(section));
                parentNode.Nodes.Add(new CustomNode(section.Name, section.Path) {Text = section.Name});
            }
        }

        /// <summary>
        /// Set localization.
        /// </summary>
        private void SetLocalization()
        {
            LogoLabel.Text = ApplicationStrings.LogoLabel;
            ProductDescriptionLabel.Text = ApplicationStrings.ProductDescriptionText;
            OrderQuantityLabel.Text = ApplicationStrings.OrderQuantityText;
            BuyButton.Text = ApplicationStrings.BuyButtonText;

            ToolTip.SetToolTip(BasketBox, ApplicationStrings.BasketBoxToolTip);
            ToolTip.SetToolTipTitle(BasketBox, ApplicationStrings.BasketBoxToolTipTitle);

            ToolTip.SetToolTip(UserNameTextBox, ApplicationStrings.UserNameTextBoxToolTip);
            ToolTip.SetToolTipTitle(UserNameTextBox, ApplicationStrings.UserNameTextBoxToolTipTitle);

            ToolTip.SetToolTip(EngButton, ApplicationStrings.EngButtonToolTip);
            ToolTip.SetToolTipTitle(EngButton, ApplicationStrings.EngButtonToolTipTitle);

            ToolTip.SetToolTip(RusButton, ApplicationStrings.RusButtonToolTip);
            ToolTip.SetToolTipTitle(RusButton, ApplicationStrings.RusButtonToolTipTitle);

            ToolTip.SetToolTip(ChangeAccBox, ApplicationStrings.ChangeAccBoxToolTip);
            ToolTip.SetToolTipTitle(ChangeAccBox, ApplicationStrings.ChangeAccBoxToolTipTitle);

            ToolTip.SetToolTip(ProductTitleTextBox, ApplicationStrings.ProductTitleTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductTitleTextBox, ApplicationStrings.ProductTitleTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductPriceTextBox, ApplicationStrings.ProductPriceTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductPriceTextBox, ApplicationStrings.ProductPriceTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductCompanyTextBox, ApplicationStrings.ProductCompanyTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductCompanyTextBox, ApplicationStrings.ProductCompanyTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductDiscountTextBox, ApplicationStrings.ProductDiscountTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductDiscountTextBox, ApplicationStrings.ProductDiscountTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductCountryTextBox, ApplicationStrings.ProductCountryTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductCountryTextBox, ApplicationStrings.ProductCountryTextBoxToolTipTitle);

            ToolTip.SetToolTip(ProductGuaranteeTextBox, ApplicationStrings.ProductGuaranteeTextBoxToolTip);
            ToolTip.SetToolTipTitle(ProductGuaranteeTextBox, ApplicationStrings.ProductGuaranteeTextBoxToolTipTitle);

            ToolTip.SetToolTip(BuyButton, ApplicationStrings.BuyButtonToolTip);
            ToolTip.SetToolTipTitle(BuyButton, ApplicationStrings.BuyButtonToolTipTitle);
        }

        /// <summary>
        /// Save data.
        /// </summary>
        private void MainUser_FormClosing(object sender, FormClosingEventArgs e)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Roll or hide form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Change account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAccBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        /// <summary>
        /// Set english language.
        /// </summary>
        private void EngButton_Click(object sender, EventArgs e)
        {
            // Set english language.
            Save("culture", "en-US");
            Application.Restart();
        }

        /// <summary>
        /// Set russian language.
        /// </summary>
        private void RusButton_Click(object sender, EventArgs e)
        {
            // Set russian language.
            Save("culture", "ru-RU");
            Application.Restart();
        }


        /// <summary>
        /// Save locale settings.
        /// </summary>
        /// <param name="key">Key in config.</param>
        /// <param name="value">New value.</param>
        private static void Save(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            if (settings[key] != null)
                settings.Remove(key);
            settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        #endregion

        #region Tree view

        /// <summary>
        /// Go to shop page and show products info.
        /// </summary>
        private void ProductTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                // Get node.
                var node = (CustomNode)e.Node;
                Pages.SetPage("ShopPage");
                ProductTreeView.SelectedNode = node;
                // Set data.
                SetData(node);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get and show data from current node.
        /// </summary>
        /// <param name="node">Selected node.</param>
        private void SetData(CustomNode node)
        {
            // Get parent section.
            var parentSection = SectionManager.Get(node.SectionName, node.Path);

            ProductsPanel.Controls.Clear();
            var tag = 0;
            // Get products which contains filter name.
            foreach (var product in parentSection.GetProducts())
            {
                try
                {
                    ProductsPanel.Controls.Add(new ProductView(product, this)
                    {
                        Margin = new Padding(35, 10, 35, 10),
                        Tag = tag++
                    });
                }
                catch
                {
                    // ignored
                }
            }

            // Add new rows from child section.
            foreach (var product in parentSection.GetSections().SelectMany(section =>
                section.GetProducts()))
            {
                try
                {
                    ProductsPanel.Controls.Add(new ProductView(product, this)
                        { Margin = new Padding(35, 10, 35, 10), Tag = tag++ });
                }
                catch
                {
                    // ignored
                }
            }
        }

        #endregion

        #region Pages manage

        /// <summary>
        /// Go to basket page.
        /// </summary>
        private void BasketBox_Click(object sender, EventArgs e)
        {
            try
            {
                GoToBasket();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Go to basket page - internal method.
        /// </summary>
        private void GoToBasket()
        {
            Pages.SetPage("BasketPage");
            // Set data.
            OrdersPanel.Controls.Clear();
            var tag = 0;
            // Get products which contains filter name.
            foreach (var order in OrderManager.GetOrders(Manager.CurrentClient))
            {
                try
                {
                    OrdersPanel.Controls.Add(new OrderView(order)
                    {
                        Margin = new Padding(80, 10, 20, 10),
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
        /// Change current product and show it's data.
        /// </summary>
        /// <param name="product">New product.</param>
        private void ProductChange(Product product)
        {
            try
            {
                CurrentProduct = product;
                //Go to basket page and set data.
                Pages.SetPage("ProductPage");

                ProductPhotoBox.Image = ImgConverter.ConvertStringToImg(CurrentProduct.Photo);
                ProductTitleTextBox.Text = CurrentProduct.Name;
                ProductPriceTextBox.Text = $"{CurrentProduct.Price} {CurrentProduct.Currency}";
                ProductCompanyTextBox.Text = CurrentProduct.Company;
                ProductDiscountTextBox.Text = $"{CurrentProduct.Discount} %";
                ProductCountryTextBox.Text = Countries.GetCountry(CurrentProduct.Country);
                ProductGuaranteeTextBox.Text = CurrentProduct.Guarantee.ToString();
                ProductDescriptionTextBox.Text = CurrentProduct.Description;

                OrderQuantityNumericUpDown.Maximum = CurrentProduct.Quantity;
                OrderQuantityNumericUpDown.Value = 0;

                TotalPayableLabel.Text = string.Format(ApplicationStrings.TotalPayableLabelText, TotalPayable(),
                    CurrentProduct.Currency);

                BuyButton.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Change product quantity in order.
        /// </summary>
        private void OrderQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BuyButton.Enabled = OrderQuantityNumericUpDown.Value > 0;
            TotalPayableLabel.Text = string.Format(ApplicationStrings.TotalPayableLabelText, TotalPayable(),
                CurrentProduct.Currency);
        }

        /// <summary>
        /// Add product to cart.
        /// </summary>
        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderManager.Add(Manager.CurrentClient, CurrentProduct, TotalPayable(),
                    (int) OrderQuantityNumericUpDown.Value);
                CurrentProduct.Quantity -= (int) OrderQuantityNumericUpDown.Value;
                GoToBasket();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Formula to define total payable of product.
        /// </summary>
        /// <returns></returns>
        private double TotalPayable()
        {
            return Math.Round(OrderQuantityNumericUpDown.Value > 0
                ? (int) OrderQuantityNumericUpDown.Value * (
                    0.001 * City.GetById(Manager.CurrentClient.ClientCityId).Values.Item2 +
                    CurrentProduct.Price * (1 - CurrentProduct.Discount / 100.0))
                : 0, 2);
        }

        #endregion
    }
}