using FigureLibrary.Figures;

namespace FigureLibrary
{
    public class Calculate  //определение типа фигуры по перегрузке метода FigureCalc
    {
        public static double FigureCalc(int Radius)     //площадь круга
        {
            Circle c = new Circle(Radius);
            return c.AreaCalcualte();
        }

        public static double FigureCalc(int Side1, int Side2, int Side3)    //площадь треугольника
        {
            Triangle t = new Triangle(Side1, Side2, Side3);
            return t.AreaCalcualte();
        }

        public static bool IfRightTriangle(int Side1, int Side2, int Side3)     //проверка на прямоугольник
        {
            Triangle t = new Triangle(Side1, Side2, Side3);
            return t.IfRightTriangle();
        }
    }
}