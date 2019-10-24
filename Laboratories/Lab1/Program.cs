using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
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
            Console.Write("\nПродолжить? (y/n): ");
            string s = Console.ReadLine();
            return !(s == "n");
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Лабораторная работа 1 - 'Решение биквадратных уравненоий'");
            Console.Title = "Выполнил:Ли М.В. Группа:ИУ5-34Б";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите значения коэффициентов A,B,C");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите значение коэф.А: ");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение коэф.В: ");
                double B = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение коэф.С: ");
                double C = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Данные введены верно? (y/n):");
                string proverka = Console.ReadLine();
                Console.ResetColor();
                if (proverka == "n")
                {
                    goto Finish;
                }
                if (A == 0 && C == 0 && B == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Введены нулевые коэффициенты");
                    Console.ResetColor();
                    goto Finish;
                }
                else if ((A == 0 && C == 0) || (B == 0 && C == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("x = 0");
                    Console.ResetColor();
                    goto kostil;
                }
                else if (A == 0)
                {
                    if (C < 0)
                    {
                        double root = System.Math.Pow((-C / B), 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                        goto Solution;
                    }
                    else if (C == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    if (C > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Корни отсутсвуют");
                        Console.ResetColor();
                        goto Finish;
                    }

                }
                else if (B == 0)
                {
                    if (C < 0)
                    {
                        double root = System.Math.Pow(System.Math.Pow((-C / A), 0.5), 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                        goto Solution;
                    }
                    else if (C == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    if (C > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Корни отсутствуют");
                        Console.ResetColor();
                        goto Finish;
                    }

                }
                double Discr = System.Math.Pow(B, 2) - (4 * A * C);
                if (Discr > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Дискриминант:" + Discr + "\n");
                    Console.ResetColor();
                    double t1 = (-B + Math.Pow(Discr, 0.5)) / (2 * A);
                    double t2 = (-B - Math.Pow(Discr, 0.5)) / (2 * A);

                    if (t1 < 0 && t2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корни отсутсвуют");
                        Console.ResetColor();
                    }
                    else if (t1 < 0 && t2 > 0)
                    {
                        double root = Math.Pow(t2, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    }
                    else if (t2 < 0 && t1 > 0)
                    {
                        double root = Math.Pow(t1, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    }
                    else
                    {
                        double root1 = Math.Pow(t1, 0.5);
                        double root2 = Math.Pow(t2, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:    x1 = {0},\tx2 = {1};", root1, (-1 * root1));
                        Console.WriteLine("x3 = {0},\tx4 = {1};", root2, (-1 * root2));
                        Console.ResetColor();
                    }
                }
                else if (Discr == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Дискриминант:" + Discr + "\n");
                    Console.ResetColor();
                    double t = -B / (2 * A);
                    if (t < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет!");
                        Console.ResetColor();
                    }
                    else
                    {
                        double root = Math.Pow(t, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    }
                }
                else if (Discr < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Дискриминант:" + Discr + "\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительные корни отсутсвуют");
                    Console.ResetColor();
                }
            Finish:
            Solution:
            kostil:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kорней нет");
                Console.ResetColor();
                Console.WriteLine(" ");
            } while (AskContinue());
        }
    }
}
