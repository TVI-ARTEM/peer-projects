using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Class to generate fractal triangle.
    /// </summary>
    public class FractalTriangle : Fractal
    {
        /// <summary>
        /// Polygons (triangles) of current fractal.
        /// </summary>
        private readonly List<Polygon> _polygons;

        /// <summary>
        /// Constructor to set parameters of fractal seprinski triangle.
        /// </summary>
        /// <param name="recursionDepth">Number of iteration.</param>
        /// <param name="segmentLength">Length of first segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        public FractalTriangle(int recursionDepth, float segmentLength, PointF startPoint) : base(recursionDepth, segmentLength, startPoint)
        {
            _polygons = new List<Polygon>();
        }

        /// <summary>
        /// Generate segments of current fractal.
        /// </summary>
        public override void Generate()
        {
            // Generate first triangles.
            var topPointX = StartPoint.X + SegmentLength * (float) Math.Cos(60 * Math.PI / 180);
            var topPointY = StartPoint.Y - SegmentLength * (float) Math.Sin(60 * Math.PI / 180);

            var topPoint = new PointF(topPointX, topPointY);

            var leftPoint = StartPoint;

            var rightPoint = new PointF(StartPoint.X + SegmentLength, StartPoint.Y);

            GenerateTriangleInternal(RecursionDepth, topPoint, leftPoint, rightPoint);

        }

        /// <summary>
        /// Internal method to generate segments of current fractal.
        /// </summary>
        /// <param name="recursion">Current iteration.</param>
        /// <param name="topPoint">Top point of triangle.</param>
        /// <param name="leftPoint">Left point of triangle.</param>
        /// <param name="rightPoint">Right point of triangle.</param>
        private void GenerateTriangleInternal(int recursion, PointF topPoint, PointF leftPoint, PointF rightPoint)
        {
            if (recursion == 0)
            {
                // Generate new segments for new triangle.
                Segments.Add(new Segment(leftPoint, rightPoint));
                Segments.Add(new Segment(leftPoint, topPoint));
                Segments.Add(new Segment(topPoint, rightPoint));

                var sides = new List<Segment>
                {
                    Segments[Segments.Count - 3],
                    Segments[Segments.Count - 2],
                    Segments[Segments.Count - 1]
                };

                // Create new triangle.
                _polygons.Add(new Polygon(sides));
            }
            else
            {
                // Calculate points for next triangles.
                var middleLeftPoint = Segment.MiddlePoint(topPoint, leftPoint);
                var middleRightPoint = Segment.MiddlePoint(topPoint, rightPoint);
                var middleTopPoint = Segment.MiddlePoint(leftPoint, rightPoint);

                // Recursion generation new triangles.
                GenerateTriangleInternal(recursion-1, topPoint, middleLeftPoint, middleRightPoint);
                GenerateTriangleInternal(recursion-1, middleLeftPoint, leftPoint, middleTopPoint);
                GenerateTriangleInternal(recursion-1, middleRightPoint, middleTopPoint, rightPoint);
            }
        }

        /// <summary>
        /// Draw current fractal.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="colors">List of colors to draw.</param>
        /// <param name="brushWidth">Brush width to draw.</param>
        public override void Draw(Graphics graphics, List<Color> colors, float brushWidth)
        {
            var pen = new Pen(Color.Black, brushWidth);

            var currentColor = 0;
            var currentIteration = 0;
            var segmentsOfIteration = 1;

            // Draw borders by selected colors.
            foreach (var polygon in _polygons)
            {
                polygon.Draw(graphics, pen);
            }

            // Fill triangles by selected colors.
            foreach (var polygon in _polygons)
            {
                polygon.Draw(graphics, new Pen(colors[currentColor]).Brush);
               
                if (++currentIteration != segmentsOfIteration) continue;
               
                currentIteration = 0;
                currentColor++;
                segmentsOfIteration *= 3;
            }
        }
    }
}
