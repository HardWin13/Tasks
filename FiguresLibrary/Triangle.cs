using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Triangle : IFigure
    {
        #region Fields

        /// <summary>
        /// Сторона a
        /// </summary>
        protected readonly double _a;

        /// <summary>
        /// Сторона b
        /// </summary>
        protected readonly double _b;

        /// <summary>
        /// Сторона c
        /// </summary>
        protected readonly double _c;

        #endregion

        #region Constructor

        /// <summary>
        /// Инициализирует объект треугольника
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            Name = "Треугольник";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Название фигуры
        /// </summary>
        public virtual string Name { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Метод расчета площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public virtual double CalculateArea()
        {
            //Если хоть одна из сторон отрицательная или равна 0, то выбрасывается  ArgumentOutOfRangeException
            if (_a <= 0 || _b <= 0 || _c <= 0)
                throw new ArgumentOutOfRangeException("Стороны заданы неверно");

            if ((_a + _b > _c) && (_a + _c > _b) && (_b + _c > _a))
            {
                double p = (_a + _b + _c) / 2;
                return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)); //формула Герона для расчета площади треугольника по 3 сторонам, где p-полупериметр
            }
            else
                throw new InvalidOperationException("Треугольника с такими сторонами не существует");
        }

        #endregion
    }
}
