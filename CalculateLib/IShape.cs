using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    interface IShape
    {
        double GetArea(int a, int b, int c);
        double GetArea(int radius);
    }
}
