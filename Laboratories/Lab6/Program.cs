
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        delegate int MultiplyOrDivide(int p1, int p2);
        static int Multiply(int p1, int p2) { return p1 * p2; }
        static int Devide(int p1, int p2) { return p1 / p2; }
        static void MultiplyOrDivideMethodFunc(string str, int i1, int i2, MultiplyOrDivide MultiplyOrDivideParam)
        {
            int result = MultiplyOrDivideParam(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        static void MultiplyOrDivideMethod(string str, int i1, int i2, Func<int, int, int> MultiplyOrDivideParam)
        {
            int result = MultiplyOrDivideParam(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 6 - 'Работа с делегатами'");
            Console.Title = "Выполнил:Ли М.В. Группа:ИУ5-34Б";
            string str1;
            string str2;
            Console.Write("Введите первый аргумент: ");
            str1 = Console.ReadLine();
            Console.Write("Введите второй аргумент: ");
            str2 = Console.ReadLine();
            while (str2 == "0")
            {
                Console.Write("Введите второй аргумент повторно (неравный нулю): ");
                str2 = Console.ReadLine();
            }
            int i1 = int.Parse(str1);
            int i2 = int.Parse(str2);
            Console.WriteLine("\nПример группового делегата");
            MultiplyOrDivideMethod("Умножаем: ", i1, i2, Multiply);
             MultiplyOrDivideMethod("Делим: ", i1, i2, Devide);

             MultiplyOrDivide p1 = new MultiplyOrDivide(Multiply);
             MultiplyOrDivide p2 = new MultiplyOrDivide(Devide);

            MultiplyOrDivideMethod("\nMultiply: ", i1, i2, Multiply);
            MultiplyOrDivideMethod("Devide:", i1, i2, Devide);

            MultiplyOrDivideMethod("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);

            Console.WriteLine("\n\nИспользование обощенного делегата Func< >");
            MultiplyOrDivideMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Multiply);
            MultiplyOrDivideMethodFunc("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);
            Console.ReadKey();
        }
    }
}