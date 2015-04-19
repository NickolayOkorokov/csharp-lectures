using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Converter
    {
        private double usd, euro, rub, uah;
        public Converter(double usd, double euro, double rub, double uah)
        {
            this.euro = euro;
            this.rub = rub;
            this.usd = usd;
            this.uah = uah;
        }
        public double usdConv { get { return usd; } }
        public double euroConv { get { return euro; } }
        public double rubConv { get { return rub; } }
        public double uahConv { get { return uah; } } 
    }

}
