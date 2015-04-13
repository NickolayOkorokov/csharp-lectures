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
            Console.WriteLine("Please insert size of mass you want");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            Console.WriteLine("Init mass");
            for (int i = 0; i < array.Length; i++){
             array[i] = rand.Next(0, 1000);

             Console.Write("  {0}", array[i]);
            }
            Console.WriteLine("\n\nOdd Numbers");
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] % 2 == 1)
                    Console.Write(" {0}", array[i]);
            }
            int sum = array.Sum();
            int maxValue = array.Max();
            int minValue = array.Min();
            int averageArifm = sum / array.Length;
            Console.WriteLine("\n\nMax value = {0},Min value =  {1},Sum of elements =  {2},Average arifmetic =  {3}", maxValue, minValue, sum, averageArifm);
            Console.ReadKey();
        }
    }
}
