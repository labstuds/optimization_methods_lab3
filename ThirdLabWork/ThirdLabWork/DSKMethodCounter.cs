using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThirdLabWork
{
    public static class DSKMethodCounter
    {
        public static Interval countInterval(Func<Vector2, double> countFunctionValue, Vector2 h, Vector2 x_0, bool fixLeftEdge)
        {
            LoggerEvs.writeLog("DSK method started!");
            Interval answer = new Interval(0,0);
            int functionNumber = 0;                         // Номер функции                        
            double f_x_0;                                   // Значение функции в точке x_0
            double f_x_0_h;                                 // Значение функции в точке x_0 + h            
            bool searchEnd = false;                         // Конец поиска            
            List<double> x_values = new List<double>();     // Коллекция значений x_0
            if (!fixLeftEdge)
                x_values.Add(x_0.X);
            else
                x_values.Add(x_0.Y);

            Vector2 args;
            if(!fixLeftEdge)
                args = new Vector2(x_0.X, 0);
            else 
                args = new Vector2(0, x_0.Y);

            // Шаг 1
            f_x_0 = countFunctionValue(args);
            if (!fixLeftEdge)
                args.X += h.X;
            else
                args.Y += h.Y;
            f_x_0_h = countFunctionValue(args);
            int k = 0;
            
            // Шаг 2
            if (f_x_0 > f_x_0_h)
            {
                if (!fixLeftEdge)
                {
                    answer.LeftEdge = x_0.X;
                    double x_tmp = x_0.X + h.X;
                    x_values.Add(x_tmp);
                }
                else
                {
                    answer.LeftEdge = x_0.Y;
                    double x_tmp = x_0.Y + h.Y;
                    x_values.Add(x_tmp);
                }
                k = 2;                
                // Перейти на шаг 4
            }
            else
            {
                // Шаг 3
                double tmpFunc;
                if (!fixLeftEdge)
                    tmpFunc = countFunctionValue(new Vector2(args.X - h.X, args.Y));
                else
                    tmpFunc = countFunctionValue(new Vector2(args.X, args.Y - h.Y));

                if (tmpFunc >= f_x_0)
                {
                    if (!fixLeftEdge)
                    {
                        answer.LeftEdge = x_0.X - h.X;
                        answer.RightEdge = x_0.X + h.X;
                    }
                    else
                    {
                        answer.LeftEdge = x_0.Y - h.Y;
                        answer.RightEdge = x_0.Y + h.Y;
                    }
                    // Перейти на шаг 6
                    searchEnd = true;
                }
                else
                {
                    if (!fixLeftEdge)
                    {
                        answer.RightEdge = x_0.X;
                        x_values.Insert(1, x_0.X - h.X);
                    }
                    else
                    {
                        answer.RightEdge = x_0.Y;
                        x_values.Insert(1, x_0.Y - h.Y);
                    }
                    h = -1*h;
                    k = 2;                    
                }
            }
            while (!searchEnd)
            {
                // Шаг 4
                x_values.Insert(k, 0);
                if(!fixLeftEdge)
                    x_values[k] = x_0.X + Math.Pow(2, k - 1) * h.X;
                else
                    x_values[k] = x_0.Y + Math.Pow(2, k - 1) * h.Y;

                double tmpFunc1, tmpFunc2;
                if (!fixLeftEdge)
                {
                    tmpFunc1 = countFunctionValue(new Vector2(x_values[k - 1], args.Y));
                    tmpFunc2 = countFunctionValue(new Vector2(x_values[k], args.Y));
                }
                else
                {
                    tmpFunc1 = countFunctionValue(new Vector2(args.X, x_values[k - 1]));
                    tmpFunc2 = countFunctionValue(new Vector2(args.X, x_values[k]));
                }
                
                // Шаг 5
                if (tmpFunc1 <= tmpFunc2)
                {
                    double toCompare;
                    if (!fixLeftEdge)
                        toCompare = h.X;
                    else
                        toCompare = h.Y;
                    if (toCompare > 0)
                        answer.RightEdge = x_values[k];
                    else
                        answer.LeftEdge = x_values[k];
                    searchEnd = true;
                }
                else
                {
                    double toCompare;
                    if (!fixLeftEdge)
                        toCompare = h.X;
                    else
                        toCompare = h.Y;
                    if (toCompare > 0)
                        answer.LeftEdge = x_values[k - 1];
                    else
                        answer.RightEdge = x_values[k - 1];
                    // Перейти на шаг 4
                    k++;
                }
            }
            // Шаг 6           
            return answer;
        }
    }
}
