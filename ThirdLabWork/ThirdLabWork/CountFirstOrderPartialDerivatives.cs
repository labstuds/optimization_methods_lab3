using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdLabWork
{
    /// <summary>
    /// Вычислить частные производные первого порядка функции двух переменных
    /// </summary>
    abstract class CountFirstOrderPartialDerivatives
    {
        public abstract Vector2 countDerivative(double h, Vector2 args, Func<Vector2, double> func);             
    }

    class CountRightScheme : CountFirstOrderPartialDerivatives
    {
        private static CountRightScheme instance;
        public static CountRightScheme Instance
        {
            get
            {
                if (instance == null)
                    instance = new CountRightScheme();
                return instance;
            }
        }
        
        private CountRightScheme()
        {

        }

        public override Vector2 countDerivative(double h, Vector2 args, Func<Vector2, double> func)
        {
            double x1 = (func(new Vector2(args.X + h, args.Y)) - func(args)) / h;
            double x2 = (func(new Vector2(args.X, args.Y + h)) - func(args)) / h;
            return new Vector2(x1, x2);
        }        
    }

    class CountCentralScheme : CountFirstOrderPartialDerivatives
    {
        private static CountCentralScheme instance;
        public static CountCentralScheme Instance
        {
            get
            {
                if (instance == null)
                    instance = new CountCentralScheme();
                return instance;
            }
        }

        private CountCentralScheme()
        {

        }

        public override Vector2 countDerivative(double h, Vector2 args, Func<Vector2, double> func)
        {
            double x1 = (func(new Vector2(args.X + h / 2, args.Y)) - func(new Vector2(args.X - h / 2, args.Y))) / h;
            double x2 = (func(new Vector2(args.X, args.Y + h / 2)) - func(new Vector2(args.X, args.Y - h / 2))) / h;
            return new Vector2(x1, x2);
        }
    }

    class Gradient
    {
        public static Vector2 get(double alpha, Vector2 args, Func<Vector2, double> taskFunction)
        {
            if (alpha >= 0.01)
               return CountCentralScheme.Instance.countDerivative(alpha, args, taskFunction);
            else
                return CountRightScheme.Instance.countDerivative(alpha, args, taskFunction);
        }
    }
}
