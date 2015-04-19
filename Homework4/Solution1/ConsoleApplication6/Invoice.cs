using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Invoice
    {
        private static int account { get; set; }
        private static string customer { get; set; }
        static Invoice(/*int consacc, string conscost*/)
        {
            /*account = consacc;
            customer = conscost;*/
        }
        public string article { get; set; }
        public int quantity { get; set; }
        public float pricePerUnit { get; set; }
        public float NDS { get; set; }
        public float CountNDS()
        {
            return ((pricePerUnit * NDS) / 100);
        }
        public float PriceWithOutNDS()
        {
            return pricePerUnit - CountNDS();
        }
        public float VAluewithNDS()
        {
            return (((pricePerUnit * NDS) / 100) + pricePerUnit);
        }
    }
}
