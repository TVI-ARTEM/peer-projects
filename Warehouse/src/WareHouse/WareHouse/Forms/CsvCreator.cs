using System;
using System.Globalization;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Exceptions;

namespace WareHouse.Forms
{
    public partial class CsvCreator : Form
    {
        /// <summary>
        /// Minimum product quantity.
        /// </summary>
        private int _minimumQuantity;

        public CsvCreator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Minimum product quantity.
        /// </summary>
        public int MinimumQuantity
        {
            get => _minimumQuantity;
            set
            {
                if (value < 1)
                {
                    throw new CustomDataException(ApplicationStrings.ProductMinimumQuantityException, 201);
                }

                _minimumQuantity = value;
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
        /// Set data to property from textBox.
        /// </summary>
        private void CsvCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;
            
            try
            {
                if (int.TryParse(ProductQuantityTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture,
                    out var quantityResult))
                {
                    MinimumQuantity = quantityResult;
                }
                else
                {
                    throw new CustomDataException(ApplicationStrings.ProductMinimumQuantityParseException);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Localize textBox placeholder. 
        /// </summary>
        private void CsvCreator_Load(object sender, EventArgs e)
        {
            ProductQuantityTextBox.TextPlaceholder = ApplicationStrings.MinimumQuantityPlaceholder;
        }
    }
}