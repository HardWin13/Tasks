using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Circle : IFigure
    {
        #region Fields

        /// <summary>
        /// Радиус окружности
        /// </summary>
        private readonly double _r;

        #endregion

        #region Constructor

        /// <summary>
        /// Инициализирует объект окружности
        /// </summary>
        /// <param name="r">Радиус окружности</param>
        public Circle(double r)
        {
            _r = r;
            Name = "Окружность";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Метод расчета площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double CalculateArea()
        {
            //Если радиус отрицательный, то выбрасывается  ArgumentOutOfRangeException
            if (_r < 0)
                throw new ArgumentOutOfRangeException();
            else
                return Math.PI * Math.Pow(_r, 2);
        }

        #endregion
    }
}
