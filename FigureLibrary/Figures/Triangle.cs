using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    internal class Triangle : Figure
    {
        public double Side1;

        public double Side2;

        public double Side3;

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double AreaCalcualte()  //площадь треугольника
        {
            if (Side3 <= 0 || Side2 <= 0 || Side1 <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше 0");
            }
            double halfPerim = (Side1 + Side2 + Side3) / 2;
            double result = Math.Sqrt(halfPerim * (halfPerim - Side1) * (halfPerim - Side2) * (halfPerim - Side3));
            return result;
        }

        public bool IfRightTriangle()  //Является ли треугольник прямоугольным
        {
            if (Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2) ||
                Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2) ||
                Math.Pow(Side3, 2) == Math.Pow(Side2, 2) + Math.Pow(Side1, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
