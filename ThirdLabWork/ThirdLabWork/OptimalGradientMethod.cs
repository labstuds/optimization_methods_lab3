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
        public static Vector2 findMinimum(Vector2 startX, double alpha, double eps, Func<Vector2, double> taskFunction)
        {
            LoggerEvs.writeLog("Optimal gradient method started!");
            Vector2 answer = new Vector2();
            Vector2 args = startX;
            Vector2 gradientValue;               
            bool answerFound = false;
            LoggerEvs.writeLog(string.Format("\tData input:\n(x1; x2) = ({0:N3}; {1:N3}),\nAlpha = {2:N3},\neps = {3:N3};", startX.X, startX.Y, alpha, eps));
            
            // Шаг 1
            int k = 0;            
            while (!answerFound)
            {
                LoggerEvs.writeLog(string.Format("ITER {0}:", k));
                LoggerEvs.writeLog(string.Format("Step 1: k = {0};", k));
                // Шаг 2
                if (alpha >= 0.01)
                    gradientValue = CountCentralScheme.Instance.countDerivative(alpha, args, taskFunction);
                else 
                    gradientValue = CountRightScheme.Instance.countDerivative(alpha, args, taskFunction);
                LoggerEvs.writeLog(string.Format("Step 2: gradient is ({0:N3}, {1:N3});", gradientValue.X, gradientValue.Y));
                // Шаг 3
                if (gradientValue.getEuclidNorm() <= eps)
                {
                    // Перейти на шаг 7
                    answerFound = true;
                    LoggerEvs.writeLog(string.Format("Step 3: gradient Euclidean norm is <= eps: {0:N3} <= {1}; Go to step 7!", gradientValue.getEuclidNorm(), eps));
                }
                else
                {
                    // Шаг 4                    
                    // Провести метод одномерной оптимизации
                    Interval alphaValues = DSKMethodCounter.countInterval(taskFunction, alpha, args, gradientValue, 0.01);
                    alpha = DichotomyMethodCounter.findMinimum(taskFunction, alphaValues, 0.01, args, gradientValue);
                    LoggerEvs.writeLog(string.Format("Step 4: Alpha = {0};", alpha));
                    // Шаг 5
                    args = args - alpha * gradientValue;
                    LoggerEvs.writeLog(string.Format("Step 5: arguments = arguments - alpha * gradientValue = ({0:N3}; {1:N3});", args.X, args.Y));
                    // Шаг 6
                    k += 1;
                    LoggerEvs.writeLog(string.Format("Step 6: k = k + 1 = {0};", k - 1));
                }
                // Шаг 7
                // Положить
                answer = args;
                LoggerEvs.writeLog(string.Format("Step 7: answer is: ({0:N3}; {1:N3});", answer.X, answer.Y));
            }
            return answer;
        }        
    }
}
