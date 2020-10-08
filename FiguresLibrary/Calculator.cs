using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresLibrary
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Расчитывает сумму площадей фигур
        /// </summary>
        /// <param name="figures">Коллекция фигур</param>
        /// <returns>Сумма площадей</returns>
        public static double CalculateAreaSum(IEnumerable<IFigure> figures)
        {
            if (figures == null)
                throw new ArgumentNullException(nameof(figures));
            if (!figures.Any())
                throw new InvalidOperationException("В коллекции должна присутствовать хотя бы одна фигура");

            var result = figures.Sum(o => o.CalculateArea());
            return result;
        }
    }
}
