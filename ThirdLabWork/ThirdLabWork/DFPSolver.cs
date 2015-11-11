using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace ThirdLabWork
{
    class DFPSolver
    {
        Matrix<double> basicX;
        double eps;
        Matrix<double> result = Matrix<double>.Build.Dense(2, 1, 0);
        double alpha = 0.09542f;
        public DFPSolver()
        {

        }

        public void setStartingVariables(Vector2 x, double eps)
        {
            basicX = Matrix<double>.Build.Dense(2,1, (double)0);
            basicX[0, 0] = x.X;
            basicX[1, 0] = x.Y;
            this.eps = eps;
        }

        public Vector2 calculate(Func<Vector2, double> taskFunction)
        {
            LoggerEvs.writeLog("DFP method started");
            Matrix<double> grad = Matrix<double>.Build.Dense(2,1,0);
            Matrix<double> sk = Matrix<double>.Build.Dense(2, 1, 0), xk = Matrix<double>.Build.Dense(2, 1, 0), xk_1 = Matrix<double>.Build.Dense(2, 1, 0), yk = Matrix<double>.Build.Dense(2, 1, 0), pk = Matrix<double>.Build.Dense(2, 1, 0);
            xk = basicX;
            Matrix<double> Hk_1= Matrix<double>.Build.DenseIdentity(2);
            Matrix<double> Hk = Matrix<double>.Build.DenseIdentity(2);
            double ak;
            LoggerEvs.writeLog(string.Format("Input data. Start point {0}, epsilon {1:N5}", basicX, eps));
        step1:
            LoggerEvs.writeLog(string.Format("Step 1: K = 0"));
            int k = 0;
        step2:
            LoggerEvs.writeLog(string.Format("Step 2: ITERATION number {0}", k));
            Vector2 gradTemp = CountRightScheme.Instance.countDerivative(alpha, new Vector2(xk[0,0],xk[1,0]), taskFunction);
            grad[0, 0] = gradTemp.X;
            grad[1, 0] = gradTemp.Y;
        step3:
            if (Math.Sqrt(grad[0,0]*grad[0,0]+grad[1,0]*grad[1,0]) <= eps)
            {
                LoggerEvs.writeLog(string.Format("Step 3: End of searching. Final values: Function = {0}, Point = {1}. Go to step 12.", taskFunction(new Vector2(xk[0, 0], xk[1, 0])), xk));
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
            Vector2 ykTemp = CountRightScheme.Instance.countDerivative(alpha, new Vector2(xk[0,0],xk[1,0]), taskFunction) - CountRightScheme.Instance.countDerivative(alpha, new Vector2(xk_1[0,0],xk_1[1,0]), taskFunction);
            yk[0,0] = ykTemp.X;
            yk[1,0] = ykTemp.Y;
            LoggerEvs.writeLog(string.Format("Step 6: Yk = {0}", yk));
        step7:
            Hk_1 = Hk;
            Matrix<double> firstUp =  Hk_1*yk*yk.TransposeThisAndMultiply(Hk_1);//Vector2.multiplieTransp(Hk_1 * yk, yk) * Hk_1;
            Matrix<double> firstDown = yk*yk.TransposeThisAndMultiply(Hk_1); //Vector2.multiplieTransp(yk, Matrix.multiplieTransp(Hk_1, yk));
            Matrix<double> secondUp = sk*sk.Transpose();//Vector2.multiplieTransp(sk, sk);
            Matrix<double> secondDown =  yk*yk.Transpose() ;//Vector2.multiplieTransp(sk, yk);
            Hk = Hk_1 - firstUp * firstDown.Inverse() + secondUp * secondDown.Inverse();
            LoggerEvs.writeLog(string.Format("Step 7: Quasi-Newton matrix: \r\n{0}", Hk));
        step8:
            Vector2 tempPk = CountRightScheme.Instance.countDerivative(alpha, new Vector2(xk[0, 0], xk[1, 0]), taskFunction);
            Matrix<double> azaza = Matrix<double>.Build.Dense(2, 1, 0);
            azaza[0, 0] = tempPk.X;
            azaza[1, 0] = tempPk.Y;
            pk = -Hk * azaza;
            
            LoggerEvs.writeLog(string.Format("Step 8: Search vector: {0}", pk));
        step9:
            Matrix<double> tmpxk = xk + alpha * pk;
            Vector2 gradientValue = CountRightScheme.Instance.countDerivative(alpha, new Vector2(tmpxk[0, 0], tmpxk[1, 0]), taskFunction);
            Interval alphaValues = DSKMethodCounter.countInterval(taskFunction, alpha, new Vector2(tmpxk[0, 0], tmpxk[1, 0]), gradientValue, eps);
            
            alpha = DichotomyMethodCounter.findMinimum(taskFunction, alphaValues, eps, new Vector2(tmpxk[0, 0], tmpxk[1, 0]), gradientValue);
            LoggerEvs.writeLog(string.Format("Step 9: New alpha {0}", alpha));
        step10:
            xk_1 = xk;
            xk = xk + alpha * pk;//??
            LoggerEvs.writeLog(string.Format("Step 10: New local search point {0}", xk));
        step11:
            k++;
            LoggerEvs.writeLog("Step 11: Iteration end.");
            goto step2;
        step12:
            LoggerEvs.writeLog("Step 12: Search is done!");
            Vector2 result = new Vector2(xk[0, 0], xk[1, 0]);
            double sss = taskFunction(new Vector2(0.003, -0.05));
            return result;
        }

        public Vector2 returnApproximateSolution(Vector2 x, double eps, Func<Vector2, double> taskFunction)
        {
            setStartingVariables(x, eps);
            return calculate(taskFunction);
        }
    }
}
