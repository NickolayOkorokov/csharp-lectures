using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  x = 5, y = 10, z = 15;
            	x += y >> x++ * z; 
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x, y, z);

            x = 5; y = 10; z = 15;
	            z = ++x & y * 5; 
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x, y, z);

            x = 5; y = 10; z = 15;
              y /= x + 5 | z; 
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x, y, z);

            x = 5; y = 10; z = 15;
              z = x++ & y * 5; 
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x, y, z);

            x = 5; y = 10; z = 15;
              x = y << x++ ^ z; 
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x, y, z);
          
           Console.ReadKey();
        }
    }
}
