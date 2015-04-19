using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil exelent = new ExcelentPupil();
            GoodPupil good = new GoodPupil();
            BadPupil badpupil1 = new BadPupil();

            Classroom class1 = new Classroom(badpupil1);
            Console.ReadKey();
        }
    }
}
