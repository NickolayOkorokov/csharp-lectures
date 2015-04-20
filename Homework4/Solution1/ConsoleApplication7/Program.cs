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
            Pupil exelent = new ExcelentPupil();
            Pupil good = new GoodPupil();
            Pupil bad = new BadPupil();

            Classroom class1 = new Classroom(bad, good);
            Console.ReadKey();
        }
    }
}
