using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public interface IFigure
    {
        #region Properties

        /// <summary>
        /// Название фигуры
        /// </summary>
        string Name { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Метод расчета площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        double CalculateArea();

        #endregion
    }
}
