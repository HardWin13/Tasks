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
        public void Circle_CalculateArea_ShouldReturnCorrectResult()
        {
            //arrange
            Circle circle = new Circle(5);
            //act
            var area = circle.CalculateArea();
            //assert
            Assert.AreEqual(Math.PI * Math.Pow(5, 2), area, "Разные значения");
        }

        [Test]
        public void RightTriangle_Calculate_Area_With_Sides_3_4_5_Is_6()
        {
            //arrange
            RightTriangle righttriangle = new RightTriangle(3, 4, 5);
            //act
            var area = righttriangle.CalculateArea();
            //assert
            Assert.AreEqual(6, area, "Разные значения");
        }

        [Test]
        public void Test_With_Negative_Value_For_Radius_Of_Circle()
        {
            Circle circle = new Circle(-5);
            Assert.Throws<ArgumentOutOfRangeException>(() => circle.CalculateArea());
        }

        [Test]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_With_Negative_Value_For_Side_Of_RightTriangle()
        {
            //arrange
            RightTriangle righttriangle = new RightTriangle(-3, 4, 5);
            //act
            var area = righttriangle.CalculateArea();
        }

        [Test]
        //[ExpectedException(typeof(FormatException))]
        public void RightTriangle_Is_Right() //Проверяем правильность введенных сторон                                           
        {                                    //Если они не соответствуют прямоугольному треугольнику, то получаем исключение 
            //arrange
            RightTriangle righttriangle = new RightTriangle(1, 1, 1);
            //act
            var area = righttriangle.CalculateArea();
        }
    }
}