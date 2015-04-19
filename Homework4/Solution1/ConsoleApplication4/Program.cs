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
            Console.WriteLine("Insert your age");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert your name");
            string fname = Console.ReadLine();
            Console.WriteLine("Insert your surname");
            string lname = Console.ReadLine();
            Console.WriteLine("Insert your login");
            string login = Console.ReadLine();
            User user1 = new User(age, fname, lname, login);

            Console.ReadLine();
            User user2 = new User(age, fname, lname, login);
            Console.ReadLine();
        }
    }
}
