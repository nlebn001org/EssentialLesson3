using System;

namespace EssentialLesson3Task3
{
    class Plane : Vehicle
    {
        public int Passengers { get; }
        public double Height { get; }

        public Plane(double price, double speed, int year, int passengers, double height) : base(price, speed, year)
        {
            Passengers = passengers;
            Height = height;
        }

        public override void GetAllIfo()
        {
            Console.WriteLine("Plane:");
            base.GetAllIfo();
            Console.WriteLine($"Passengers are: {Passengers}\nHeight is: {Height}\n");
        }
    }
}
