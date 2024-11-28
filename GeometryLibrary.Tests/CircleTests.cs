using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System.Windows;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Move_CircleCoordinates_ShouldChangeCoordinates()
        {
            // Arrange
            var circle = new Circle(5, 0, 0);
            var mover = new CircleMover();

            // Act
            mover.Move(10, 5, circle);

            // Assert
            Assert.AreEqual(new Point(10, 5), circle.Coordinates);
        }
    }
}
