using Xunit;
using FigureLibrary;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AreaCalcualte_ShouldCalculateAreaOfaCircle()
        {
            double expected = 78.53981633974483;

            double actual = Calculate.FigureCalc(5);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 3.141592653589793)]
        public void AreaCalculate_ShouldCalculateAreaOfaCircleTheory(int x, double expected)
        {
            double actual = Calculate.FigureCalc(x);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaCalcualte_ShouldCalculateAreaOfaTriangle()
        {
            double expected = 3.897114317029974;

            double actual = Calculate.FigureCalc(3, 3, 3);

            Assert.Equal(expected, actual);
        }

    }
}