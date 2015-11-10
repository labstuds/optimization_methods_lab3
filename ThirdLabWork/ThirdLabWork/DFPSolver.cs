﻿using System;
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
            Vector2 grad;
            Vector2 s;
        step1:
            int k = 0;
        step2:
            grad = CountCentralScheme.Instance.countDerivative(new Vector2(0.001f, 0.001f), basicX, OptimalGradientMethod.taskFunction);
        step3:
            if (grad.Length <= eps)
                goto step12;
        step4:
            if (k == 0)
                goto step8;
        step5:


        step8:

        step11:
            k++;
        step12:
            return basicX;
        }

        public Vector2 returnApproximateSolution(Vector2 x, double eps)
        {
            setStartingVariables(x, eps);
            return calculate();
        }
    }
}
