using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterV2
{
    public interface IDraw
    {
        void DrawPolyLine(List<Point> points);
        void DrawRectangle(Point start, double xSide, double ySide);
    }

}
