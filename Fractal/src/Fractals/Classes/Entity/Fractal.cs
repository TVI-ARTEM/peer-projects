using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Base class for other fractals.
    /// </summary>
    public abstract class Fractal
    {
        /// <summary>
        /// Number of iteration.
        /// </summary>
        public int RecursionDepth { get; set; }
        /// <summary>
        /// Length of first segment.
        /// </summary>
        public float SegmentLength { get; set; }
        /// <summary>
        /// Start point to draw.
        /// </summary>
        public PointF StartPoint { get; set; }

        /// <summary>
        /// Segments of current fractal.
        /// </summary>
        public List<Segment> Segments;

        /// <summary>
        /// Constructor to set base parameters.
        /// </summary>
        /// <param name="recursionDepth">Number of iteration.</param>
        /// <param name="segmentLength">Length of first segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        protected Fractal(int recursionDepth, float segmentLength, PointF startPoint)
        {
            RecursionDepth = recursionDepth;
            SegmentLength = segmentLength;
            StartPoint = startPoint;

            Segments = new List<Segment>();
        }

        /// <summary>
        /// Generate segments of current fractal.
        /// </summary>
        public abstract void Generate();

        /// <summary>
        /// Draw current fractal.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="colors">List of colors to draw.</param>
        /// <param name="brushWidth">Brush width to draw.</param>
        public abstract void Draw(Graphics graphics, List<Color> colors, float brushWidth);
    }
}