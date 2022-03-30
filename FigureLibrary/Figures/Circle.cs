using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        public int Radius;
        public Circle (int radius)
        {
            Radius = radius;
        }
        public override double AreaCalcualte()  //площадь круга
        {
           return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
