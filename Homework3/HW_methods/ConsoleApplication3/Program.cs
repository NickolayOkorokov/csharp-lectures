using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    { 
        

        public int Add(int x, int y) {
            return x + y;
        }
        public void Forsmth(string[] args) {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            Add(num1, num2);
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert smth");
            Console.ReadLine();
        }
    }
}
