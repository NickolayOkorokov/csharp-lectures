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
            float number;
            Console.Write("Enter your number\n");
            number = Int32.Parse(Console.ReadLine());
            if (0 <= number & 14 >= number)
                Console.WriteLine("You got to [0-14] gap");
            else if (15 <= number & 35 >= number)
                Console.WriteLine("You got to [15-35] gap");
            else if (36 <= number & 50 >= number)
                Console.WriteLine("You got to [36-50] gap");
            else if (50 <= number & 100 >= number)
                Console.WriteLine("You got to [50-100] gap");
            else
                Console.WriteLine("Please, enter another number");
            Console.ReadKey();
            }



        }
    }

