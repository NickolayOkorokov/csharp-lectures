using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert amount of buyers");
            int n = 1;
            int a;
            a = Int32.Parse(Console.ReadLine());
            do{
            n *= a--;
            }
            while(a > 1);
            Console.WriteLine("Amount of possible routes is {0}",n);
            Console.ReadKey();

        }
    }
}
