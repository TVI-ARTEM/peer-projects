using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Class to generate fractal tree.
    /// </summary>
    public class FractalTree : Fractal
    {
        /// <summary>
        /// Angle tilt of first (left) segments.
        /// </summary>
        public int AngleTiltFirstSegment { get; set; }

        /// <summary>
        /// Angle tilt of second (right) segments.
        /// </summary>
        public int AngleTiltSecondSegment { get; set; }

        /// <summary>
        /// Constructor to set parameters of fractal tree.
        /// </summary>
        /// <param name="recursionDepth">Number of iteration.</param>
        /// <param name="segmentLength">Length of first segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        /// <param name="angleTiltFirstSegment">Angle tilt of first (left) segments.</param>
        /// <param name="angleTiltSecondSegment">Angle tilt of second (right) segments.</param>
        public FractalTree(
            int recursionDepth,
            float segmentLength,
            PointF startPoint,
            int angleTiltFirstSegment,
            int angleTiltSecondSegment
        ) : base(recursionDepth, segmentLength, startPoint)
        {
            AngleTiltFirstSegment = angleTiltFirstSegment;
            AngleTiltSecondSegment = angleTiltSecondSegment;
        }

        /// <summary>
        /// Generate segments of current fractal.
        /// </summary>
        public override void Generate()
        {
            GenerateFractalTreeInternal(RecursionDepth, SegmentLength, StartPoint, 90);
        }

        /// <summary>
        /// Internal method to generate segments of current fractal.
        /// </summary>
        /// <param name="recursionDepth">Current iteration.</param>
        /// <param name="length">Length of current segment.</param>
        /// <param name="startPoint">Start point of current segment to draw.</param>
        /// <param name="angleTilt">Angle tilt of current segment.</param>
        private void GenerateFractalTreeInternal(int recursionDepth, float length, PointF startPoint, int angleTilt)
        {
            // Creating new segments.
            var endPointX = startPoint.X + length * (float) Math.Cos(angleTilt * Math.PI / 180);
            var endPointY = startPoint.Y - length * (float) Math.Sin(angleTilt * Math.PI / 180);

            var endPoint = new PointF(endPointX, endPointY);

            Segments.Add(new Segment(startPoint, endPoint) {CurrentColor = recursionDepth});

            if (recursionDepth < 1) return;
            // Recursion creating segments.
            GenerateFractalTreeInternal(recursionDepth - 1, length / 1.5f, endPoint, angleTilt + AngleTiltFirstSegment);
            GenerateFractalTreeInternal(recursionDepth - 1, length / 1.5f, endPoint, angleTilt - AngleTiltSecondSegment);
        }

        /// <summary>
        /// Draw current fractal.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="colors">List of colors to draw.</param>
        /// <param name="brushWidth">Brush width to draw.</param>
        public override void Draw(Graphics graphics, List<Color> colors, float brushWidth)
        {
            // Draw segments by selected segments.
            foreach (var segment in Segments)
            {
                segment.Draw(graphics, new Pen(colors[colors.Count - 1  - segment.CurrentColor], brushWidth));
            }
        }
    }
}