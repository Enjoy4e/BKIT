using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class Rectangle : GeomFigure, IPrint, IComparable
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
        public override string ToString()
        {
            return "Прямоугольник площадью " + this.Square();
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.ToString());
            Console.ResetColor();
        }
    }
}
