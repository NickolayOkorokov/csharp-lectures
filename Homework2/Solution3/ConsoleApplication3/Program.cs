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
            int years, prize, salary;
            Console.WriteLine("Insert the amount of years you have worked");
            years = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert your salary");
            salary = Int32.Parse(Console.ReadLine());
           //////// Здесь должна была быть какая-то проверка на правильность вводимых данных, не совсем разобрался как ее делать
                if (years <= 5)
                {
                    prize = (salary * 10) / 100;
                    salary += prize;
                    Console.WriteLine("Your prize is 10% and it is {0} dollars, now your salary is {1}", prize, salary);
                }
                else if (5 <= years & years < 10)
                {
                    prize = (salary * 15) / 100;
                    salary += prize;
                    Console.WriteLine("Your prize is 15% and it is {0} dollars, now your salary is {1}", prize, salary);
                }
                else if (10 <= years & years < 15)
                {
                    prize = (salary * 25) / 100;
                    salary += prize;
                    Console.WriteLine("Your prize is 25% and it is {0} dollars, now your salary is {1}", prize, salary);
                }
                else if (15 <= years & years < 20)
                {
                    prize = (salary * 35) / 100;
                    salary += prize;
                    Console.WriteLine("Your prize is 35% and it is {0} dollars, now your salary is {1}", prize, salary);
                }
                else if (20 <= years & years < 25)
                {
                    prize = (salary * 45) / 100;
                    salary += prize;
                    Console.WriteLine("Your prize is 45% and it is {0} dollars, now your salary is {1}", prize, salary);
                }
                else if (25 <= years)
                {
                    prize = (salary * 50) / 100;
                    salary += prize;
                    Console.WriteLine("Your prize is 50% and it is {0} dollars, now your salary is {1}", prize, salary);
                }
                else
                    Console.WriteLine("Please enter valid number of years");
            Console.ReadKey();

        }
    }
}
