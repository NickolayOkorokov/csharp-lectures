using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class ExcelentPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Exelent pupil: studying exelently");
        }

        public new void Read()
        {
            Console.WriteLine("Exelent pupil: reading exelently");
        }
        public new void Write()
        {
            Console.WriteLine("Exelent pupil: writing exelently");
        }
        public new void Relax()
        {
            Console.WriteLine("Exelent pupil: relaxing culturally");
        }
    }



    class GoodPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Good pupil: studying mediocre");
        }

        public new void Read()
        {
            Console.WriteLine("Good pupil: reading mediocre");
        }
        public new void Write()
        {
            Console.WriteLine("Good pupil: writing mediocre");
        }
        public new void Relax()
        {
            Console.WriteLine("Good pupil: relaxing ");
        }
    }

    class BadPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Bad pupil: studying bad");
        }

        public new void Read()
        {
            Console.WriteLine("Bad pupil: reading bad");
        }
        public new void Write()
        {
            Console.WriteLine("Bad pupil: writing bad");
        }
        public new void Relax()
        {
            Console.WriteLine("Bad pupil: relaxing rowdy with drink");
        }
    }
}

