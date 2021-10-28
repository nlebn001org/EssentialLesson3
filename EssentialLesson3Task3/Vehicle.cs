using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson3Task3
{
    class Vehicle
    {
        public double Price { get; }
        public double Speed { get; }
        public int Year { get; }

        public Vehicle(double price, double speed, int year)
        {
            Price = price;
            Speed = speed;
            Year = year;
        }

        public virtual void GetAllIfo()
        {
            Console.WriteLine($"Price is: {Price}\nSpeed is: {Speed}\nYear is: {Year}");
        }


    }
}
