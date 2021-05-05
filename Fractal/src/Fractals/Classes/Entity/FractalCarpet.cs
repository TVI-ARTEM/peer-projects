using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Class to generate fractal carpet.
    /// </summary>
    public class FractalCarpet: Fractal
    {
        /// <summary>
        /// Polygons (rectangle) of current fractal.
        /// </summary>
        private readonly List<Polygon> _polygons;

        /// <summary>
        /// Constructor to set parameters of fractal serpinski carpet.
        /// </summary>
        /// <param name="recursionDepth">Number of iteration.</param>
        /// <param name="segmentLength">Length of first segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        public FractalCarpet(int recursionDepth, float segmentLength, PointF startPoint) : base(recursionDepth, segmentLength, startPoint)
        {
            _polygons = new List<Polygon>();
        }
        
        /// <summary>
        /// Generate segments of current fractal.
        /// </summary>
        public override void Generate()
        {
            // Generate base rectangle.
            var rectangle = new RectangleF(StartPoint.X, StartPoint.Y, SegmentLength, SegmentLength);
            GenerateCarpetInternal(RecursionDepth, rectangle);
        }

        /// <summary>
        /// Internal method to generate segments of current fractal.
        /// </summary>
        /// <param name="recursion">Current iteration.</param>
        /// <param name="rectangle"></param>
        private void GenerateCarpetInternal(int recursion, RectangleF rectangle)
        {
            if (recursion==0)
            {
                // Creating new segments of new polygon.
                Segments.Add(new Segment(new PointF(rectangle.X, rectangle.Y),
                    new PointF(rectangle.X, rectangle.Y + rectangle.Height)));

                Segments.Add(new Segment(new PointF(rectangle.X, rectangle.Y),
                    new PointF(rectangle.X + rectangle.Width, rectangle.Y)));

                Segments.Add(new Segment(new PointF(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height),
                    new PointF(rectangle.X, rectangle.Y + rectangle.Height)));

                Segments.Add(new Segment(new PointF(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height),
                    new PointF(rectangle.X + rectangle.Width, rectangle.Y)));

                var sides = new List<Segment>
                {
                    Segments[Segments.Count - 4], 
                    Segments[Segments.Count - 3], 
                    Segments[Segments.Count - 2], 
                    Segments[Segments.Count - 1]
                };
                // Creating new polygon.
                _polygons.Add(new Polygon(sides));
            }
            else
            {
                // Creating new points to create new rectangles. 
                var newRectangleWidth = rectangle.Width / 3f;
                var newRectangleHeight = rectangle.Height / 3f;

                var newXFirst = rectangle.Left;
                var newXSecond = newXFirst + newRectangleWidth;
                var newXThird = newXFirst + 2*newRectangleWidth;

                var newYFirst = rectangle.Top;
                var newYSecond = newYFirst + newRectangleHeight;
                var newYThird = newYFirst + 2 * newRectangleHeight;

                // Recursion generation polygons.
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXFirst, newYFirst, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXSecond, newYFirst, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXThird, newYFirst, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXFirst, newYSecond, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXThird, newYSecond, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXFirst, newYThird, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXSecond, newYThird, newRectangleWidth, newRectangleHeight));
                GenerateCarpetInternal(recursion - 1, new RectangleF(newXThird, newYThird, newRectangleWidth, newRectangleHeight));
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
            var segmentsOfIteration = 9;

            // Draw borders of rectangles.
            foreach (var polygon in _polygons)
            {
                polygon.Draw(graphics, pen);
            }
            // Fill rectangles by selected colors.
            foreach (var polygon in _polygons)
            {
                polygon.Draw(graphics,new Pen(colors[currentColor]).Brush);

                if (++currentIteration != segmentsOfIteration) continue;
                currentIteration = 0;
                currentColor++;
                segmentsOfIteration *= 9;
            }
        }
    }
}
