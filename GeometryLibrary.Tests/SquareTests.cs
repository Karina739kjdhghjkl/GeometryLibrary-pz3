using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Move_SquareCoordinates_ShouldChangeCoordinates()
        {
            // Arrange
            var square = new Square(4, 2, 3);
            var mover = new SquareMover();

            // Act
            mover.Move(-3, 7, square);

            // Assert
            Assert.AreEqual(new Point(-1, 10), square.Coordinates);
        }
    }
}
