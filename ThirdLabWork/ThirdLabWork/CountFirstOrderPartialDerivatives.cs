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
        public abstract Vector2 countDerivative(Vector2 h, Vector2 args, Func<Vector2, double> func);             
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

        public override Vector2 countDerivative(Vector2 h, Vector2 args, Func<Vector2, double> func)
        {
            double x1 = (func(new Vector2(args.X + h.X, args.Y)) - func(args)) / h.X;
            double x2 = (func(new Vector2(args.X, args.Y + h.Y)) - func(args)) / h.Y;
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

        public override Vector2 countDerivative(Vector2 h, Vector2 args, Func<Vector2, double> func)
        {
            double x1 = (func(new Vector2(args.X + h.X/2, args.Y)) - func(new Vector2(args.X - h.X/2, args.Y))) / h.X;
            double x2 = (func(new Vector2(args.X, args.Y + h.Y / 2)) - func(new Vector2(args.X, args.Y - h.Y / 2))) / h.Y;
            return new Vector2(x1, x2);
        }
    }
}
