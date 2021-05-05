using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.Forms
{
    internal partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            this.Text = $@"About Notepad";
            this.labelProductName.Text = "Notepad";
            this.labelVersion.Text = $@"V.0.9.9";
            this.labelCopyright.Text = "@HSE's student";
            this.labelCompanyName.Text = "HSE";
            this.textBoxDescription.Text =
                "All functions, except compile code, are implemented, " + " to edit the code " +
                " - hover over the icon in the lower right corner. " +
                "Все функции реализованы, кроме компилиции кода, " +
                "чтобы редактировать код " +
                "- наведите на значок в правом нижнем углу";
        }
    }
}