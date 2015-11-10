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
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCountOGM_Click(object sender, EventArgs e)
        {
            Vector2 h = new Vector2((double)nudHX1.Value, (double)nudHX2.Value);
            Vector2 args = new Vector2((double)nudStartX1.Value, (double)nudStartX2.Value);
            Vector2 answer = OptimalGradientMethod.findMinimum(args, h, (double)nudEps.Value);
            tbOGMAnswer.Text = string.Format("Minimum is here: x* = ({0:N4};{1:N4})", answer.X, answer.Y);
        }

        private void DFPCalculateButton_Click(object sender, EventArgs e)
        {

        }        
    }
}
