using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Class to generate fractal cantor set.
    /// </summary>
    public class FractalCantorSet : Fractal
    {
        /// <summary>
        /// Width between two iteration.
        /// </summary>
        private readonly float _segmentWidth;

        /// <summary>
        /// Constructor to set parameters of fractal cantor set.
        /// </summary>
        /// <param name="recursionDepth">Number of iteration.</param>
        /// <param name="segmentLength">Length first segment</param>
        /// <param name="startPoint">Start point to draw.</param>
        /// <param name="segmentWidth">Width between two iteration.</param>
        public FractalCantorSet(int recursionDepth, float segmentLength, PointF startPoint, float segmentWidth) 
            : base(recursionDepth, segmentLength, startPoint)
        {
            _segmentWidth = segmentWidth;
        }
       
        /// <summary>
        /// Generate segments of current fractal.
        /// </summary>
        public override void Generate()
        {
            GenerateFractalCantorSetInternal(RecursionDepth, SegmentLength, StartPoint);
        }

        /// <summary>
        /// Internal method to generate segments of current fractal.
        /// </summary>
        /// <param name="recursionDepth">Current iteration.</param>
        /// <param name="length">Length of current segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        private void GenerateFractalCantorSetInternal(int recursionDepth, float length, PointF startPoint)
        {
            // Create new points and add new segment.
            var endPointX = startPoint.X + length;
            var endPointY = startPoint.Y;
            
            var endPoint = new PointF(endPointX, endPointY);

            Segments.Add(new Segment(startPoint, endPoint){CurrentColor = recursionDepth});
            // Check current iteration.
            if (recursionDepth == 0) return;
            
            // Recursion generation.
            startPoint.Y += _segmentWidth;
            GenerateFractalCantorSetInternal(recursionDepth - 1, length / 3, startPoint);

            startPoint.X += length * 2 / 3;
            GenerateFractalCantorSetInternal(recursionDepth - 1, length / 3, startPoint);
        }

        /// <summary>
        /// Draw current fractal.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="colors">List of colors to draw.</param>
        /// <param name="brushWidth">Brush width to draw.</param>
        public override void Draw(Graphics graphics, List<Color> colors, float brushWidth)
        {
            // Draw segments by selected colors.
            foreach (var segment in Segments)
            {
                segment.Draw(graphics, new Pen(colors[colors.Count - 1 - segment.CurrentColor], brushWidth ));
            }
        }
    }
}
