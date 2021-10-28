using System;

namespace EssentialLesson3Task2
{
    class Program
    {

        
        static Pupil excellentPupil = new ExcelentPupil();
        static Pupil goodPupil = new GoodPupil();
        static Pupil badPupil = new BadPupil();

        static void Main(string[] args)
        {
            ClassRoom cr1 = new ClassRoom(goodPupil, excellentPupil, goodPupil, badPupil);
            Console.WriteLine();
            ClassRoom cr2 = new ClassRoom(badPupil, excellentPupil, goodPupil);
            Console.WriteLine();
            ClassRoom cr3 = new ClassRoom(badPupil, excellentPupil);
        }
    }
}
