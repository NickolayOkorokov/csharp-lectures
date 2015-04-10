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
            int operand1, operand2, equals;
            string mathsign;
            operand1 = 14;
            operand2 = 7;

            Console.Write("Enter math sign you want\n");
            mathsign = Console.ReadLine();
            switch (mathsign) { 
                case "+":
                    equals = operand1 + operand2;
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, mathsign, operand2, equals);
                    break;
                case "-":
                    equals = operand1 - operand2;
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, mathsign, operand2, equals);
                    break;
                case "/":
                    equals = operand1 / operand2;
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, mathsign, operand2, equals);
                    break;
                case "*":
                    equals = operand1 * operand2;
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, mathsign, operand2, equals);
                    break;
                default:
                    Console.WriteLine("Enter valid math sign");
                    break;
            }
            Console.ReadLine();
        }
    }
}
