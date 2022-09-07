using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HighLow.Tests
{
    [TestClass]
    public class HighLowTests
    {
        [TestMethod]
        public void TestSingleValue()
        {
            HighLowItem item = new HighLowItem(5, 5);

            Assert.IsTrue(item.Value == 5);
        }

        [TestMethod]
        public void TestMinValue()
        {
            HighLowItem item = new HighLowItem(50, 100);

            Assert.IsTrue(item.Value >= 50);
        }

        [TestMethod]
        public void TestMaxValue()
        {
            HighLowItem item = new HighLowItem(50, 100);

            Assert.IsTrue(item.Value <= 100);
        }

        [TestMethod]
        public void TestMatchValue()
        {
            HighLowItem item = new HighLowItem(50, 100);

            Assert.IsTrue(item.CompareToValue(item.Value) == "Winner!");
        }

        [TestMethod]
        public void TestLoValue()
        {
            HighLowItem item = new HighLowItem(50, 100);

            Assert.IsTrue(item.CompareToValue(item.Value - 1) == "LO");
        }

        [TestMethod]
        public void TestHiValue()
        {
            HighLowItem item = new HighLowItem(50, 100);

            Assert.IsTrue(item.CompareToValue(item.Value + 1) == "HI");
        }
    }
}
