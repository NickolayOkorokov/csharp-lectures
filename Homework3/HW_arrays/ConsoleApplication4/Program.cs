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
            Console.WriteLine("Please insert size of array you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert what calue you want in arr+1");
            int value = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            Console.WriteLine("Init array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);

                Console.Write("  {0}", array[i]);
            }
            Console.WriteLine("\n\nNew array (length + 1)");
            ArrLengthInc(array, value);
            Console.ReadKey();
        }
        static void ArrLengthInc(int[] array, int value) {

            Array.Resize(ref array, array.Length + 1);
            for (int i = 0; i < array.Length; i++) {
                Console.Write("  {0}", array[i]);
                array[array.Length - 1] = value;
            }
           // Console.Write("\n {0}", array.Length);

        }
    }
}
