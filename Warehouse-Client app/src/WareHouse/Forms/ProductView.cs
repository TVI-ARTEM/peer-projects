using System;
using System.Windows;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Helpers;

namespace WareHouse.Forms
{
    public partial class ProductView : UserControl
    {
        #region Properties

        /// <summary>
        /// Current product.
        /// </summary>
        public Product Product { get; }
        /// <summary>
        /// Owner form.
        /// </summary>
        private MainUser Owner { get; }

        #endregion

        public ProductView()
        {
            InitializeComponent();
        }

        public ProductView(Product product, MainUser owner) : this()
        {
            Product = product;
            Owner = owner;
        }

        #region Form manage

        /// <summary>
        /// Set data and localization.
        /// </summary>
        private void ProductView_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = string.Format(ApplicationStrings.ProductControlTitle, Product.Name);
            PriceLabel.Text = string.Format(ApplicationStrings.ProductControlPrice, Product.Price, Product.Currency);
            ProductBox.Image = ImgConverter.ConvertStringToImg(Product.Photo);
            MoreButton.Text = ApplicationStrings.ProductControlMore;

            ToolTip.SetToolTip(MoreButton, ApplicationStrings.MoreButtonToolTip);
            ToolTip.SetToolTipTitle(MoreButton, ApplicationStrings.MoreButtonToolTipTitle);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Change current product in owner form.
        /// </summary>
        private void BuyButton_Click(object sender, EventArgs e)
        {
            Owner.OnProductChange?.Invoke(Product);

        }

        #endregion
    }
}
