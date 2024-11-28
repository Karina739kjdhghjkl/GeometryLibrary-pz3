using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Move_TriangleCoordinates_ShouldChangeCoordinates()
        {
            // Arrange
            var triangle = new Triangle(6, 4, 5, 6);
            var mover = new TriangleMover();

            // Act
            mover.Move(0, -5, triangle);

            // Assert
            Assert.AreEqual(new Point(5, 1), triangle.Coordinates);
        }
    }
}
