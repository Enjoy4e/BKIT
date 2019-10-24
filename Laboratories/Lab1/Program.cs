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

        }
    }
}
