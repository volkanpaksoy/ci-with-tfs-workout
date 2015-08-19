using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuperDuperCoreLibrary.UnitTests.xUnit
{
    public class ComplexMathClassTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 5, 5)]
        [InlineData(-1, 1, 0)]
        public void Add_TwoIntegers_ShouldCalculateCorrectly(int x, int y, int expectedResult)
        {
            var cmc = new ComplexMathClass();
            int actualResult = cmc.Add(x, y);
            Assert.Equal<int>(expectedResult, actualResult);
        }

        [Fact]
        public void Divide_DenominatorZero_ShouldThrowDivideByZeroException()
        {
            var cmc = new ComplexMathClass();
            //cmc.Divide(5, 0);
            Assert.Throws<DivideByZeroException>(() => cmc.Divide(5, 0));
        }
    }
}
