using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public abstract class Shape
    {
        public abstract double GetArea(double radius);
        public abstract double GetArea(double a, double b, double c);
    }
}
