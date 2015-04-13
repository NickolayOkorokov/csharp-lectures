using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert amount of money you want to convert");
            double value1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert exchange rate");
            double value2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Final amount will be {0}", Convert(value1, value2));
            Console.ReadLine();
        }
        static double Convert(double value1, double value2) {
            return value1 * value2;
        }
    }
}
