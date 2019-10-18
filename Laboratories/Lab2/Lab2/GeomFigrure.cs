using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
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
}
