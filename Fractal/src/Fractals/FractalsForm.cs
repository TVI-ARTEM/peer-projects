using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using Fractals.Classes.Configuration;
using Fractals.Classes.Entity;
using Fractals.Classes.Entity.Enums;

namespace Fractals
{
    /// <summary>
    /// Class of main form.
    /// </summary>
    public partial class FractalsForm : Form
    {
        #region Initialize

        /// <summary>
        /// Addition settings form.
        /// </summary>
        private SettingsForm _settingsForm;

        /// <summary>
        /// Settings configuration.
        /// </summary>
        private readonly SettingsConfiguration _settingsConfiguration;

        /// <summary>
        /// Selected zoom.
        /// </summary>
        private int _currentZoom;

        /// <summary>
        /// Check image is drawn.
        /// </summary>
        private bool _isDrawImage;

        /// <summary>
        /// Current stretch.
        /// </summary>
        private float CurrentStretch => (Height * Width * 0.15f) / (MinimumSize.Width * MinimumSize.Height);

        /// <summary>
        /// Constructor to create form.
        /// </summary>
        public FractalsForm()
        {
            InitializeComponent();

            _settingsForm = new SettingsForm {Owner = this};

            _settingsConfiguration = _settingsForm.SettingsConfiguration;

            _currentZoom = 1;

            _isDrawImage = false;
        }

        /// <summary>
        /// Actions while loading form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalsForm_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
        }

        #endregion

        #region Draw fractal

        /// <summary>
        /// Draw selected fractal.
        /// </summary>
        public void DrawFractal()
        {
            try
            {
                _isDrawImage = true;

                saveToolStripMenuItem.Enabled = _isDrawImage;

                fractalPictureBox.Refresh();


                var bitmap = new Bitmap(20000, 20000);

                Fractal fractal;
                // Generate selected fractal.
                switch (_settingsConfiguration.FractalType)
                {
                    case FractalType.Tree:
                        fractal = CreateFractalTree(bitmap);
                        break;
                    case FractalType.Koch:
                        fractal = CreateFractalKoch(bitmap);
                        break;
                    case FractalType.CantorSet:
                        fractal = CreateFractalCantorSet(bitmap);
                        break;
                    case FractalType.Triangle:
                        fractal = CreateFractalTriangle(bitmap);
                        break;
                    case FractalType.Carpet:
                        fractal = CreateFractalCarpet();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (fractal == null) return;
                // Generate segments of fractal and draw thew. 
                fractal.Generate();
                fractal.Draw(Graphics.FromImage(bitmap), GenerateColors(fractal.RecursionDepth),
                    _settingsConfiguration.BrushWidth * _currentZoom);
                
                // Resize bitmap by size of fractal. 
                fractalPictureBox.Image = ResizeFractalImage(fractal, bitmap);
                
                // Set fractal to center.
                SetCenterFractalPictureBox();
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show(exception.Message + Environment.NewLine +
                                @"Try to change: recursion depth, segment length or zoom", 
                    @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (StackOverflowException exception)
            {
                MessageBox.Show(exception.Message + Environment.NewLine + 
                                @"Try to change: recursion depth, segment length or zoom", 
                    @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Create object of fractal koch.
        /// </summary>
        /// <param name="bitmap">Bitmap to draw.</param>
        /// <returns>Returns fractal koch.</returns>
        private Fractal CreateFractalKoch(Image bitmap)
        {
            var startPoint = new PointF(0, bitmap.Height / 2.0f);

            var fractal = new FractalKoch(
                _settingsConfiguration.RecursionDepth,
                _settingsConfiguration.SegmentLength * _currentZoom * CurrentStretch,
                startPoint
            );

            return fractal;
        }

        /// <summary>
        /// Create object of fractal cantor set.
        /// </summary>
        /// <param name="bitmap">Bitmap to draw.</param>
        /// <returns>Returns fractal cantor set.</returns>
        private Fractal CreateFractalCantorSet(Image bitmap)
        {
            var startPoint = new PointF(0, bitmap.Height / 2.0f);

            var fractal = new FractalCantorSet(
                _settingsConfiguration.RecursionDepth,
                _settingsConfiguration.SegmentLength * _currentZoom * CurrentStretch,
                startPoint,
                _settingsConfiguration.SegmentWidth * _currentZoom * CurrentStretch
            );

            return fractal;
        }

        /// <summary>
        /// Create object of fractal triangle.
        /// </summary>
        /// <param name="bitmap">Bitmap to draw.</param>
        /// <returns>Returns fractal triangle.</returns>
        private Fractal CreateFractalTriangle(Image bitmap)
        {
            var startPoint = new PointF(0, bitmap.Height - 50);

            var fractal = new FractalTriangle(
                _settingsConfiguration.RecursionDepth,
                _settingsConfiguration.SegmentLength * _currentZoom * CurrentStretch,
                startPoint
            );

            return fractal;
        }

        /// <summary>
        /// Create object of fractal tree.
        /// </summary>
        /// <param name="bitmap">Bitmap to draw.</param>
        /// <returns>Returns fractal tree.</returns>
        private Fractal CreateFractalTree(Image bitmap)
        {
            var startPoint = new PointF(bitmap.Width / 2.0f, bitmap.Height - 50);

            var fractal = new FractalTree(
                _settingsConfiguration.RecursionDepth,
                _settingsConfiguration.SegmentLength * _currentZoom * CurrentStretch,
                startPoint,
                _settingsConfiguration.LeftAngle,
                _settingsConfiguration.RightAngle
            );

            return fractal;
        }

        /// <summary>
        /// Create object of fractal carpet.
        /// </summary>
        /// <returns>Returns fractal tree.</returns>
        private Fractal CreateFractalCarpet()
        {
            var startPoint = new PointF(0,  50);

            var fractal = new FractalCarpet(
                _settingsConfiguration.RecursionDepth,
                _settingsConfiguration.SegmentLength * _currentZoom * CurrentStretch,
                startPoint
            );

            return fractal;
        }

        /// <summary>
        /// Generate list of gradient colors.
        /// </summary>
        /// <param name="recursion">Number of iteration.</param>
        /// <returns>Returns list of gradient colors.</returns>
        private List<Color> GenerateColors(int recursion)
        {
            recursion++;
            var rMax = _settingsConfiguration.EndColor.R;
            var rMin = _settingsConfiguration.StartColor.R;

            var gMax = _settingsConfiguration.EndColor.G;
            var gMin = _settingsConfiguration.StartColor.G;
            
            var bMax = _settingsConfiguration.EndColor.B;
            var bMin = _settingsConfiguration.StartColor.B;


            var colorList = new List<Color>();
            for (var i = 0; i < recursion; i++)
            {
                var rAverage = rMin + (int)((rMax - rMin) * i / recursion);
                var gAverage = gMin + (int)((gMax - gMin) * i / recursion);
                var bAverage = bMin + (int)((bMax - bMin) * i / recursion);
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }

            return colorList;
        }

        /// <summary>
        /// Resize bitmap by size of fractal.
        /// </summary>
        /// <param name="fractal">Current fractal.</param>
        /// <param name="bitmap">Bitmap to resize.</param>
        /// <returns>Resized bitmap.</returns>
        private static Bitmap ResizeFractalImage(Fractal fractal, Bitmap bitmap)
        {
            var fractalSegments = fractal.Segments;
            // Get size of current fractal.
            var xMin = fractalSegments.Min(segment => segment.EndPointF.X < segment.StartPointF.X
                ? segment.EndPointF.X
                : segment.StartPointF.X);

            var yMin = fractalSegments.Min(segment => segment.EndPointF.Y < segment.StartPointF.Y
                ? segment.EndPointF.Y
                : segment.StartPointF.Y);

            var xMax = fractalSegments.Max(segment => segment.EndPointF.X > segment.StartPointF.X
                ? segment.EndPointF.X
                : segment.StartPointF.X);

            var yMax = fractalSegments.Max(segment => segment.EndPointF.Y > segment.StartPointF.Y
                ? segment.EndPointF.Y
                : segment.StartPointF.Y);

            // Resize current bitmap.
            return bitmap.Clone(
                new Rectangle(
                    (int)xMin, (int)yMin,
                    (int)Math.Round(xMax - xMin + 1),
                    (int)Math.Round(yMax - yMin) + 10
                ),
                bitmap.PixelFormat
            );
        }

        #endregion

        #region Menu strip

        #region File menu

        /// <summary>
        /// Actions when save is clicked: save fractal image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save bitmap of picture box to file.
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = @"Saving image";
                saveDialog.DefaultExt = ".png";
                saveDialog.AddExtension = true;
                saveDialog.Filter = @"Image Files(*.png)|*.png";

                if (saveDialog.ShowDialog(this) != DialogResult.OK) return;

                (fractalPictureBox.Image as Bitmap)?.Save(saveDialog.FileName, ImageFormat.Png);

                MessageBox.Show(this, @"Image successfully saved!", @"Saving image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Actions when exit is clicked: close form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close form.
            Close();
        }

        #endregion

        #region Tools menu

        /// <summary>
        /// Actions when settings is clicked: open settings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settingsForm.ShowDialog();
        }

        /// <summary>
        /// Actions when zoom x1 is clicked: resize fractal by current zoom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomX1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentZoom == 1) return;

            _currentZoom = 1;

            if (!_isDrawImage) return;
            
            DrawFractal();
        }

        /// <summary>
        /// Actions when zoom x2 is clicked: resize fractal by current zoom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentZoom == 2) return;

            _currentZoom = 2;

            if (!_isDrawImage) return;
            
            DrawFractal();
        }

        /// <summary>
        /// Actions when zoom x3 is clicked: resize fractal by current zoom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomX3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentZoom == 3) return;

            _currentZoom = 3;

            if (!_isDrawImage) return;
           
            DrawFractal();
        }

        /// <summary>
        /// Actions when zoom x5 is clicked: resize fractal by current zoom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomX5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentZoom == 5) return;

            _currentZoom = 5;
            
            if (!_isDrawImage) return;
            
            DrawFractal();
        }

        #endregion

        #endregion

        #region Buttons

        /// <summary>
        /// Actions when generate is clicked: generate and draw selected fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            DrawFractal();
        }

        /// <summary>
        /// Actions when clear is clicked: clear image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (fractalPictureBox.Image == null) return;

            _isDrawImage = false;

            saveToolStripMenuItem.Enabled = _isDrawImage;

            fractalPictureBox.Image.Dispose();
            fractalPictureBox.Image = null;
        }

        #endregion

        #region Resize and close

        /// <summary>
        /// Actions when size of form is changed: redraw fractal or just set to center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalsForm_Resize(object sender, EventArgs e)
        {
            if (_settingsConfiguration.IsRedraw && _isDrawImage)
            {
                DrawFractal();
            }
            else
            {
                SetCenterFractalPictureBox();
            }
        }

        /// <summary>
        /// Set picture box to center.
        /// </summary>
        private void SetCenterFractalPictureBox()
        {
            if (fractalPictureBox.Image == null) return;

            var fractalImageSize = fractalPictureBox.Image.Size;
            var fractalPanelSize = fractalPanel.Size;

            // Change picture box location.
            fractalPictureBox.Location = fractalImageSize.Height < fractalPanelSize.Height
                ? new Point(fractalPictureBox.Location.X, (fractalPanelSize.Height - fractalImageSize.Height) / 2)
                : new Point(fractalPictureBox.Location.X, 0);

            fractalPictureBox.Location = fractalImageSize.Width < fractalPanelSize.Width
                ? new Point((fractalPanelSize.Width - fractalImageSize.Width) / 2, fractalPictureBox.Location.Y)
                : new Point(0, fractalPictureBox.Location.Y);
        }

        /// <summary>
        /// Actions while form closing: dispose settings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FractalsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settingsForm.Owner = null;
            _settingsForm = null;
        }

        #endregion
    }
}