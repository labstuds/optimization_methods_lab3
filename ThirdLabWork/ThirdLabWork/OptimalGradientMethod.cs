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
        public static Vector2 findMinimum(Vector2 startX, double h, double eps)
        {
            Vector2 answer = new Vector2();
            Vector2 args = startX;
            Vector2 gradientValue;
            bool answerFound = false;
            
                // Шаг 1
                int k = 0;
            while (!answerFound)
            {
                // Шаг 2
                gradientValue = CountRightScheme.Instance.countDerivative(h, args, taskFunction);

                // Шаг 3
                if (gradientValue.getEuclidNorm() <= eps)
                    // Перейти на шаг 7
                    answerFound = true;
                else
                {
                    // Шаг 4
                    
                }
            }


            return answer;
        }

        private static double taskFunction(Vector2 args)
        {   
            return Math.Pow(Math.Pow(args.X, 2) + args.Y - 11, 2) + Math.Pow(args.X + Math.Pow(args.Y, 2) - 7, 2);
        }
    }
}
