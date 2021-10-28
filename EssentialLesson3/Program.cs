using EssentialLesson3Task1;
using System;

namespace EssentialLesson3
{
    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте класс Printer.
    //В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
    //Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
    //Обязательно используйте приведение типов.


    class Program
    {

        static string test = "test";
        static Printer printer;
        static void Main(string[] args)
        {

            resetConsole();
            printer = new Printer();
            printer.Print(test);
            printer = new PrinterRed();
            printer.Print(test);
            printer = new PrinterBlue();
            printer.Print(test);
            resetConsole();

        }

        public static void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
