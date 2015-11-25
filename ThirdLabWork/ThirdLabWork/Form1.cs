using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThirdLabWork
{
    public partial class Form1 : Form
    {
        
        private DFPSolver DFPCalculator;
        public Form1()
        {
            InitializeComponent();
            LoggerEvs.messageCame += addLogNoteToWidget;
            DFPCalculator = new DFPSolver();
        }

        private void addLogNoteToWidget(string logNote)
        {
            rtbLog.AppendText(logNote);
            rtbLog.ScrollToCaret();
        }

        private void btnCountOGM_Click(object sender, EventArgs e)
        {
            double h = (double)nudH.Value;  // Начальный шаг
            // Начальные аргументы функции (x1 и x2)
            Vector2 args = new Vector2((double)nudStartX1.Value, (double)nudStartX2.Value);
            // Точка, в которой функция принимает минимальное значение, расчет
            Vector2 answer = OptimalGradientMethod.findMinimum(args, h, (double)nudEps.Value, taskFunction, (double)nudDichoEps.Value, (double)nudDSKStep.Value);
            // Вывод результата расчетов
            string funcValue = taskFunction(answer).ToString("N3");
            tbOGMAnswer.Text = string.Format("Function f({0:N3};{1:N3}) = {2}", answer.X, answer.Y, funcValue);
        }

        private void DFPCalculateButton_Click(object sender, EventArgs e)
        {
            // h для DSK
            double h = (double)nudDSKStep.Value;
            // Eps для Дихотомии
            double epsDich = (double)nudDichoEps.Value;

            Vector2 result = DFPCalculator.returnApproximateSolution(new Vector2((double)this.DFPMethodX0Numeric.Value, (double)this.DFPMethodX1Numeric.Value), (double)this.DFPMethodEpsNumeric.Value, taskFunction, h, epsDich);
            DFPMethodAnswerLabel.Text = String.Format("Ответ: Fmin({0})={1:N4}",result,taskFunction(result));
        }

        public static double taskFunction(Vector2 args)
        {
            return Math.Pow(Math.Pow(args.X, 2) + args.Y - 11, 2) + Math.Pow(args.X + Math.Pow(args.Y, 2) - 7, 2);
        }
    }
}
