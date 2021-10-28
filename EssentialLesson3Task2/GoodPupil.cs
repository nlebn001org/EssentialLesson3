using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson3Task2
{
    class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Good pupil - Good reading");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil - Normal relaxing");
        }

        public override void Study()
        {
            Console.WriteLine("Good pupil - Good studying");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil - Good writing");
        }
    }
}
