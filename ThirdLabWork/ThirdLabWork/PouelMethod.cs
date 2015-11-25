using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThirdLabWork;

namespace ThirdLabWork
{
    public class LinearInterval
    {
        double leftBorder;
        double rightBorder;

        public LinearInterval(double firstBorder, double secondBorder)
        {
            if (firstBorder >= secondBorder)
            {
                leftBorder = secondBorder;
                rightBorder = firstBorder;
            }
            else
            {
                leftBorder = firstBorder;
                rightBorder = secondBorder;
            }
        }

        public double LeftBorder
        {
            get { return leftBorder; }
            set { leftBorder = value; }
        }

        public double RightBorder
        {
            get { return rightBorder; }
            set { rightBorder = value; }
        }

        public override string ToString()
        {
            return "" + leftBorder + ";" + rightBorder;
        }

        public double Length
        {
            get { return rightBorder - leftBorder; }
        }

        public bool valueIsBelongsIncludingLeftAndRightBorders(double value)
        {
            return leftBorder <= value && value <= rightBorder;
        }

        public bool valueIsBelongsIncludingRightBorders(double value)
        {
            return leftBorder < value && value <= rightBorder;
        }

        public double Middle
        {
            get { return (leftBorder + rightBorder) / 2; }
        }
    }

    class LocalizationMethod
    {
        static public LinearInterval calculate(double x0,double h,Func<double,double> func)
        {
            LoggerEvs.writeLog("Начата работа метода Дэвиса-Свенна-Кэмпи.");
            LoggerEvs.writeLog("Начальная точка x0 = "+x0+", h= "+h);
            double a = 0f, b = 0f;
            int k=1;
            Dictionary<int,double> x = new Dictionary<int,double>();
            x.Add(0,x0);
            x.Add(1,0);
            LoggerEvs.writeLog("1. Вычисление f(x0) = " + func(x0) + ", f(x0+h) = " + func(x0 + h));
            if(func(x0)>func(x0+h))
            {
                LoggerEvs.writeLog("2. Сработало условие f(x0)>f(x0+h), f(x0) = " + func(x0) + ", f(x0+h) = " + func(x0 + h));
                a = x[0];
                x[1] = x[0] + h;
                k=2;
            }
            else if(func(x[0]-h)>=func(x[0]))
            {
                LoggerEvs.writeLog("3. Сработало условие f(x0-h)>=f(x0), f(x0-h) = " + func(x0-h) + ", f(x0) = " + func(x0));
                a = x0 - h;
                b = x0 + h;
                LoggerEvs.writeLog("3. Метод завершается с результатом "+a+";"+b);
                return new LinearInterval(a, b);
            }
            else
            {
                LoggerEvs.writeLog("3. Сработало условие f(x0)<=f(x0+h), f(x0) = " + func(x0) + ", f(x0+h) = " + func(x0 + h));
                b = x[0];
                x[1] = x[0] - h;
                h = -h;
                k = 2;
            }
            bool aIsFound=false;
            bool bIsFound=false;
            LoggerEvs.writeLog("4. Начало итерационного поиска");
            int iter = 1;
            while(!bIsFound||!aIsFound)
            {
                LoggerEvs.writeLog("Итерация номер " + iter);
                iter++;
                x.Add(k,x[0]+Math.Pow(2,k-1)*h);
                if(func(x[k-1])<=func(x[k]))
                {
                    LoggerEvs.writeLog("5. Сработало условие f(x[k-1])<=f(x[k]). k = "+k+", f(x[k-1]) = "+func(x[k-1])+", f(x[k]) = "+func(x[k]));
                    if(h>0)
                    {
                        b=x[k];
                        LoggerEvs.writeLog("Была найдена более подходящая правая граница отрезка локализации минимума: "+b);
                        bIsFound = true;
                    }
                    else{
                        a=x[k];
                        LoggerEvs.writeLog("Была найдена более подходящая левая граница отрезка локализации минимума: " + a);
                        aIsFound = true;
                    }
                }
                else if(h>0){
                    LoggerEvs.writeLog("5. Сработало условие f(x[k-1])>f(x[k]). k = " + k + ", f(x[k-1]) = " + func(x[k - 1]) + ", f(x[k]) = " + func(x[k]));
                    a=x[k-1];
                    LoggerEvs.writeLog("Была найдена более подходящая левая граница отрезка локализации минимума: " + a);
                    aIsFound=true;
                }
                else{
                    LoggerEvs.writeLog("5. Сработало условие f(x[k-1])>f(x[k]). k = " + k + ", f(x[k-1]) = " + func(x[k - 1]) + ", f(x[k]) = " + func(x[k]));
                    b=x[k-1];
                    LoggerEvs.writeLog("Была найдена более подходящая правая граница отрезка локализации минимума: " + b);
                    bIsFound=true;
                }
                k++;
            }
            LoggerEvs.writeLog("Найдены подходящие границы отрезка локализации минимума. Это "+a+";"+b);
            LinearInterval interval = new LinearInterval(a,b);
            return interval;
        }
    }

    class pouelMethod
    {

        static private Func<double, double> func;
        public static double calculate(LinearInterval interval, double e,Func<double,double> func)
        {
            pouelMethod.func = func;
             LoggerEvs.writeLog("Начал работу метод параболической аппроксимации Пауэлла.");
             LoggerEvs.writeLog("Начальные значения, интервал " + interval + ", eps = " + e);
            List<double> x = new List<double> { 0, 0, 0, 0 };
            x[0] = interval.LeftBorder;
            x[1] = interval.Middle;
            x[2] = interval.RightBorder;
            int iter = 1;
            while (true)
            {
                 LoggerEvs.writeLog("Итерация номер " + iter);
                iter++;
                 LoggerEvs.writeLog("1. Найдено x1 = " + x[0] + ", x2 = " + x[1] + ", x3 = " + x[2]);
                double xMin = Math.Min(Math.Min(x[0], x[1]), x[2]);
                 LoggerEvs.writeLog("2. Минимальное значение: " + xMin);
                x[3] = parabolicApproximation(x);
                 LoggerEvs.writeLog("3. Пересчитан x4 = " + x[3]);
                if (Math.Abs(x[3] - xMin) <= e)
                {
                     LoggerEvs.writeLog("4. x4 достаточно приближен к истинному минимуму. Завершение работы алгоритма.");
                    return x[3];
                }
                 LoggerEvs.writeLog("4. x4 не достаточно приближен к истинному минимуму. Продолжение работы алгоритма.");
                x.Sort();//P.S. не уверен, что это нужно. пока пусть будет
                 LoggerEvs.writeLog("5. Точки отсортированы по возрастанию. " + x[0] + ", " + x[1] + ", " + x[2] + ", " + x[3]);
                x.Sort(compareValuesByFunctionValues);
                 LoggerEvs.writeLog("5. Точки отсортированы по значению функции. " + x[0] + ", " + x[1] + ", " + x[2] + ", " + x[3]);
            }
        }
        static public double parabolicApproximation(List<double> x)
        {
            double numenator = (Math.Pow(x[1], 2) - Math.Pow(x[2], 2)) * func(x[0]) + (Math.Pow(x[2], 2) - Math.Pow(x[0], 2)) * func(x[1]) + (Math.Pow(x[0], 2) - Math.Pow(x[1], 2)) * func(x[2]);
            double denominator = (x[1] - x[2]) * func(x[0]) + (x[2] - x[0]) * func(x[1]) + (x[0] - x[1]) * func(x[2]);
            return 0.5 * numenator / denominator;
        }

        static public int compareValuesByFunctionValues(double x, double y)
        {
            if (func(x) == func(y))
            {
                return 0;
            }
            else if (func(x) < func(y))
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
