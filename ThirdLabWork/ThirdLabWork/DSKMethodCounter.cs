﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLabWork
{
    public static class DSKMethodCounter
    {
        /// <summary>
        /// Найти интервал значений шага альфа, при которых функция будет минимальна
        /// </summary>
        /// <param name="taskFunction">Расчетная функция</param>
        /// <param name="alpha">Шаг альфа</param>
        /// <param name="args">Аргументы функции (координаты точки (x1;x2))</param>
        /// <param name="gradient">Градиент (вектор ЧП 1-го порядка)</param>
        /// <param name="h">Шаг, с которым будет изменяться альфа в процессе поиска интервала</param>
        /// <returns></returns>
        public static Interval countInterval(Func<Vector2, double> taskFunction, double alpha, Vector2 args, Vector2 gradient, double h)
        {
            //LoggerEvs.writeLog("DSK method started!");
            Interval answer = new Interval();
            double f_alpha;                                   // Значение функции в точке alpha
            double f_alpha_h;                                 // Значение функции в точке alpha + h            
            bool searchEnd = false;                         // Конец поиска            
            List<double> alphavalues = new List<double>();     // Коллекция значений alpha
            alphavalues.Add(alpha);
            // Шаг 1
            f_alpha = taskFunction(args - alpha * gradient);
            f_alpha_h = taskFunction(args - (alpha + h) * gradient);
            int k = 0;
            //LoggerEvs.writeLog("Step 1: f(alpha)=" + f_alpha.ToString("f4") + ", f(alpha + h)=" + f_alpha_h.ToString("f4") + "; k=0;");
            // Шаг 2
            if (f_alpha > f_alpha_h)
            {                
                answer.LeftEdge = alpha;
                double alpha_tmp = alpha + h;
                alphavalues.Add(alpha_tmp);
                k = 2;
                //LoggerEvs.writeLog("Step 2: a=" + alpha.ToString("f4") + ", alpha1=" + alpha_tmp.ToString("f4") + ", k=2; Go to step 4!");
                // Перейти на шаг 4
            }
            else
            {
                // Шаг 3
                if (taskFunction(args - (alpha - h) * gradient) >= f_alpha)
                {
                    answer.LeftEdge = alpha - h;
                    answer.RightEdge = alpha + h;
                    //LoggerEvs.writeLog("Step 3: a=" + answer.LeftEdge.ToString("f4") + ", b=" + answer.RightEdge.ToString("f4") + "; Go to step 6!");
                    // Перейти на шаг 6
                    searchEnd = true;
                }
                else
                {
                    answer.RightEdge = alpha;
                    alphavalues.Insert(1, alpha - h);
                    h = -h;
                    k = 2;
                    //LoggerEvs.writeLog("Step 3: b=" + alpha.ToString("f4") + ", alpha1=" + (alpha - h).ToString("f4") + ", h=" + h.ToString("f4") + ", k=2.");
                }
            }
            while (!searchEnd)
            {
                // Шаг 4
                alphavalues.Insert(k, 0);
                alphavalues[k] = alpha + Math.Pow(2, k - 1) * h;
                //LoggerEvs.writeLog("Step 4: alphak=" + alphavalues[k].ToString("f4"));
                // Шаг 5
                if (taskFunction(args - alphavalues[k - 1] * gradient) <= taskFunction(args - alphavalues[k] * gradient))
                {
                    if (h > 0)
                    {
                        answer.RightEdge = alphavalues[k];
                        //LoggerEvs.writeLog("Step 5: h > 0; b=alphak=" + answer.RightEdge.ToString("f4"));
                    }
                    else
                    {
                        answer.LeftEdge = alphavalues[k];
                        //LoggerEvs.writeLog("Step 5: h < 0; a=alphak" + answer.LeftEdge.ToString("f4"));
                    }
                    searchEnd = true;
                }
                else
                {
                    if (h > 0)
                    {
                        answer.LeftEdge = alphavalues[k - 1];
                        //LoggerEvs.writeLog("Step 5: h > 0; a=alpha(k-1)=" + answer.LeftEdge.ToString("f4"));
                    }
                    else
                    {
                        answer.RightEdge = alphavalues[k - 1];
                        //LoggerEvs.writeLog("Step 5: h > 0; b=alpha(k-1)=" + answer.RightEdge.ToString("f4"));
                    }

                    // Перейти на шаг 4
                    k++;
                    //LoggerEvs.writeLog("k = k + 1 = " + k + "; Go to step 4!");
                }
            }
            // Шаг 6
            //LoggerEvs.writeLog("Step 6: Interval is: [" + answer.LeftEdge.ToString("f4") + " ; " + answer.RightEdge.ToString("f4") + "]");
            return answer;
        }
    }
}
