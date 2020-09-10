using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColoredShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredShapes.Tests
{
    [TestClass()]

    public class TriangleTests
    {

        private Triangle tri;

        [TestInitialize()]
        public void BeforeEachTest()
        {
            tri = new Triangle("Red",1);
        }

        [TestCleanup()]
        public void AfterEachTest()
        {
            // Undo things after the test.
        }

        [TestMethod()]
        public void GetAreaTest_Area1()
        {
            float expected = 0.43301270189221932338186158537647f;

            Assert.AreEqual(expected, tri.GetArea());
        }

        [TestMethod()]
        public void GetAreaTest_Area2()
        {
            tri.Size = 2.0f;
            float expected = 1.732050807568877293527446341505f;

            Assert.AreEqual(expected, tri.GetArea());
        }
    }
}