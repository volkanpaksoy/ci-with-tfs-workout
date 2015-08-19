using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperDuperCoreLibrary.UnitTests.MSTest
{
    [TestClass]
    public class ComplexMathClassTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DenominatorZero_ShouldThrowDivideByZeroException()
        {
            var cmc = new ComplexMathClass();
            cmc.Divide(5, 0);
        }
    }
}
