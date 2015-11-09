using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ThirdLabWork
{
    public static class DichotomyMethodCounter
    {  
        public static double findMinimum(Interval searchInterval, double eps, Func<Vector2, double> countFunctionValue, bool fixedLeftEdge)
        {
            LoggerEvs.writeLog("Dichotomy method has been started!");
            double x_end = 0;                       // Найденное значение x
            double x_1, x_2;                        // Границы промежуточных отрезков                        
            bool countStop = false;                 // Остановка расчетов
            double delta = eps / 10;                // Константа "различимости"
            double f_x_1, f_x_2;
            Vector2 args = new Vector2();
            
            for (int i = 0; !countStop; i++)
            {
                // Шаг первый                
                x_1 = 0.5 * (searchInterval.LeftEdge + searchInterval.RightEdge) - delta;
                x_2 = 0.5 * (searchInterval.LeftEdge + searchInterval.RightEdge) + delta;
                
                // Шаг второй (вычисление) и третий (сравнение)                    
                if (!fixedLeftEdge)
                {
                    f_x_1 = countFunctionValue(new Vector2(x_1, args.Y));
                    f_x_2 = countFunctionValue(new Vector2(x_2, args.Y));
                }
                else
                {
                    f_x_1 = countFunctionValue(new Vector2(args.X, x_1));
                    f_x_2 = countFunctionValue(new Vector2(args.X, x_2));
                }
    
                if (f_x_1 <= f_x_2)
                    searchInterval.RightEdge = x_2;               
                else
                    searchInterval.LeftEdge = x_1;
                
                // Шаг четвертый
                double diff = (searchInterval.RightEdge - searchInterval.LeftEdge)/2;
                if ( diff < eps)
                    countStop = true;
            }
            // Шаг пятый
            x_end = (searchInterval.LeftEdge + searchInterval.RightEdge) / 2;
            // Вывод результата
            return x_end;
        }
    
    }
}
