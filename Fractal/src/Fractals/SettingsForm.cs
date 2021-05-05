using System;
using System.Globalization;
using System.Windows.Forms;
using Fractals.Classes.Configuration;
using Fractals.Classes.Entity.Enums;

namespace Fractals
{
    /// <summary>
    /// Class of settings form.
    /// </summary>
    public partial class SettingsForm : Form
    {
        #region Initialize

        /// <summary>
        /// Settings configuration.
        /// </summary>
        public SettingsConfiguration SettingsConfiguration { get; }
        /// <summary>
        /// Check saved configuration or no.
        /// </summary>
        public bool IsSaved { get; set; }

        /// <summary>
        /// Constructor to create form.
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();

            SettingsConfiguration = new SettingsConfiguration().GetDefaultSettings();

            InitializeSettingsFormControls();
        }

        /// <summary>
        /// Set default settings.
        /// </summary>
        private void InitializeSettingsFormControls()
        {
            fractalComboBox.SelectedIndex = SettingsConfiguration.SelectedFractalIndex;

            recursionDepthTextBox.Text = SettingsConfiguration.RecursionDepth.ToString();

            segmentLengthTextBox.Text = SettingsConfiguration.SegmentLength
                .ToString(CultureInfo.InvariantCulture);
            segmentWidthTextBox.Text = SettingsConfiguration.SegmentWidth
                .ToString(CultureInfo.InvariantCulture);

            leftAngleTextBox.Text = SettingsConfiguration.LeftAngle.ToString();
            rightAngleTextBox.Text = SettingsConfiguration.RightAngle.ToString();

            firstColorPanel.BackColor = SettingsConfiguration.StartColor;
            secondColorPanel.BackColor = SettingsConfiguration.EndColor;

            brushWidthTrackBar.Value = SettingsConfiguration.BrushWidth;

            enableRedrawCheckBox.Checked = SettingsConfiguration.IsRedraw;

            IsSaved = SettingsConfiguration.IsSaved;

            SettingsConfiguration.FractalType = ConvertFractalNameToFractalType(fractalComboBox.SelectedItem.ToString());
        }

        #endregion

        #region Check enter chars for valid 

        /// <summary>
        /// Forbid some chars for recursion text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recursionDepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Forbid type more than digit.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /// <summary>
        /// Forbid some chars for segment length text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void segmentLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Forbid type more than digit and some chars.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }

        /// <summary>
        /// Forbid some chars for left angle text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftAngleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Forbid type more than digit and some chars.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }
        /// <summary>
        /// Forbid some chars for right angle text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightAngleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Forbid type more than digit and some chars.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        /// <summary>
        /// Forbid some chars for segment width text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void segmentWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Forbid type more than digit.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region Save settings

        /// <summary>
        /// Actions when save is clicked: save current settings and close settings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check valid of parameters.

                if (!int.TryParse(recursionDepthTextBox.Text, out var recursionDepth))
                {
                    throw new ArgumentException($"{recursionDepthLabel.Text} Incorrect input.");
                }

                if (!float.TryParse(segmentLengthTextBox.Text, out var segmentLength))
                {
                    throw new ArgumentException($"{segmentLengthLabel.Text} Incorrect input.");
                }

                if (!float.TryParse(segmentWidthTextBox.Text, out var segmentWidth))
                {
                    throw new ArgumentException($"{segmentLengthLabel.Text} Incorrect input.");
                }

                if (!int.TryParse(leftAngleTextBox.Text, out var leftAngle))
                {
                    throw new ArgumentException($"{leftAngleLabel.Text} Incorrect input.");
                }

                if (!int.TryParse(rightAngleTextBox.Text, out var rightAngle))
                {
                    throw new ArgumentException($"{rightAngleLabel.Text} Incorrect input.");
                }


                ValidateRecursionDepth(recursionDepth);
                ValidateSegmentLength(segmentLength);
                ValidateSegmentWidth(segmentWidth);
                ValidateAngle(leftAngle);
                ValidateAngle(rightAngle);

                // Set parameters.
                SettingsConfiguration.RecursionDepth = recursionDepth;
                SettingsConfiguration.SegmentLength = segmentLength;
                SettingsConfiguration.SegmentWidth = segmentWidth;
                SettingsConfiguration.LeftAngle = leftAngle;
                SettingsConfiguration.RightAngle = rightAngle;
                SettingsConfiguration.SelectedFractalIndex = fractalComboBox.SelectedIndex;
                SettingsConfiguration.StartColor = firstColorPanel.BackColor;
                SettingsConfiguration.EndColor = secondColorPanel.BackColor;
                SettingsConfiguration.BrushWidth = brushWidthTrackBar.Value;

                MessageBox.Show(@"Successfully saved!", @"Message");
                IsSaved = true;
                SettingsConfiguration.IsSaved = IsSaved;

                // Close form.
                Close();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region Validate settings

        /// <summary>
        /// Check recursion depth for valid.
        /// </summary>
        /// <param name="recursionDepth">Selected recursion depth.</param>
        private void ValidateRecursionDepth(int recursionDepth)
        {
            if (recursionDepth < 0)
            {
                throw new ArgumentException("Recursion depth less than 0");
            }

            if (recursionDepth > SettingsConfiguration.MaxRecursionDepth)
            {
                throw new ArgumentException($"Recursion depth more than max recursion depth: {SettingsConfiguration.MaxRecursionDepth}");
            }
        }

        /// <summary>
        /// Check length of segment for valid.
        /// </summary>
        /// <param name="segmentLength">Selected length of segment.</param>
        private static void ValidateSegmentLength(float segmentLength)
        {
            if (segmentLength < 1)
            {
                throw new ArgumentException("Length of segment less than 1.");
            }

            if (segmentLength > Screen.PrimaryScreen.Bounds.Width)
            {
                throw new ArgumentException(
                    $"Length of segment more than screen width: {Screen.PrimaryScreen.Bounds.Width}");
            }
        }

        /// <summary>
        /// Check segment width for valid.
        /// </summary>
        /// <param name="segmentWidth">Selected segment width.</param>
        private static void ValidateSegmentWidth(float segmentWidth)
        {
            if (segmentWidth < 1)
            {
                throw new ArgumentException("Length of segment less than 1.");
            }

            if (segmentWidth > Screen.PrimaryScreen.Bounds.Height)
            {
                throw new ArgumentException(
                    $"Length of segment more than screen height: {Screen.PrimaryScreen.Bounds.Height}");
            }
        }

        /// <summary>
        /// Check angle for valid.
        /// </summary>
        /// <param name="angle">Selected angle.</param>
        private static void ValidateAngle(float angle)
        {
            if (angle < -120 || angle > 120)
            {
                throw new ArgumentException("Angle cannot be less than -120 or more than 120");
            }
        }

        #endregion

        #region Get some fractal settings

        /// <summary>
        /// Get type of fractal.
        /// </summary>
        /// <param name="source">Name of fractal.</param>
        /// <returns>Returns fractal type.</returns>
        private static FractalType ConvertFractalNameToFractalType(string source)
        {
            switch (source.ToLower(CultureInfo.InvariantCulture))
            {
                case "tree":
                    return FractalType.Tree;
                case "koch":
                    return FractalType.Koch;
                case "cantor set":
                    return FractalType.CantorSet;
                case "triangle":
                    return FractalType.Triangle;
                case "carpet":
                    return FractalType.Carpet;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Actions when combo box's index is changed: change property enabled of some addition settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fractalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftAngleTextBox.Enabled = false;
            rightAngleTextBox.Enabled = false;
            segmentWidthTextBox.Enabled = false;

            // Set parameters according to selected fractal.
            switch (fractalComboBox.SelectedItem.ToString()?.ToLower())
            {
                case "tree":
                    leftAngleTextBox.Enabled = true;
                    rightAngleTextBox.Enabled = true;
                    SettingsConfiguration.MaxRecursionDepth = 20;
                    break;
                case "koch":
                    SettingsConfiguration.MaxRecursionDepth = 12;
                    break;
                case "cantor set":
                    segmentWidthTextBox.Enabled = true;
                    SettingsConfiguration.MaxRecursionDepth = 10;
                    break;
                case "triangle":
                    SettingsConfiguration.MaxRecursionDepth = 10;
                    break;
                case "carpet":
                    SettingsConfiguration.MaxRecursionDepth = 6;
                    break;
                default:
                    SettingsConfiguration.MaxRecursionDepth = 5;
                    break;
            }
        }

        /// <summary>
        /// Actions when first color panel is clicked: change back color of this panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstColorPanel_Click(object sender, EventArgs e)
        {
            SetFractalColor(firstColorPanel);
        }

        /// <summary>
        /// Actions when second color panel is clicked: change back color of this panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondColorPanel_Click(object sender, EventArgs e)
        {
            SetFractalColor(secondColorPanel);
        }

        /// <summary>
        /// Select color of first or last iteration.
        /// </summary>
        /// <param name="panel">Panel, which get color.</param>
        private void SetFractalColor(Control panel)
        {
            if (fractalColorDialog.ShowDialog() == DialogResult.Cancel) return;

            panel.BackColor = fractalColorDialog.Color;
        }

        /// <summary>
        /// Actions when redraw check box checked is changed: rewrite 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enableRedrawCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsConfiguration.IsRedraw = enableRedrawCheckBox.Checked;
        }

        #endregion

        #endregion

        #region Close

        /// <summary>
        /// Actions when form is closed: check settings for valid and draw fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeSettingsFormControls();
            
            // Draw fractal after close this form.
            if (!SettingsConfiguration.IsSaved) return;
            
            var parentForm = Owner as FractalsForm;
            parentForm?.DrawFractal();

            SettingsConfiguration.IsSaved = false;
        }

        #endregion

    }
}