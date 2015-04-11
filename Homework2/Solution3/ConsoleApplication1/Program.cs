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
            int number1, number2;
            Console.WriteLine("Insert number for attempt 1");
            number1 = Int32.Parse(Console.ReadLine());
            if ((number1 % 2) == 0)
                Console.WriteLine("Your number is even");
            else if ((number1 % 2) != 0)
                Console.WriteLine("Your number is not even");
            else
                Console.WriteLine("Please enter valid number");
            ////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Insert number for attempt 2");
            number2 = Int32.Parse(Console.ReadLine());
            if ((number2 & 1) == 0)
                Console.WriteLine("Your number is even");
            else if ((number2 & 1) != 0)
                Console.WriteLine("Your number is not even");
            else
                Console.WriteLine("Please enter valid number");
            Console.ReadKey();
        }
    }
}
