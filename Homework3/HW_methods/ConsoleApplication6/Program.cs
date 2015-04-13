using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value you want to test");
            int num = Int32.Parse(Console.ReadLine());

            TestNum(num);
            Console.ReadLine();
        }
        static void TestNum(int num)
        {
            if (num > 0)
                Console.WriteLine("Number is positive");
            else
                Console.WriteLine("Num is negative");
            TestOfNumSimple(num);
            if (num % 2 == 0 && num % 3 == 0 && num % 5 == 0 && num % 6 == 0 && num % 9 == 0)
                Console.WriteLine("Num can be divided without residue");
            else
                Console.WriteLine("Num cannot divide on this values without a trace");
        }
        static void TestOfNumSimple(int num)
        {
            for (int i = 2; i < Math.Sqrt(num); i++)

                if (num % i == 0){
                    Console.WriteLine("Complicated");
                    break;}
                else
                {
                    Console.WriteLine("Simple");
                    break;
                }
            }
        }

    }
