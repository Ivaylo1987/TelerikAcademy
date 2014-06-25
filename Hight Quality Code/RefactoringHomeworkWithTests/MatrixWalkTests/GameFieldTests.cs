using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixWalk;

namespace MatrixWalkTests
{
    [TestClass]
    public class GameFieldTests
    {
        [TestMethod]
        public void DirectionsCountTest()
        {
            var field = new GameField(3, GenerateDirectionsList());

            var expectedValue = 8;
            var actualValue = field.Directions.Count;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FieldSize()
        {
            var field = new GameField(5, GenerateDirectionsList());

            var expectedValue = 5;
            var actualValue = field.Size;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FieldSizeLessThanOne()
        {
            var field = new GameField(0, GenerateDirectionsList());
        }

        [TestMethod]
        public void DirectionIndexTest()
        {
            var field = new GameField(5, GenerateDirectionsList());
            field.CurrentDirectionIndex = 5;

            var expectedValue = 5;
            var actualValue = field.CurrentDirectionIndex;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void DirectionIndexOverflow()
        {
            var field = new GameField(5, GenerateDirectionsList());
            field.CurrentDirectionIndex = 50;

            var expectedValue = 0;
            var actualValue = field.CurrentDirectionIndex;

            Assert.AreEqual(expectedValue, actualValue);
        }

        private static IList<IDirection> GenerateDirectionsList()
        {
            IList<IDirection> directions = new List<IDirection>();

            directions.Add(new Direction(1, 1));
            directions.Add(new Direction(1, 0));
            directions.Add(new Direction(1, -1));
            directions.Add(new Direction(0, -1));
            directions.Add(new Direction(-1, -1));
            directions.Add(new Direction(-1, 0));
            directions.Add(new Direction(-1, 1));
            directions.Add(new Direction(0, 1));

            return directions;
        }
    }
}
