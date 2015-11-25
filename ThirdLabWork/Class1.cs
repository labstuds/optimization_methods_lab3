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

namespace linearOptimizationLab1
{
    class localizationMethod
    {
        static public LinearInterval calculate(double x0, double h)
        {
            LabEnvironment.log.send("Начата работа метода Дэвиса-Свенна-Кэмпи.");
            LabEnvironment.log.send("Начальная точка x0 = " + x0 + ", h= " + h);
            double a = 0f, b = 0f;
            int k = 1;
            Dictionary<int, double> x = new Dictionary<int, double>();
            x.Add(0, x0);
            x.Add(1, 0);
            LabEnvironment.log.send("1. Вычисление f(x0) = " + LabEnvironment.task.formula(x0) + ", f(x0+h) = " + LabEnvironment.task.formula(x0 + h));
            if (LabEnvironment.task.formula(x0) > LabEnvironment.task.formula(x0 + h))
            {
                LabEnvironment.log.send("2. Сработало условие f(x0)>f(x0+h), f(x0) = " + LabEnvironment.task.formula(x0) + ", f(x0+h) = " + LabEnvironment.task.formula(x0 + h));
                a = x[0];
                x[1] = x[0] + h;
                k = 2;
            }
            else if (LabEnvironment.task.formula(x[0] - h) >= LabEnvironment.task.formula(x[0]))
            {
                LabEnvironment.log.send("3. Сработало условие f(x0-h)>=f(x0), f(x0-h) = " + LabEnvironment.task.formula(x0 - h) + ", f(x0) = " + LabEnvironment.task.formula(x0));
                a = x0 - h;
                b = x0 + h;
                LabEnvironment.log.send("3. Метод завершается с результатом " + a + ";" + b);
                return new LinearInterval(a, b);
            }
            else
            {
                LabEnvironment.log.send("3. Сработало условие f(x0)<=f(x0+h), f(x0) = " + LabEnvironment.task.formula(x0) + ", f(x0+h) = " + LabEnvironment.task.formula(x0 + h));
                b = x[0];
                x[1] = x[0] - h;
                h = -h;
                k = 2;
            }
            bool aIsFound = false;
            bool bIsFound = false;
            LabEnvironment.log.send("4. Начало итерационного поиска");
            int iter = 1;
            while (!bIsFound || !aIsFound)
            {
                LabEnvironment.log.send("Итерация номер " + iter);
                iter++;
                x.Add(k, x[0] + Math.Pow(2, k - 1) * h);
                if (LabEnvironment.task.formula(x[k - 1]) <= LabEnvironment.task.formula(x[k]))
                {
                    LabEnvironment.log.send("5. Сработало условие f(x[k-1])<=f(x[k]). k = " + k + ", f(x[k-1]) = " + LabEnvironment.task.formula(x[k - 1]) + ", f(x[k]) = " + LabEnvironment.task.formula(x[k]));
                    if (h > 0)
                    {
                        b = x[k];
                        LabEnvironment.log.send("Была найдена более подходящая правая граница отрезка локализации минимума: " + b);
                        bIsFound = true;
                    }
                    else
                    {
                        a = x[k];
                        LabEnvironment.log.send("Была найдена более подходящая левая граница отрезка локализации минимума: " + a);
                        aIsFound = true;
                    }
                }
                else if (h > 0)
                {
                    LabEnvironment.log.send("5. Сработало условие f(x[k-1])>f(x[k]). k = " + k + ", f(x[k-1]) = " + LabEnvironment.task.formula(x[k - 1]) + ", f(x[k]) = " + LabEnvironment.task.formula(x[k]));
                    a = x[k - 1];
                    LabEnvironment.log.send("Была найдена более подходящая левая граница отрезка локализации минимума: " + a);
                    aIsFound = true;
                }
                else
                {
                    LabEnvironment.log.send("5. Сработало условие f(x[k-1])>f(x[k]). k = " + k + ", f(x[k-1]) = " + LabEnvironment.task.formula(x[k - 1]) + ", f(x[k]) = " + LabEnvironment.task.formula(x[k]));
                    b = x[k - 1];
                    LabEnvironment.log.send("Была найдена более подходящая правая граница отрезка локализации минимума: " + b);
                    bIsFound = true;
                }
                k++;
            }
            LabEnvironment.log.send("Найдены подходящие границы отрезка локализации минимума. Это " + a + ";" + b);
            LinearInterval interval = new LinearInterval(a, b);
            return interval;
        }
    }

    class dichotomyMethod
    {
        static public double calculate(LinearInterval interval, double e, double bue)
        {
            LabEnvironment.log.send("Начал работу метод дихотомии.");
            LabEnvironment.log.send("Начальные значения. Интервал " + interval.ToString() + ", eps = " + e + ", константа различимости = " + bue);
            double x1, x2;
            int iter = 1;
            while ((interval.RightBorder - interval.LeftBorder) / 2 > e)
            {
                LabEnvironment.log.send("4. Критерий останова не сработал.");
                LabEnvironment.log.send("Итерация номер " + iter);
                iter++;
                x1 = 0.5 * (interval.LeftBorder + interval.RightBorder) - bue;
                x2 = 0.5 * (interval.LeftBorder + interval.RightBorder) + bue;
                LabEnvironment.log.send("1. Очередная итерация метода. x1 = " + x1 + ", x2 = " + x2);
                LabEnvironment.log.send("2. Значения f(x1) = " + LabEnvironment.task.formula(x1) + ", f(x2) = " + LabEnvironment.task.formula(x2));
                if (LabEnvironment.task.formula(x1) <= LabEnvironment.task.formula(x2))
                {
                    LabEnvironment.log.send("3. f(x1) <= f(x2)");
                    LabEnvironment.log.send("Обновлена правая граница, установлено значение x2 = " + x2);
                    interval.RightBorder = x2;
                }
                else
                {
                    LabEnvironment.log.send("3. f(x1) > f(x2)");
                    LabEnvironment.log.send("Обновлена левая граница, установлено значение x1 = " + x1);
                    interval.LeftBorder = x1;
                }
            }
            LabEnvironment.log.send("5. Метод завершил работу. Приблизительный результат x~ " + interval.Middle + ", f(x) = " + LabEnvironment.task.formula(interval.Middle));
            return interval.Middle;
        }
    }

    class pouelMethod
    {
        public static double calculate(LinearInterval interval, double e)
        {
            LabEnvironment.log.send("Начал работу метод параболической аппроксимации Пауэлла.");
            LabEnvironment.log.send("Начальные значения, интервал " + interval + ", eps = " + e);
            List<double> x = new List<double> { 0, 0, 0, 0 };
            x[0] = interval.LeftBorder;
            x[1] = interval.Middle;
            x[2] = interval.RightBorder;
            int iter = 1;
            while (true)
            {
                LabEnvironment.log.send("Итерация номер " + iter);
                iter++;
                LabEnvironment.log.send("1. Найдено x1 = " + x[0] + ", x2 = " + x[1] + ", x3 = " + x[2]);
                double xMin = MathHelp.minimum(x[0], x[1], x[2]);
                LabEnvironment.log.send("2. Минимальное значение: " + xMin);
                x[3] = parabolicApproximation(x);
                LabEnvironment.log.send("3. Пересчитан x4 = " + x[3]);
                if (Math.Abs(x[3] - xMin) <= e)
                {
                    LabEnvironment.log.send("4. x4 достаточно приближен к истинному минимуму. Завершение работы алгоритма.");
                    return x[3];
                }
                LabEnvironment.log.send("4. x4 не достаточно приближен к истинному минимуму. Продолжение работы алгоритма.");
                x.Sort();//P.S. не уверен, что это нужно. пока пусть будет
                LabEnvironment.log.send("5. Точки отсортированы по возрастанию. " + x[0] + ", " + x[1] + ", " + x[2] + ", " + x[3]);
                x.Sort(compareValuesByFunctionValues);
                LabEnvironment.log.send("5. Точки отсортированы по значению функции. " + x[0] + ", " + x[1] + ", " + x[2] + ", " + x[3]);
            }
        }
        static public double parabolicApproximation(List<double> x)
        {
            double numenator = (Math.Pow(x[1], 2) - Math.Pow(x[2], 2)) * LabEnvironment.task.formula(x[0]) + (Math.Pow(x[2], 2) - Math.Pow(x[0], 2)) * LabEnvironment.task.formula(x[1]) + (Math.Pow(x[0], 2) - Math.Pow(x[1], 2)) * LabEnvironment.task.formula(x[2]);
            double denominator = (x[1] - x[2]) * LabEnvironment.task.formula(x[0]) + (x[2] - x[0]) * LabEnvironment.task.formula(x[1]) + (x[0] - x[1]) * LabEnvironment.task.formula(x[2]);
            return 0.5 * numenator / denominator;
        }

        static public int compareValuesByFunctionValues(double x, double y)
        {
            if (LabEnvironment.task.formula(x) == LabEnvironment.task.formula(y))
            {
                return 0;
            }
            else if (LabEnvironment.task.formula(x) < LabEnvironment.task.formula(y))
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
