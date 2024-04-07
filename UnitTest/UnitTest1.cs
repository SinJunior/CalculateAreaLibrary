namespace UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using TestLibrary;

    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void CircleAreaCalculationTest()
        {
            // Arrange
            Circle circle = new Circle(5);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * 5 * 5, area, 0.001);
        }

        [TestMethod]
        public void TriangleAreaCalculationTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TriangleRightAngledTest()
        {
            // Arrange
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle nonRightTriangle = new Triangle(2, 4, 5);

            // Act
            bool isRightAngled1 = rightTriangle.IsRightAngled();
            bool isRightAngled2 = nonRightTriangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled1);
            Assert.IsFalse(isRightAngled2);
        }
    }
}