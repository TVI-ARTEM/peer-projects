using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Class to generate fractal koch.
    /// </summary>
    public class FractalKoch : Fractal
    {
        /// <summary>
        /// Constructor to set parameters of fractal koch.
        /// </summary>
        /// <param name="recursionDepth">Number of iteration.</param>
        /// <param name="segmentLength">Length of first segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        public FractalKoch(int recursionDepth, float segmentLength, PointF startPoint) : base(recursionDepth, segmentLength, startPoint)
        {

        }

        /// <summary>
        /// Generate segments of current fractal.
        /// </summary>
        public override void Generate()
        {
            // Generate first segment.
            Segments.Add(new Segment(StartPoint, StartPoint));
            GenerateFractalKochInternal(RecursionDepth, SegmentLength, StartPoint, 0);
        }

        /// <summary>
        /// Internal method to generate segments of current fractal.
        /// </summary>
        /// <param name="recursionDepth">Current iteration.</param>
        /// <param name="length">Length of current segment.</param>
        /// <param name="startPoint">Start point to draw.</param>
        /// <param name="angleTilt">Angle tilt of current segment.</param>
        private void GenerateFractalKochInternal(int recursionDepth, float length, PointF startPoint, int angleTilt)
        {
            if (recursionDepth == 0)
            {
                // Create new segments.
                var endPointX = startPoint.X + length * (float) Math.Cos(angleTilt * Math.PI / 180);
                var endPointY = startPoint.Y - length * (float) Math.Sin(angleTilt * Math.PI / 180);

                var endPoint = new PointF(endPointX, endPointY);

                Segments.Add(new Segment(startPoint, endPoint));
            }
            else
            {
                // Recursion generation segments.
                GenerateFractalKochInternal(recursionDepth - 1, length / 3, 
                    Segments[Segments.Count - 1].EndPointF, angleTilt);
                GenerateFractalKochInternal(recursionDepth - 1, length / 3, 
                    Segments[Segments.Count - 1].EndPointF, angleTilt + 60);
                GenerateFractalKochInternal(recursionDepth - 1, length / 3, 
                    Segments[Segments.Count - 1].EndPointF, angleTilt - 60);
                GenerateFractalKochInternal(recursionDepth - 1, length / 3, 
                    Segments[Segments.Count - 1].EndPointF, angleTilt);
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
            var currentColor = 0;
            
            // Sort list of segments by their middle point.
            var segments = Segments.OrderByDescending(x => x.MiddlePointF.Y).ToList();

            var currentMiddlePointY = segments[0].MiddlePointF.Y;
            // Draw segments by selected colors.
            foreach (var segment in segments)
            {
                if (Math.Abs(segment.MiddlePointF.Y - currentMiddlePointY) > float.Epsilon)
                {
                    currentColor = currentColor + 1 == colors.Count ? 0 : currentColor + 1;

                    currentMiddlePointY = segment.MiddlePointF.Y;
                }

                segment.Draw(graphics, new Pen(colors[currentColor], brushWidth));
            }
        }
    }
}