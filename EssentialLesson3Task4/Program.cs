using System;

namespace EssentialLesson3Task4
{

    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте класс DocumentWorker.
    //В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
    //В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
    //Создайте производный класс ProDocumentWorker.
    //    Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
    //Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. Переопределите соответствующий метод.При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
    //В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.

    class Program
    {

        static int key;
        static string str;
        static bool flag = true;
        static bool isNum;
        static DocumentWorker dw;

        static void Main(string[] args)
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (flag)
            {
                Console.Clear();

                Console.WriteLine("Enter registration key.");

                str = Console.ReadLine();

                isNum = int.TryParse(str, out key);

                if (isNum)
                {
                    if (key == 555)
                    {
                        Console.WriteLine("You have PRO version");
                        dw = new ProDocumentWorker();
                        dw.OpenDocument();
                        dw.EditDocument();
                        dw.SaveDocument();
                    }
                    else if (key == 777)
                    {
                        Console.WriteLine("You have Expert version");
                        dw = new ProDocumentWorker();
                        dw.OpenDocument();
                        dw.EditDocument();
                        dw.SaveDocument();
                    }
                    else
                    {
                        Console.WriteLine("This code is not acceptable, you can use only base version.");
                        dw = new DocumentWorker();
                        dw.OpenDocument();
                        dw.EditDocument();
                        dw.SaveDocument();
                    }
                }
                else
                {
                    Console.WriteLine("It is not a number, try again.");
                }
                Console.ReadLine();
            }
        }
    }
}
