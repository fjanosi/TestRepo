using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        public void Add_Success()
        {
            TestContext.WriteLine("Test start");
            
            int a = 5;
            int b = 10;
            int result = Calculator.Add(a, b);

            Assert.AreEqual(a + b, result);

            TestContext.WriteLine("Test run successfully.");

        }
    }
}
