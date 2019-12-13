using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class Circle : GeomFigure, IPrint, IComparable
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
        public override string ToString()
        {
            return "Круг площадью " + this.Square();
        }
    }
}
