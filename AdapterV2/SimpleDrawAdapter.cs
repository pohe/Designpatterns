using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterV2
{
    public class SimpleDrawAdapter : IDraw
    {
        private SimpleDraw _adaptee;

        public SimpleDrawAdapter()
        {
            _adaptee = new SimpleDraw();
        }

        public void DrawPolyLine(List<Point> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                _adaptee.DrawLine(points[i], points[i + 1]);
            }
        }

        public void DrawRectangle(Point start, double xSide, double ySide)
        {
            Point endX = new Point(start.X + xSide, start.Y);
            Point endY = new Point(start.X, start.Y + ySide);
            Point endXY = new Point(start.X + xSide, start.Y + ySide);

            _adaptee.DrawLine(start, endX);
            _adaptee.DrawLine(start, endY);
            _adaptee.DrawLine(endXY, endX);
            _adaptee.DrawLine(endXY, endY);
        }
    }

}
