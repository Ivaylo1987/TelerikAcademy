using System;
using MatrixWalk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixWalkTests
{
    [TestClass]
    public class DirectionTests
    {
        [TestMethod]
        public void OneOneDirection()
        {
            var direction = new Direction(1,1);
            var expectedValue = "1 1";
            var actualValue = direction.ToString();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void HundredOneDirection()
        {
            var direction = new Direction(100, 1);
            var expectedValue = "100 1";
            var actualValue = direction.ToString();
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
