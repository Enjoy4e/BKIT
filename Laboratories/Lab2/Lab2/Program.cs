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
            Console.Write("\nПродолжить? (y/n): ");
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
            Console.WriteLine("Выполнил:Ли М.В");
            Console.WriteLine("Группа:ИУ5-34Б");
            Console.ResetColor();
            IPrint obj;
            double a1, b1;
            do
            {
                switch (Menu())
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        a1 = Continue("Введите значение длины прямоугольника: \n");
                        b1 = Continue("Введите значение ширины прямоугольника: \n");
                        obj = new Rectangle(a1, b1);
                        obj.Print();
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        a1 = Continue("Введите значение стороны квадрата: \n");
                        obj = new Square(a1);
                        obj.Print();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        a1 = Continue("Введите значение радиуса окружности: \n");
                        obj = new Circle(a1);
                        obj.Print();
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
            interface IPrint
        {
            void Print();
        }
     abstract class GeomFigure
    {
        string type;
        public string Type
        {
            protected set
            {
                this.type = value;
            }
            get
            {
                return this.type;
            }
        }

        public abstract double Square();
        public override string ToString()
        {
            return this.type + " имеет площадь = " + this.Square();
        }
    }
    class Rectangle : GeomFigure, IPrint
    {
        double width;
        double lenght;
        public Rectangle(double w, double h)
        {
            this.lenght = h;
            this.width = w;
            this.Type = "Прямоугольник";
        }
        public override double Square()
        {
            return this.width * this.lenght;
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.ToString());
            Console.ResetColor();
        }
    }
    class Square : Rectangle
    {
        public Square(double a)
            : base(a, a)
        {
            this.Type = "Квадрат";
        }
    }
    class Circle : GeomFigure, IPrint
    {
        double radius;
        public Circle(double rad)
        {
            this.radius = rad;
            this.Type = "Круг";
        }
        public override double Square()
        {
            return System.Math.PI * this.radius * this.radius;
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.ToString());
            Console.ResetColor();
        }
    }
}