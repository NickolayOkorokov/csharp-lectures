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
            /////В данном задании не указано, что числа должны входить в диапазон, поэтому строго между вводимыми числами
            int numA, numB, i, z;
            Console.WriteLine("Following program will print the sum of all values between num1 and num2");
            z = 0;
            Console.WriteLine("\nPlease insert num 1");
            numA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease insert num 2");
            numB = Int32.Parse(Console.ReadLine());
            for (i = numA+1; i < numB; i++) {
                z = z + i;  
            }
            Console.WriteLine("Sum is {0}",z);
            //////////////////////////////////////////////////////////////////////////////////////////
            z = 0;
            Console.WriteLine("\n\nFollowing program will print you all odd values between the num1 and num2");
            Console.WriteLine("\nPlease insert num1");
            numA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease insert num2");
            numB = Int32.Parse(Console.ReadLine());
            for (i = numA; i <= numB; i++)
            {
                if ((i % 2) == 0) {
                    continue;
                }
            Console.WriteLine("values between : {0}", i); 
            }
            Console.ReadKey();

            }
        }
    }
