using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Exelent pupil: studying exelently");
        }

        public override void Read()
        {
            Console.WriteLine("Exelent pupil: reading exelently");
        }
        public override void Write()
        {
            Console.WriteLine("Exelent pupil: writing exelently");
        }
        public override void Relax()
        {
            Console.WriteLine("Exelent pupil: relaxing culturally");
        }
    }



    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil: studying mediocre");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil: reading mediocre");
        }
        public override void Write()
        {
            Console.WriteLine("Good pupil: writing mediocre");
        }
        public override void Relax()
        {
            Console.WriteLine("Good pupil: relaxing ");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil: studying bad");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil: reading bad");
        }
        public override void Write()
        {
            Console.WriteLine("Bad pupil: writing bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad pupil: relaxing rowdy with drink");
        }
    }
}

