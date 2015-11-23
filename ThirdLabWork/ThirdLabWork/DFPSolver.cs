using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace ThirdLabWork
{
    class DFPSolver
    {
        Vector<double> basicX;
        double eps;
        Vector<double> result = Vector<double>.Build.Dense(2, 0);
        double alpha = 0.0015f;
        public DFPSolver()
        {

        }

        public void setStartingVariables(Vector2 x, double eps)
        {
            basicX = Vector<double>.Build.Dense(2, 0);
            basicX[0] = x.X;
            basicX[1] = x.Y;
            this.eps = eps;
        }

        public Vector2 calculate(Func<Vector2, double> taskFunction, double h, double epsDich)
        {
            LoggerEvs.writeLog("DFP method started");
            Vector<double> grad = Vector<double>.Build.Dense(2,0);
            Vector<double> sk = Vector<double>.Build.Dense(2,0), xk = Vector<double>.Build.Dense(2,0), xk_1 = Vector<double>.Build.Dense(2,0), yk = Vector<double>.Build.Dense(2,0), pk = Vector<double>.Build.Dense(2,0);
            xk = basicX;
            Matrix<double> Hk_1 = Matrix<double>.Build.DenseIdentity(2);
            Matrix<double> Hk = Matrix<double>.Build.DenseIdentity(2);
            double ak;
            double normalize=0;
            LoggerEvs.writeLog(string.Format("Input data. Start point {0}, epsilon {1:N5}", basicX, eps));
        step1:
            LoggerEvs.writeLog(string.Format("Step 1: K = 0"));
            int k = 0;
        step2:
            LoggerEvs.writeLog(string.Format("Step 2: ITERATION number {0}", k));
            Vector2 gradTemp = Gradient.get(alpha, new Vector2(xk[0], xk[1]), taskFunction);
            grad[0] = gradTemp.X;
            grad[1] = gradTemp.Y;
        step3:
            normalize = grad.L2Norm();
            if (normalize <= eps)
            {
                LoggerEvs.writeLog(string.Format("Step 3: End of searching. Final values: Function = {0}, Point = {1}. Go to step 12.", taskFunction(new Vector2(xk[0], xk[1])), xk));
                goto step12;
            }
        step4:
            if (k == 0)
            {
                LoggerEvs.writeLog("Step 4: K==0, go to step 8.");
                goto step8;
            }
        step5:
            sk = xk - xk_1;
            LoggerEvs.writeLog(string.Format("Step 5: Sk = {0}", sk));
        step6:
            Vector2 ykTemp = Gradient.get(alpha, new Vector2(xk[0], xk[1]), taskFunction) - Gradient.get(alpha, new Vector2(xk_1[0], xk_1[1]), taskFunction);
            yk[0] = ykTemp.X;
            yk[1] = ykTemp.Y;
            LoggerEvs.writeLog(string.Format("Step 6: Yk = {0}", yk));
        step7:
            Hk_1 = Hk;
            Matrix<double> firstUp =  Hk_1*yk.ToColumnMatrix()*yk.ToRowMatrix()*Hk_1;
            Matrix<double> firstDown = yk.ToRowMatrix()*Hk_1*yk.ToColumnMatrix();
            Matrix<double> secondUp = sk.ToColumnMatrix()*sk.ToRowMatrix();
            Matrix<double> secondDown =  yk.ToRowMatrix()*sk.ToColumnMatrix();
            
            Hk = Hk_1 - firstUp / firstDown[0, 0] + secondUp / secondDown[0, 0];
            LoggerEvs.writeLog(string.Format("Step 7: Quasi-Newton matrix: \r\n{0}", Hk));
        step8:
            Vector2 tempPk = Gradient.get(alpha, new Vector2(xk[0], xk[1]), taskFunction);
            Vector<double> test = Vector<double>.Build.Dense(2, 0);
            test[0] = tempPk.X;
            test[1] = tempPk.Y;
            pk = -Hk * test;
            
            LoggerEvs.writeLog(string.Format("Step 8: Search vector: {0}", pk));
        step9:
            Vector<double> tmpxk = xk + alpha * pk;
            Vector2 gradientValue = Gradient.get(alpha, new Vector2(tmpxk[0], tmpxk[1]), taskFunction);            
            Interval alphaValues = DSKMethodCounter.countInterval(taskFunction, alpha, new Vector2(tmpxk[0], tmpxk[1]), gradientValue, h);
            
            alpha = DichotomyMethodCounter.findMinimum(taskFunction, alphaValues, epsDich, new Vector2(tmpxk[0], tmpxk[1]), gradientValue);
            LoggerEvs.writeLog(string.Format("Step 9: New alpha {0}", alpha));
        step10:
            xk_1 = xk;
            //xk = xk + alpha * pk;//??
            LoggerEvs.writeLog(string.Format("Step 10: New local search point {0}", xk));
        step11:
            k++;
            LoggerEvs.writeLog("Step 11: Iteration end.");
            goto step2;
        step12:
            LoggerEvs.writeLog("Step 12: Search is done!");
            Vector2 result = new Vector2(xk[0], xk[1]);
            ///double sss = taskFunction(new Vector2(0.003, -0.05));
            return result;
        }

        public Vector2 returnApproximateSolution(Vector2 x, double eps, Func<Vector2, double> taskFunction, double h, double epsDich)
        {
            setStartingVariables(x, eps);
            return calculate(taskFunction, h, epsDich);
        }
    }
}
