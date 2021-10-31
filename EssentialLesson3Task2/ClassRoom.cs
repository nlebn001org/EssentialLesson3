namespace EssentialLesson3Task2
{
    class ClassRoom
    {
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil1.StudentInfo();
            pupil2.StudentInfo();
            pupil3.StudentInfo();
            pupil4.StudentInfo();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil1.StudentInfo();
            pupil2.StudentInfo();
            pupil3.StudentInfo();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil1.StudentInfo();
            pupil2.StudentInfo();
        }

    }
}
