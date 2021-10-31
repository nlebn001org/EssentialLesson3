using System;

namespace EssentialLesson3Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Excelent pupil - Excelent reading");
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent pupil - Bad relaxing");
        }

        public override void Study()
        {
            Console.WriteLine("Excelent pupil - Excellent studying");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent pupil - Excellent writing");
        }

    }
}
