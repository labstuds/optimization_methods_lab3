using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdLabWork
{
    class DFPSolver
    {
        Vector2 basicX;
        double eps;
        Vector2 result;
        public DFPSolver()
        {

        }

        public void setStartingVariables(Vector2 x, double eps)
        {
            basicX = x;
            this.eps = eps;
        }

        public Vector2 calculate()
        {
            //TO DO place code here
            return new Vector2(0, 0);
        }

        public Vector2 returnApproximateSolution(Vector2 x,double eps)
        {
            setStartingVariables(x,eps);
            return calculate();
        }
    }
}
