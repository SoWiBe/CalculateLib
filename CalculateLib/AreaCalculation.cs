using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public class AreaCalculation : Shape
    {
        private static AreaCalculation? areaCalculation;

        public static AreaCalculation GetInstance()
        {
            if(areaCalculation == null)
            {
                areaCalculation = new AreaCalculation();
            }
            
            return areaCalculation;
        }

        public override double GetArea(double radius) => Math.PI * Math.Pow(radius, 2);

        public override double GetArea(double _firstSide, double _secondSide, double _thirdSide)
        {
            double p = (_firstSide + _secondSide + _thirdSide) / 2;

            if (Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2) ||
                Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_secondSide, 2) ||
                Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2))
            {
                Console.WriteLine("Triangle with these sides {0},{1},{2} is right triangle!", _firstSide, _secondSide, _thirdSide);
            }

            return Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        }
    }
}
