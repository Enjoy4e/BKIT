using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class Square : Rectangle, IPrint, IComparable
    {
        public Square(double a)
            : base(a, a)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return "Квадрат площадью " + this.Square();
        }
    }
}
