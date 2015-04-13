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
            int [] arr1 = new int[10];
            int [] arr2 = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(0, 1000);

                Console.Write("  {0}", arr1[i]);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
                    Console.Write("\n  {0}", arr2[i]);
            }
                Console.ReadKey();

        }
    }
}
