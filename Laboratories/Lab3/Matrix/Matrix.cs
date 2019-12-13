using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;
namespace Lab3
{
    public class Matrix<T>
    {
        Dictionary<string, T> matrixCont = new Dictionary<string, T>(); 

        int X;
        int Y;
        int Z;

        void chBounds(int x, int y, int z) 
        {
            if (x < 0 || x >= this.X)
            {
                throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            }
            if (y < 0 || y >= this.Y)
            {
                throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
            }
            if (z < 0 || z >= this.Z)
            {
                throw new ArgumentOutOfRangeException("z", "z=" + z + " выходит за границы");
            }
        }

        string ContKey(int x, int y, int z) 
        {
            return x.ToString() + " ; " + y.ToString() + " ; " + z.ToString();
        }

        public Matrix(int x, int y, int z) 
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }
        public T this[int x, int y, int z] 
        {
            set 
            {
                chBounds(x, y, z);
                string key = ContKey(x, y, z);
                this.matrixCont.Add(key, value);
            }
            get 
            {
                chBounds(x, y, z);
                string key = ContKey(x, y, z);
                if (this.matrixCont.ContainsKey(key))
                {
                    return this.matrixCont[key];
                }
                else
                {
                    return default(T);
                }
            }
        }

        public override string ToString() 
        {
            StringBuilder b = new StringBuilder();

            for (int k = 0; k < this.Z; k++)
            {
                b.Append("Z" + k.ToString() + "  [");
                for (int j = 0; j < this.Y; j++)
                {
                    if (j > 0)
                    {
                        b.Append("\t");
                    }
                    for (int i = 0; i < this.X; i++)
                    {

                        if (this[i, j, k] != null)
                        {
                            b.Append(this[i, j, k].ToString());
                        }
                        else
                        {
                            b.Append(" - ");
                        }

                    }
                }
                b.Append("]\n");
            }

            return b.ToString();
        }
    }
}