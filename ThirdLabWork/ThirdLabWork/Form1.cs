﻿using System;
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
        

        public Form1()
        {
            InitializeComponent();
            LoggerEvs.messageCame += addLogNoteToWidget;
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
            Vector2 answer = OptimalGradientMethod.findMinimum(args, h, (double)nudEps.Value, taskFunction);
            // Вывод результата расчетов
            tbOGMAnswer.Text = string.Format("Minimum is ({0:N3};{1:N3})", answer.X, answer.Y);
        }

        private void DFPCalculateButton_Click(object sender, EventArgs e)
        {

        }

        public static double taskFunction(Vector2 args)
        {
            return Math.Pow(Math.Pow(args.X, 2) + args.Y - 11, 2) + Math.Pow(args.X + Math.Pow(args.Y, 2) - 7, 2);
        }
    }
}
