using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMethods2018;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Tests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestValidInput()
        {
            Assert.AreEqual(16, Program.CalculatePower(2, 4));
        }


        [TestMethod]
        public void TestCase2()
        {
            Assert.AreEqual(16, Program.CalculatePower(2, 4));
        }
    }
}