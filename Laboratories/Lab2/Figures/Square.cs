﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Rectangle
    {
        public Square(double a)
            : base(a, a)
        {
            this.Type = "Квадрат";
        }
    }
}