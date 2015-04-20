using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    abstract class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine();
        }
        public virtual void Read()
        {
            Console.WriteLine();
        }
        public virtual void Write()
        {
            Console.WriteLine();
        }
        public virtual void Relax()
        {
            Console.WriteLine();
        }
        //Probably i Shoul not use public everywhere
    }
}
