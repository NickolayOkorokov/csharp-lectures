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
           int i = 0;
           int k = 0;
           int z = 0;
           ///////////////////Rectangle/////////////////////////////////
           for (k = 0; k < 10; k++)
            {
                Console.WriteLine("\n");
                for (i = 0; i < 20; i++)
                {
                    Console.Write("*");
                }
            }
            ///////////////////Triangle/////////////////////////////////
             for (i = 1; i <= 10; i++)
                {
                    for ( k = 1; k <= i; k++)
                        Console.Write("*", " ");
                    Console.WriteLine();
                }
           /////////////Equilateral triangle////////////////////////////
             for (i = 0; i < 15; i++) {
                for (k = 15 - i; k > 0; k--)
                     Console.Write(" ");
                 for (k = 0; k <= i; k++)
                     Console.Write("*"+ " ");
                 Console.WriteLine();     
             }
           ///////////////////Rhombus/////////////////////////////////
           for (i = 0; i < 15; i++)
           {
               for (k = 15 - i; k > 0; k--)
                   Console.Write(" ");
               for (k = 0; k <= i; k++)
                   Console.Write("*" + " ");
               Console.WriteLine();
           }

             for (i = 1; i < 15; i++)
           {
               z++;
               for (k = 0; k <= i; k++)
                   Console.Write(" ");


               for (k = 15 - z; k > 0; k--)
               {
                   Console.Write("*" + " ");
               }
               Console.WriteLine();
           } 

                 Console.ReadKey();
        }
    }
}
