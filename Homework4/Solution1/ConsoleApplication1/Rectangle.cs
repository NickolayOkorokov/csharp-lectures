using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle
    {
        private double side1, side2;
        private Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }
        private double PerimeterCalculator(double side1, double side2)
        {
            return side1 * 2 + side2 * 2;
        }
        public double Area { get { return AreaCalculator(side1, side2); } }
        public double Perimeter { get { return PerimeterCalculator(side1, side2); } }
    }
}
