using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static double Continue(string prov)
        {
            double a = 0;
            do
                Console.Write(prov);
            while (!double.TryParse(Console.ReadLine(), out a));
            return a;
        }
        static bool AskContinue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nПродолжить? (press any button/n): ");
            string s = Console.ReadLine();
            return !(s == "n");
            Console.ResetColor();
        }
        static int Menu()
        {
            int vibor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выберите фигуру площадь которой,вы хотите найти:");
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Квадрат");
            Console.WriteLine("3. Круг");
            Console.WriteLine("4. Выход");
            Console.Write("\n---> ");
            string g = Console.ReadLine();
            Console.ResetColor();
            int.TryParse(g, out vibor);
            return vibor;

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Лабораторная работа 2 - 'Нахождение площадей фигур'");
            Console.Title = "Выполнил:Ли М.В. Группа:ИУ5-34Б";
            Console.ResetColor();
            Rectangle rect;
            Circle circ;
            Square squar;
            double a1, b1;
            do
            {
                switch (Menu())
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        a1 = Continue("Введите значение длины прямоугольника: ");
                        b1 = Continue("Введите значение ширины прямоугольника: ");
                        rect = new Rectangle(a1, b1);
                        rect.Print();
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        a1 = Continue("Введите значение стороны квадрата:");
                        squar = new Square(a1);
                        squar.Print();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        a1 = Continue("Введите значение радиуса окружности: ");
                        circ = new Circle(a1);
                        circ.Print();
                        Console.ResetColor();
                        break;
                    case 4:
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            } while (AskContinue());
        }
    }
}