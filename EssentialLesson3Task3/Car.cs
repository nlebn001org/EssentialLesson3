using System;

namespace EssentialLesson3Task3
{
    class Car : Vehicle
    {
        public Car(double price, double speed, int year) : base(price, speed, year)
        {

        }

        public override void GetAllIfo()
        {
            Console.WriteLine("Car:");
            base.GetAllIfo();
            Console.WriteLine();
        }
    }
}
