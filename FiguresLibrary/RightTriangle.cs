using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class RightTriangle : Triangle
    {
        #region Constructor

        /// <summary>
        /// Инициализирует объект прямоугольного треугольника
        /// </summary>
        /// <param name="a">Катет 1</param>
        /// <param name="b">Катет 2</param>
        /// <param name="c">Гипотенуза</param>
        public RightTriangle(double a, double b, double c) 
            : base(a, b, c)
        {
            Name = "Прямоугольный треугольник";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Название фигуры
        /// </summary>
        public override string Name { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Метод расчета площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public override double CalculateArea()
        {
            if ((Math.Pow(_a, 2) + Math.Pow(_b, 2)) != Math.Pow(_c, 2))
                throw new InvalidOperationException("Треугольник не является прямоугольным");

            return base.CalculateArea();
        }

        #endregion
    }
}
