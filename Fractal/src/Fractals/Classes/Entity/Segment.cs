using System;
using System.Drawing;

namespace Fractals.Classes.Entity
{
    public class Segment
    {
        /// <summary>
        /// Start point of current segment.
        /// </summary>
        public PointF StartPointF { get; }

        /// <summary>
        /// End point of current segment.
        /// </summary>
        public PointF EndPointF { get; }

        /// <summary>
        /// Middle point of current segment.
        /// </summary>
        public PointF MiddlePointF { get; }

        /// <summary>
        /// Length of current segment.
        /// </summary>
        public float Length { get; }

        /// <summary>
        /// Index color of current segment.
        /// </summary>
        public int CurrentColor { get; set; }

        /// <summary>
        /// Constructor to create new segment.
        /// </summary>
        /// <param name="startPointF">Start point to draw.</param>
        /// <param name="endPointF">End point to draw.</param>
        public Segment(PointF startPointF, PointF endPointF)
        {
            StartPointF = startPointF;
            EndPointF = endPointF;

            MiddlePointF = MiddlePoint(StartPointF, EndPointF);

            Length = GetLength();
        }

        /// <summary>
        /// Calculate middle point of current segment.
        /// </summary>
        /// <param name="firstPoint">Start point of current segment.</param>
        /// <param name="secondPoint">End point of current segment.</param>
        /// <returns></returns>
        public static PointF MiddlePoint(PointF firstPoint, PointF secondPoint)
        {
            return new PointF(
                (firstPoint.X + secondPoint.X) / 2f,
                (firstPoint.Y + secondPoint.Y) / 2f
            );
        }

        /// <summary>
        /// Get length of current segment.
        /// </summary>
        /// <returns>Returns length of current segment.</returns>
        private float GetLength()
        {
            return (float) Math.Sqrt(Math.Pow(EndPointF.X - StartPointF.X, 2) + Math.Pow(EndPointF.Y - StartPointF.Y, 2));
        }

        /// <summary>
        /// Draw segment.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="pen">Pen to draw.</param>
        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, StartPointF, EndPointF);
        }
    }
}
