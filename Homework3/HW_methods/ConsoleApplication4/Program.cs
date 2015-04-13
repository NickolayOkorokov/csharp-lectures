using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert num 1");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert math sign");
            string oper = Console.ReadLine();
            Console.WriteLine("Insert num 2");
            int y = Int32.Parse(Console.ReadLine());
            
            switch (oper) { 
                case "+":
                    Console.WriteLine("Your answer is {0}",Add(x, y));
                    break;
                case "-":
                    Console.WriteLine("Your answer is {0}", Sub(x, y));
                    break;
                case "*":
                    Console.WriteLine("Your answer is {0}", Mul(x, y));
                    break;
                case "/":
                    if (Div(x, y) != 0)
                        Console.WriteLine("Your answer is {0}", Div(x, y));
                    else
                        Console.WriteLine("Division by zero");
                    break;
                default:
                    Console.WriteLine("Please enter a valid sign");
                    break;
            }
            Console.ReadLine();
        }
        static int Add(int x, int y) {
           return x + y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
        static int Mul(int x, int y)
        {
            return x * y;
        }
        static int  Div(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                return 0;
        }

    }
}
