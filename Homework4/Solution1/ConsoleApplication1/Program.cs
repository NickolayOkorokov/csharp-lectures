using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value 1");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2");
            int y = Int32.Parse(Console.ReadLine());
            Rectangle Rect = new Rectangle(x,y);
            Console.WriteLine("Perimeter = {0}, Area = {1}", Rect.Perimeter, Rect.Area);
            Console.ReadKey();
        }
    }
}
