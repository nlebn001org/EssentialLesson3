using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson3Task3
{
    class Ship : Vehicle
    {

        public string Port { get; }
        public int Passengers { get; }


        public Ship(double price, double speed, int year, string port, int passengers) : base(price, speed, year)
        {

            Port = port;
            Passengers = passengers;

        }

        public override void GetAllIfo()
        {
            Console.WriteLine("Ship:");
            base.GetAllIfo();
            Console.WriteLine($"Port is: {Port}\nPassengers are: {Passengers}\n");
        }
    }
}
