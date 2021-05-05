using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Exceptions;
using WareHouse.Helpers;
using WareHouse.Managers;

namespace WareHouse.Forms
{
    public partial class ProductCreatorForm : Form
    {
        /// <summary>
        /// Product.
        /// </summary>
        public Product Product { get; }

        public ProductCreatorForm()
        {
            Product = new Product();
            InitializeComponent();
            GetData();
            GetValues();
        }

        public ProductCreatorForm(Product product) : this()
        {
            GetValues(product);
        }

        /// <summary>
        /// Set values to controls.
        /// </summary>
        private void GetValues()
        {
            ProductCountryDropdown.SelectedIndex = 0;
            ProductCurrencyDropdown.SelectedIndex = 0;
            ProductGuaranteeDropdown.SelectedIndex = 0;
        }

        /// <summary>
        /// Set localized data.
        /// </summary>
        private void SetLocalization()
        {
            ProductNameTextBox.PlaceholderText = ApplicationStrings.ProductNamePlaceholder;
            ProductNameTextBox.TextPlaceholder = ApplicationStrings.ProductNamePlaceholder;

            ProductCodeTextBox.PlaceholderText = ApplicationStrings.ProductCodePlaceholder;
            ProductCodeTextBox.TextPlaceholder = ApplicationStrings.ProductCodePlaceholder;
            ProductUcnTextBox.PlaceholderText = ApplicationStrings.ProductUcnPlaceholder;
            ProductUcnTextBox.TextPlaceholder = ApplicationStrings.ProductUcnPlaceholder;

            ProductQuantityTextBox.PlaceholderText = ApplicationStrings.ProductQuantityPlaceholder;
            ProductQuantityTextBox.TextPlaceholder = ApplicationStrings.ProductQuantityPlaceholder;

            ProductPriceTextBox.PlaceholderText = ApplicationStrings.ProductPricePlaceholder;
            ProductPriceTextBox.TextPlaceholder = ApplicationStrings.ProductPricePlaceholder;

            ProductDiscountTextBox.PlaceholderText = ApplicationStrings.ProductDiscountPlaceholder;
            ProductDiscountTextBox.TextPlaceholder = ApplicationStrings.ProductDiscountPlaceholder;

            ProductDescriptionTextBox.PlaceholderText = ApplicationStrings.ProductDescriptionPlaceholder;
            ProductDescriptionTextBox.TextPlaceholder = ApplicationStrings.ProductDescriptionPlaceholder;

            GeneralSettingsButton.Text = ApplicationStrings.GeneralSettingsText;
            AdditionalSettingsButton.Text = ApplicationStrings.AdditionalSettingsText;
            ChangeImgButton.Text = ApplicationStrings.ChangeImgText;
        }

        /// <summary>
        /// Set values from other product to controls.
        /// </summary>
        /// <param name="product">Other product.</param>
        private void GetValues(Product product)
        {
            try
            {
                ProductNameTextBox.Text = product.Name;
                ProductCodeTextBox.Text = product.Code;
                ProductUcnTextBox.Text = product.UCN;
                ProductQuantityTextBox.Text = product.Quantity.ToString();
                ProductPriceTextBox.Text = product.Price.ToString(CultureInfo.InvariantCulture);
                ProductDiscountTextBox.Text = product.Discount.ToString(CultureInfo.InvariantCulture);
                ProductCompanyDropdown.SelectedItem = CompanyManager.Get(product.Company).Name;
                ProductDescriptionTextBox.Text = product.Description;
                ProductImage.Image = ImgConverter.ConvertStringToImg(product.Photo);
                ProductCurrencyDropdown.SelectedIndex = (int) product.Currency;
                ProductGuaranteeDropdown.SelectedIndex = (int) product.Guarantee;
                ProductStatusDropDown.SelectedIndex = (int) product.Status;
                ProductCountryDropdown.SelectedIndex = (int) product.Country;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get company data.
        /// </summary>
        private void GetData()
        {
            ProductCompanyDropdown.DataSource = CompanyManager.GetNames();
            ProductCompanyDropdown.SelectionLength = 0;
        }

        /// <summary>
        /// Change page to general page.
        /// </summary>
        private void GeneralSettingsButton_Click(object sender, EventArgs e)
        {
            ProductPage.SetPage("General");
        }

        /// <summary>
        /// Change page to additional page.
        /// </summary>
        private void AdditionalSettingsButton_Click(object sender, EventArgs e)
        {
            ProductPage.SetPage("Additional");
        }

        /// <summary>
        /// Set values while closing.
        /// </summary>
        private void ProductCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;

            try
            {
                SetValues();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Set values to product from controls.
        /// </summary>
        private void SetValues()
        {
            Product.Name = ProductNameTextBox.Text;
            Product.Code = ProductCodeTextBox.Text;
            Product.UCN = ProductUcnTextBox.Text;

            if (int.TryParse(ProductQuantityTextBox.Text, out var quantityResult))
            {
                Product.Quantity = quantityResult;
            }
            else
            {
                throw new CustomDataException(ApplicationStrings.QuantityParseException);
            }

            if (double.TryParse(ProductPriceTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture,
                out var priceResult))
            {
                Product.Price = priceResult;
            }
            else
            {
                throw new CustomDataException(ApplicationStrings.PriceParseException);
            }

            if (double.TryParse(ProductDiscountTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture,
                out var discountResult))
            {
                Product.Discount = discountResult;
            }
            else
            {
                throw new CustomDataException(ApplicationStrings.DiscountParseException);
            }

            Product.Description = ProductDescriptionTextBox.Text;
            Product.Photo = ImgConverter.ConvertImgToString((Bitmap) ProductImage.Image);
            Product.Currency = (Currency) ProductCurrencyDropdown.SelectedIndex;
            Product.Guarantee = (Guarantee) ProductGuaranteeDropdown.SelectedIndex;
            Product.Country = (Country) ProductCountryDropdown.SelectedIndex;
            Product.Company = (string) ProductCompanyDropdown.SelectedItem ??
                              throw new CustomDataException(ApplicationStrings.CompanySelectedException, 405);
        }

        /// <summary>
        /// Change product stats when quantity changed.
        /// </summary>
        private void ProductQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProductQuantityTextBox.Text, out var quantityResult))
                ProductStatusDropDown.SelectedIndex = (int) (quantityResult > 0 ? Status.InStock : Status.Unavailable);
            else
                ProductStatusDropDown.SelectedIndex = (int) Status.Unavailable;
        }

        /// <summary>
        /// Change product image.
        /// </summary>
        private void ChangeImgButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openDialog = new OpenFileDialog
                {
                    Filter = ApplicationStrings.ImageFileDialogFilter
                })
                {
                    if (openDialog.ShowDialog() == DialogResult.OK)
                        ProductImage.Image = Image.FromFile(openDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Create new company.
        /// </summary>
        private void CreateCompanyButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var companyCreator = new CompanyCreatorForm())
                {
                    if (companyCreator.ShowDialog() != DialogResult.OK) return;
                    CompanyManager.Add(companyCreator.Company);
                    var tempCompany = ProductCompanyDropdown.SelectedItem;
                    GetData();
                    ProductCompanyDropdown.SelectedItem = tempCompany;
                    Refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit certain company.
        /// </summary>
        private void EditCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var tempCompany = CompanyManager.Get(ProductCompanyDropdown.SelectedItem.ToString());
                using (var companyCreator =
                    new CompanyCreatorForm(tempCompany))
                {
                    if (companyCreator.ShowDialog() != DialogResult.OK) return;

                    tempCompany.Clone(companyCreator.Company);

                    var selectedIndex = ProductCompanyDropdown.SelectedIndex;
                    GetData();
                    ProductCompanyDropdown.SelectedIndex = selectedIndex;
                    Refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set rules to textBox input.
        /// </summary>
        private void ProductQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }

        /// <summary>
        /// Set rules to textBox input.
        /// </summary>
        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | e.KeyChar.Equals('.') | e.KeyChar.Equals(',') |
                char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }

        /// <summary>
        /// Set rules to textBox input.
        /// </summary>
        private void ProductDiscountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) | e.KeyChar.Equals('.') | e.KeyChar.Equals(',') |
                char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }

        /// <summary>
        /// Set localization.
        /// </summary>
        private void ProductCreatorForm_Load(object sender, EventArgs e)
        {
            SetLocalization();
        }
    }
}