

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathsLibrary;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            float a = 1.0f;
            float b = 2.0f;
           Console.WriteLine(Maths.Add(a, b));
            
        }
    }
}
