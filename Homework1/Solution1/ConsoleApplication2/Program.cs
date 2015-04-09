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
            Console.OutputEncoding = Encoding.UTF8;
            string my_string1, my_string2, my_string3;
            my_string1 = "\nмоя строка 1";
            my_string2 = "\tмоя строка 2";
            my_string3 = "\aмоя строка 3";
            Console.WriteLine(my_string1);
            Console.WriteLine(my_string2);
            Console.WriteLine(my_string3);
            Console.ReadLine();
        }
    }
}
