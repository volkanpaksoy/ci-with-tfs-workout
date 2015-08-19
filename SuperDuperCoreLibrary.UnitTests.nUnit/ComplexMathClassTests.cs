using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDuperCoreLibrary.UnitTests.nUnit
{
    public class ComplexMathClassTests
    {
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(0, 5, ExpectedResult = 5)]
        [TestCase(-1, 1, ExpectedResult = 0)]
        public int Add_TwoIntegers_ShouldCalculateCorrectly(int x, int y)
        {
            var cmc = new ComplexMathClass();
            return cmc.Add(x, y);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DenominatorZero_ShouldThrowDivideByZeroException()
        {
            var cmc = new ComplexMathClass();
            double result = cmc.Divide(5, 0);
        }
    }
}
