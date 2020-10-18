using System;
using Xunit;


namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
            // Arange - подготовка данных
            const int Five = 5;
            const int Three = 3;

            MathCalculator calculator = new MathCalculator();

            var result = calculator.Sum(5,3);

            Assert.Equal(8,result);
        }
    }
}
