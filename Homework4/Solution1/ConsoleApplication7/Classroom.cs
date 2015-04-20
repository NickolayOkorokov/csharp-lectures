using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Classroom
    {
        public Classroom(Pupil pupil1)
        {
            pupil1.Read(); pupil1.Study(); pupil1.Write(); pupil1.Relax();
        }
        public Classroom(Pupil pupil1, Pupil pupil2)
        {
            pupil1.Read(); pupil1.Study(); pupil1.Write(); pupil1.Relax();
            pupil2.Read(); pupil2.Study(); pupil2.Write(); pupil2.Relax();
        }
        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil1.Read(); pupil1.Study(); pupil1.Write(); pupil1.Relax();
            pupil2.Read(); pupil2.Study(); pupil2.Write(); pupil2.Relax();
            pupil3.Read(); pupil3.Study(); pupil3.Write(); pupil3.Relax();
        }
        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil1.Read(); pupil1.Study(); pupil1.Write(); pupil1.Relax();
            pupil2.Read(); pupil2.Study(); pupil2.Write(); pupil2.Relax();
            pupil3.Read(); pupil3.Study(); pupil3.Write(); pupil3.Relax();
            pupil4.Read(); pupil4.Study(); pupil4.Write(); pupil4.Relax();
        }
        //It must be some method to not copy this pupil.method() but i dont get it still;
    }
}
