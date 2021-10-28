using System;

namespace EssentialLesson3Task3
{

    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Vehicle.
    //В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(1300, 200, 1997);
            Vehicle plane = new Plane(2000000, 900, 2001, 270, 8000);
            Vehicle ship = new Ship(60000000, 60, 2001, "TestPort", 500);

            car.GetAllIfo();
            plane.GetAllIfo();
            ship.GetAllIfo();
        }
    }
}
