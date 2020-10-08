using NUnit.Framework;
using System;
using System.Linq;

namespace FiguresLibrary.Tests
{
    public class FiguresLibraryTests
    {
        [Test]
        public void Calculator_CalculateAreaSum_ShouldReturnCorrectResult()
        {
            //arrange
            var circle = new Circle(5);
            var triangle = new Triangle(6, 6, 6);
            var rightTriangle = new Triangle(3, 4, 5);
            //act
            var result = Calculator.CalculateAreaSum(new IFigure[] { circle, triangle, rightTriangle });
            //assert
            Assert.AreEqual(100.13, Math.Round(result, 2), "Разные значения");
        }

        [Test]
        public void Calculator_CalculateAreaSum_NullArgument_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Calculator.CalculateAreaSum(null));
        }

        [Test]
        public void Calculator_CalculateAreaSum_EmptyCollectionArgument_ThrowArgumentNullException()
        {
            Assert.Throws<InvalidOperationException>(() => Calculator.CalculateAreaSum(new IFigure[0]));
        }

        [Test]
        public void Circle_CalculateArea_ShouldReturnCorrectResult()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();
            Assert.AreEqual(Math.PI * Math.Pow(5, 2), area, "Разные значения");
        }

        [Test]
        public void Circle_CalculateArea_NegativeValue_ArgumentOutOfRangeException()
        {
            var circle = new Circle(-5);
            Assert.Throws<ArgumentOutOfRangeException>(() => circle.CalculateArea());
        }

        [Test]
        public void RightTriangle_CalculateArea_With_Sides_3_4_5_Is_6()
        {
            var rightTriangle = new RightTriangle(3, 4, 5);
            var area = rightTriangle.CalculateArea();
            Assert.AreEqual(6, area, "Разные значения");
        }

        [Test]
        public void RightTriangle_CalculateArea_BadSides_InvalidOperationException()
        {
            var rightTriangle = new RightTriangle(3, 4, 6);
            Assert.Throws<InvalidOperationException>(() => rightTriangle.CalculateArea());
        }

        [Test]
        public void Triangle_CalculateArea_With_Sides_5_5_8_Is_12()
        {
            var triangle = new Triangle(5, 5, 8);
            var area = triangle.CalculateArea();
            Assert.AreEqual(12, area, "Разные значения");
        }

        [Test]
        public void Triangle_CalculateArea_NegativeSide_ArgumentOutOfRangeException()
        {
            var triangle = new Triangle(-1, 4, 6);
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.CalculateArea());
        }

        [Test]
        public void Triangle_CalculateArea_BadSides_InvalidOperationException()
        {
            var triangle = new Triangle(2, 2, 8);
            Assert.Throws<InvalidOperationException>(() => triangle.CalculateArea());
        }
    }
}