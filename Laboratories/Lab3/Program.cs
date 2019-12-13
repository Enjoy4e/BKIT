using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;
namespace Lab3
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nПродолжить? (press any button/n): ");
            string s = Console.ReadLine();
            Console.ResetColor();
            return !(s == "n");
        }
        static void Main(string[] args)
        {
            do
            {
                double[,] dimensions = new double[3, 2];
                string str; // временная сточная переменная для консольного ввода
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Лабораторная работа 3 - 'Cортировка геометрических фигур'");
                Console.Title = "Выполнил:Ли М.В. Группа:ИУ5-34Б";
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите длину Прямоугольника:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = Console.ReadLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите ширину Прямоугольника:");
                double.TryParse(str, out dimensions[0, 0]);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = Console.ReadLine();
                Console.ResetColor();
                double.TryParse(str, out dimensions[0, 1]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите длину стороны Квадрата:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = Console.ReadLine();
                Console.ResetColor();
                double.TryParse(str, out dimensions[1, 0]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите радиус Круга:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                str = Console.ReadLine();
                Console.ResetColor();
                double.TryParse(str, out dimensions[2, 0]);
                Circle circle = new Circle(dimensions[2, 0]);
                circle.Print();
                Rectangle rectangle = new Rectangle(dimensions[0, 0], dimensions[0, 1]);
                rectangle.Print();
                Square square = new Square(dimensions[1, 0]);
                square.Print();

                Console.WriteLine("\n\tArrayList");
                ArrayList Arr = new ArrayList();    
                Arr.Add(rectangle);
                Arr.Add(square);
                Arr.Add(circle);
                Console.WriteLine("\nИсходный ArrayList:", "DarkMagenta");
                foreach (var x in Arr) Console.WriteLine(x);
                Arr.Sort(); 
                Console.WriteLine("\n\nОтсоритрованные ArrayList:", "DarkMagenta");
                foreach (var x in Arr) Console.WriteLine(x);
                Console.WriteLine("\n\tList");
                List<GeomFigure> List = new List<GeomFigure>(); 
                GeomFigure buf;
                List.Add(rectangle);
                List.Add(square);
                List.Add(circle);
                for (int i = 0; i < List.Count; i++) 
                    for (int j = 0; j < (List.Count - (i + 1)); j++)
                    {
                        if (List[j].CompareTo(List[j + 1]) == 1)
                        {
                            buf = List[j];
                            List[j] = List[j + 1];
                            List[j + 1] = buf;
                        }
                    }
                Console.WriteLine("\nИсходный List:", "DarkMagenta");
                foreach (var x in List) Console.WriteLine(x);
                List.Sort(); 
                Console.WriteLine("\nОтсортированный List:", "DarkMagenta");
                foreach (var x in List) Console.WriteLine(x);
                Console.WriteLine("\n\tMatrix");
                Matrix<GeomFigure> matr = new Matrix<GeomFigure>(3, 3, 3); 
                matr[1, 1, 0] = rectangle;
                matr[1, 1, 2] = square;
                matr[2, 2, 1] = circle;
                Console.WriteLine(matr.ToString());

                Console.WriteLine("\n\tSimpleStack");
                SimpleStack<GeomFigure> stack = new SimpleStack<GeomFigure>();
                stack.Push(rectangle);
                stack.Push(square);
                stack.Push(circle);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            } while (AskContinue());
        }
    }
}



