using System.Data;
using System.Windows.Forms;

namespace Excel
{
    public partial class SheetTabPage : TabPage
    {
        /// <summary>
        /// Sheet control.
        /// </summary>
        public SheetUserControl SheetUserControl;

        /// <summary>
        /// Constructor to create sheet tab page object.
        /// </summary>
        public SheetTabPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor to create sheet tab page object.
        /// </summary>
        /// <param name="dataTable">Data table.</param>
        public SheetTabPage(DataTable dataTable) : this()
        {
            SheetUserControl = new SheetUserControl(dataTable) {Dock = DockStyle.Fill};
            SheetUserControl.Select();
            Controls.Add(SheetUserControl);
        }
    }
}