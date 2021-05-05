using System.Drawing;
using Fractals.Classes.Entity.Enums;

namespace Fractals.Classes.Configuration
{
    /// <summary>
    /// Class for get info of parameters to draw.
    /// </summary>
    public class SettingsConfiguration
    {
        /// <summary>
        /// Selected fractal.
        /// </summary>
        public FractalType FractalType { get; set; }
        /// <summary>
        /// Selected fractal's index.
        /// </summary>
        public int SelectedFractalIndex { get; set; }
        /// <summary>
        /// Max recursion depth of selected fractal.
        /// </summary>
        public int MaxRecursionDepth { get; set; }
        /// <summary>
        /// Selected recursion depth.
        /// </summary>
        public int RecursionDepth { get; set; }
        /// <summary>
        /// Selected segment length.
        /// </summary>
        public float SegmentLength { get; set; }
        /// <summary>
        /// Selected width between two iteration in fractal cantor set. 
        /// </summary>
        public float SegmentWidth { get; set; }
        /// <summary>
        /// Selected angle of first side in fractal tree.
        /// </summary>
        public int LeftAngle { get; set; }
        /// <summary>
        /// Selected angle of second side in fractal tree.
        /// </summary>
        public int RightAngle { get; set; }
        /// <summary>
        /// Selected color for first iteration.
        /// </summary>
        public Color StartColor { get; set; }
        /// <summary>
        /// Selected color for last iteration.
        /// </summary>
        public Color EndColor { get; set; }
        /// <summary>
        /// Selected brush width to draw.
        /// </summary>
        public int BrushWidth { get; set; }
        /// <summary>
        /// Check redraw while resizing or no.
        /// </summary>
        public bool IsRedraw { get; set; }

        /// <summary>
        /// Check saved configuration or no.
        /// </summary>
        public bool IsSaved { get; set; }


        /// <summary>
        /// Get default settings in first launch.
        /// </summary>
        /// <returns>Returns object of SettingsConfiguration contains default settings.</returns>
        public SettingsConfiguration GetDefaultSettings()
        {
            MaxRecursionDepth = 5;
            RecursionDepth = 5;
            SegmentLength = 100;
            SegmentWidth = 5;

            LeftAngle = 45;
            RightAngle = 45;

            SelectedFractalIndex = 0;

            StartColor = Color.Orange;
            EndColor = Color.DeepSkyBlue;

            BrushWidth = 2;

            IsRedraw = false;

            IsSaved = false;

            return this;
        }
    }
}
