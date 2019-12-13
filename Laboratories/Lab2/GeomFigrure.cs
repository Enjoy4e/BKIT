using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class GeomFigure: IComparable
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
        public abstract override string ToString();
        public interface IMatrixCheckEmpty<T>
        {
            T getEmptyElement();
            bool checkEmptyElement(T element);
        }
        public int CompareTo(object obj)
        {
            GeomFigure p = (GeomFigure)obj;

            if (this.Square() < p.Square()) return -1;
            else if (this.Square() == p.Square()) return 0;
            else return 1;
        }
    }

}
