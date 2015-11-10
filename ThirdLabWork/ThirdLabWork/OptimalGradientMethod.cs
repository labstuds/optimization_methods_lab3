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
            Vector2 args = startX;
            Vector2 gradientValue;
            Vector2 new_h = h;
            bool answerFound = false;
            
            // Шаг 1
            int k = 0;
            while (!answerFound)
            {
                // Шаг 2
                gradientValue = CountRightScheme.Instance.countDerivative(h, args, taskFunction);                
                //gradientValue = CountCentralScheme.Instance.countDerivative(h, args, taskFunction);
                // Шаг 3
                if (gradientValue.getEuclidNorm() <= eps)
                    // Перейти на шаг 7
                    answerFound = true;
                else
                {
                    // Шаг 4                    
                    Interval intervalLeft = DSKMethodCounter.countInterval(taskFunction, h, args - h * gradientValue, false);
                    double minLeft = DichotomyMethodCounter.findMinimum(intervalLeft, eps, taskFunction, false);
                    Interval intervalRight = DSKMethodCounter.countInterval(taskFunction, h, args - h * gradientValue, true);
                    double minRight = DichotomyMethodCounter.findMinimum(intervalLeft, eps, taskFunction, true);

                    h = new Vector2(minLeft, minRight);
                    
                    args = args - h * gradientValue;
                    k += 1;
                }
                // Шаг 7
                // Положить
                answer = args;
            }
            return answer;
        }

        public static double taskFunction(Vector2 args)
        {   
            return Math.Pow(Math.Pow(args.X, 2) + args.Y - 11, 2) + Math.Pow(args.X + Math.Pow(args.Y, 2) - 7, 2);            
        }
    }
}
