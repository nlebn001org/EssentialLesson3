using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson3Task2
{
    class Pupil
    {

        public virtual void Study()
        {
        }

        public virtual void Read()
        {
        }

        public virtual void Write()
        {
        }

        public virtual void Relax()
        {
        }


        public void StudentInfo()
        {
            Study();
            Read();
            Write();
            Relax();
        }

    }
}
