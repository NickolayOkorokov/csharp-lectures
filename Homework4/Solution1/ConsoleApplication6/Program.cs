using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int acc = Int32.Parse(Console.ReadLine());
             string cust = Console.ReadLine();*/
            Invoice newBuy = new Invoice(/*acc, cust*/);
            //Do not really understand about one time initializing fields
            Console.Write("Insert amount of goods:");
            newBuy.quantity = Int32.Parse(Console.ReadLine());
            Console.Write("Insert VAT:");
            String ndsString = Console.ReadLine();
            newBuy.NDS = float.Parse(ndsString);
            Console.Write("Insert price of goods:");
            newBuy.pricePerUnit = float.Parse(Console.ReadLine());

            Console.WriteLine("VAT amount - {0}", newBuy.CountNDS());
            Console.WriteLine("Price of good without VAT - {0}", newBuy.PriceWithOutNDS());
            Console.WriteLine("Price with VAT - {0}", newBuy.VAluewithNDS());
            Console.ReadKey();
        }
    }
}
