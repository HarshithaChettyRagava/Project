using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Checking_withPositiveNumbers()
        {
            var expected = 12.0;
            var a = 3;
            var b = 4;
            var actual = Calc_FoodItem(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(22.4, 4, 5.6)]
        [InlineData(10, -2, -5)]
        [InlineData(0, 0, 0)]
        public void CalcFoodItem_WorksWithManyInputs(double exp, double n1, double n2)
        {
            Assert.Equal(exp, Calc_FoodItem(n1, n2));
        }



        double Calc_FoodItem(double cost, double taxPer)
        {
            return cost * taxPer;
        }
    }
}
