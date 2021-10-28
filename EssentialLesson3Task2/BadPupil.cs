using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson3Task2
{
    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Bad pupil - Bad reading");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil - The best relaxing");
        }

        public override void Study()
        {
            Console.WriteLine("Bad pupil - Bad studying");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil - Bad writing");
        }
    }
}
