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
            Console.WriteLine("Insert exchange rate for usd");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert exchange rate for euro");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert exchange rate for rub");
            double rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert amount of money you want to exchange");
            double uah = Convert.ToDouble(Console.ReadLine());
            Converter uahConvert = new Converter(usd, euro, rub, uah);  
            Console.WriteLine("In which currency you want to exchange? /USD,EURO,RUB/");
            string money = Console.ReadLine();
            switch (money)
            {
                case "USD":
                    Console.WriteLine("You will get {0} dollars", moneyConvMethod(uahConvert.uahConv, uahConvert.usdConv)); 
                    break;
                case "EURO":
                    Console.WriteLine("You will get {0} euro", moneyConvMethod(uahConvert.uahConv, uahConvert.euroConv));
                    break;
                case "RUB":
                    Console.WriteLine("You will get {0} rub", moneyConvMethod(uahConvert.uahConv, uahConvert.rubConv));
                    break;
                default:
                    Console.WriteLine("Please enter valid currency");
                    break;
            }
            Console.WriteLine("Do you want to exchange back? /Y, N/");
            string answer = Console.ReadLine();
            if (answer == "Y")
                Console.WriteLine("Amount of money is {0} uah", uahConvert.uahConv);
            else
                Console.WriteLine("Bye");

            Console.ReadLine();
        }

        static double moneyConvMethod(double money1, double money2)
        {
            return money1 / money2;
        }
    }
}
