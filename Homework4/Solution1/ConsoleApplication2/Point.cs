using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Point
    {
        private int point1, point2;
        private string pointString;
        public int pointA { get { return point1; } }
        public int pointB { get { return point2; } }
        public string pointStr { get { return pointString; } }
        private Point(int point1, int point2, string pointString)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.pointString = pointString;
        }

    }
}
