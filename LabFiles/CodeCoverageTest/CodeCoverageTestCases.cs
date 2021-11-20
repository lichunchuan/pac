using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
namespace CodeCoverageTest
{
    [TestClass]
    public class CodeCoverageTestCases
    {
        [TestMethod]
        public void TestDivide()
        {
            CodeCoverage.Math m = new CodeCoverage.Math();
            int result = m.Divide(4, 2);
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void TestDividebyZero()
        {
            CodeCoverage.Math m = new CodeCoverage.Math();

            try
            {
                int result = m.Divide(4, 0);
            }catch(Exception e)
            {
                Assert.AreEqual(e.Message, "Denominator can not be zero");
            }
        }
    }
}
