using System.Windows.Forms;

namespace WareHouse.Forms
{
    public partial class GenerateForm : Form
    {
        /// <summary>
        /// Root quantity.
        /// </summary>
        public int RootQuantity;
        /// <summary>
        /// Section quantity.
        /// </summary>
        public int SectionQuantity;
        /// <summary>
        /// Product quantity.
        /// </summary>
        public int ProductQuantity;
        /// <summary>
        /// Recursion depth.
        /// </summary>
        public int RecursionDepth;

        public GenerateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set values.
        /// </summary>
        private void GenerateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK) return;
            RootQuantity = RootQuantityHSlider.Value;
            SectionQuantity = SectionQuantiyHSlider.Value;
            ProductQuantity = ProductQuantityHSlider.Value;
            RecursionDepth = RecursionDepthHSlider.Value;
        }
    }
}
