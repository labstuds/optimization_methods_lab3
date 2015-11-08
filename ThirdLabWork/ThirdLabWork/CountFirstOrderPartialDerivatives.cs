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
        public abstract Vector2 countDerivative(Vector2 args, Func<Vector2, double> func);             
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
            instance = new CountRightScheme();
        }
        
        public override Vector2 countDerivative(Vector2 args, Func<Vector2, double> func)
        {
            throw new NotImplementedException();
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
            instance = new CountCentralScheme();
        }

        public override Vector2 countDerivative(Vector2 args, Func<Vector2, double> func)
        {
            throw new NotImplementedException();
        }
    }
}
