using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson3Task1
{
    class PrinterBlue : Printer
    {
        //public override void Print(string value)
        //{
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Console.WriteLine("PB"+value);
        //}
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }
}
