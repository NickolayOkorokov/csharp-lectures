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
            Console.WriteLine("Please insert size of mass you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert index from which you want see the mass");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert amount of values you want see frow mass");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            Console.WriteLine("Init mass");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);

                Console.Write("  {0}", array[i]);
            }
            System.Console.WriteLine("\n\nReversed");
            MyReverse(array);
            System.Console.WriteLine("\n\nParticular");
            SubArray(array, index, count);

            Console.ReadKey();
        }
        ///////////////////Mass for reverse/////////////
        static void MyReverse(int[] array) {
            array = (array.Reverse()).ToArray();
            for (int i = 0; i < array.Length; i++) {
                Console.Write(" {0}", array[i]);
            }
        }
        //////////////Mass for particular output//////////////
        static void SubArray(int[] array, int index, int count) {
            for (int i = index, count2 = 0; count2 < count; count2++, i++){
               // if ((count + index) <= array.Length)
                Console.Write(" {0}",array[i]);
                /*else
                {
                    int [] array2 = new int[count - (array.Length - index)];
                    int[] array3 = new int[array.Length + array2.Length];
                    for (int j = 0; j < count - (array.Length - index); j++)
                    {
                        array2[j] = 1;
                        

                        //array3[j] = array[j] + array2[j];
                        Console.Write(" {0}", array3[j]);   
                    }
                }*//////////К сожалению, без второго условия про превышения значения размера масси
                ///////////ва, не понимаю, ка кдобавить массив в конец существующего массива
            }
        }
       
    }
}
