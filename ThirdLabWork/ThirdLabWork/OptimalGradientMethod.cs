using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdLabWork
{
    public static class OptimalGradientMethod
    {
        /// <summary>
        /// Найти точку, в которой функция минимальна
        /// </summary>
        public static Vector2 findMinimum(Vector2 startX, Vector2 h, double eps)
        {
            Vector2 answer = new Vector2();
            // Шаг 1
            int k = 0;

            // Шаг 2



            return answer;
        }

        private double taskFunction(Vector2 args)
        {
            return Math.Pow(Math.Pow(args.X, 2) + args.Y - 11, 2) + Math.Pow(args.X + Math.Pow(args.Y, 2) - 7, 2);
        }
    }
}
