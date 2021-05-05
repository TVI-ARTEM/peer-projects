using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Fractals.Classes.Entity
{
    /// <summary>
    /// Class to create polygon.
    /// </summary>
    public class Polygon
    {
        /// <summary>
        /// Segments of current polygon.
        /// </summary>
        public List<Segment> Segments { get; }

        /// <summary>
        /// Constructor to create new polygon.
        /// </summary>
        /// <param name="segments">Segments of current polygon.</param>
        public Polygon(List<Segment> segments)
        {
            Segments = segments;
        }

        /// <summary>
        /// Draw borders of current polygon.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="pen">Pen to draw.</param>
        public void Draw(Graphics graphics, Pen pen)
        {
            foreach (var segment in Segments)
            {
                segment.Draw(graphics, pen);
            }
        }

        /// <summary>
        /// Fill triangle by color.
        /// </summary>
        /// <param name="graphics">Graphics.</param>
        /// <param name="brush">Brush to draw.</param>
        public void Draw(Graphics graphics, Brush brush)
        {
            // Sort points of current polygon.
            var startPoints = Segments.Select(segment => segment.StartPointF).ToList();
            var endPoints = Segments.Select(segment => segment.EndPointF).ToList();

            var points = startPoints
                .Concat(endPoints)
                .Distinct()
                .OrderBy(point => point.X)
                .ToArray();
            
            graphics.FillPolygon(brush, points);
        }
    }
}
