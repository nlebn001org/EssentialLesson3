using System;

namespace EssentialLesson3Task1
{
    class PrinterRed : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);

        }
    }
}
