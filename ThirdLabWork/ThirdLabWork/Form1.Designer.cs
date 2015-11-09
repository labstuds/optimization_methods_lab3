namespace ThirdLabWork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcOGM = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbCountMethods = new System.Windows.Forms.GroupBox();
            this.gbCountProcess = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStartX1 = new System.Windows.Forms.NumericUpDown();
            this.nudStartX2 = new System.Windows.Forms.NumericUpDown();
            this.nudHX2 = new System.Windows.Forms.NumericUpDown();
            this.nudEps = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOGMAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCountOGM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHX1 = new System.Windows.Forms.NumericUpDown();
            this.tcOGM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCountMethods.SuspendLayout();
            this.gbCountProcess.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHX1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOGM
            // 
            this.tcOGM.Controls.Add(this.tabPage1);
            this.tcOGM.Controls.Add(this.tabPage2);
            this.tcOGM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOGM.Location = new System.Drawing.Point(3, 16);
            this.tcOGM.Name = "tcOGM";
            this.tcOGM.SelectedIndex = 0;
            this.tcOGM.Size = new System.Drawing.Size(581, 171);
            this.tcOGM.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCountOGM);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbOGMAnswer);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оптимальный градиентный метод (2.2.1)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbCountMethods
            // 
            this.gbCountMethods.Controls.Add(this.tcOGM);
            this.gbCountMethods.Location = new System.Drawing.Point(12, 12);
            this.gbCountMethods.Name = "gbCountMethods";
            this.gbCountMethods.Size = new System.Drawing.Size(587, 190);
            this.gbCountMethods.TabIndex = 1;
            this.gbCountMethods.TabStop = false;
            this.gbCountMethods.Text = "Методы вычислений";
            // 
            // gbCountProcess
            // 
            this.gbCountProcess.Controls.Add(this.rtbLog);
            this.gbCountProcess.Location = new System.Drawing.Point(12, 208);
            this.gbCountProcess.Name = "gbCountProcess";
            this.gbCountProcess.Size = new System.Drawing.Size(587, 146);
            this.gbCountProcess.TabIndex = 2;
            this.gbCountProcess.TabStop = false;
            this.gbCountProcess.Text = "Ход вычислений";
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(3, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(581, 127);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudStartX2);
            this.groupBox3.Controls.Add(this.nudStartX1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 75);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Начальная точка";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudHX1);
            this.groupBox4.Controls.Add(this.nudHX2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(212, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 75);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Начальный шаг";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudEps);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(419, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 74);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Точность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
            // 
            // nudStartX1
            // 
            this.nudStartX1.DecimalPlaces = 2;
            this.nudStartX1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStartX1.Location = new System.Drawing.Point(74, 20);
            this.nudStartX1.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudStartX1.Minimum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            -2147483648});
            this.nudStartX1.Name = "nudStartX1";
            this.nudStartX1.Size = new System.Drawing.Size(120, 20);
            this.nudStartX1.TabIndex = 2;
            // 
            // nudStartX2
            // 
            this.nudStartX2.DecimalPlaces = 2;
            this.nudStartX2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStartX2.Location = new System.Drawing.Point(74, 46);
            this.nudStartX2.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudStartX2.Minimum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            -2147483648});
            this.nudStartX2.Name = "nudStartX2";
            this.nudStartX2.Size = new System.Drawing.Size(120, 20);
            this.nudStartX2.TabIndex = 3;
            // 
            // nudHX2
            // 
            this.nudHX2.DecimalPlaces = 5;
            this.nudHX2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHX2.Location = new System.Drawing.Point(72, 49);
            this.nudHX2.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudHX2.Name = "nudHX2";
            this.nudHX2.Size = new System.Drawing.Size(122, 20);
            this.nudHX2.TabIndex = 6;
            // 
            // nudEps
            // 
            this.nudEps.DecimalPlaces = 4;
            this.nudEps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEps.Location = new System.Drawing.Point(6, 45);
            this.nudEps.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEps.Name = "nudEps";
            this.nudEps.Size = new System.Drawing.Size(136, 20);
            this.nudEps.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Epsilon";
            // 
            // tbOGMAnswer
            // 
            this.tbOGMAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOGMAnswer.Location = new System.Drawing.Point(226, 121);
            this.tbOGMAnswer.Name = "tbOGMAnswer";
            this.tbOGMAnswer.ReadOnly = true;
            this.tbOGMAnswer.Size = new System.Drawing.Size(344, 20);
            this.tbOGMAnswer.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ответ:";
            // 
            // btnCountOGM
            // 
            this.btnCountOGM.Location = new System.Drawing.Point(7, 119);
            this.btnCountOGM.Name = "btnCountOGM";
            this.btnCountOGM.Size = new System.Drawing.Size(157, 23);
            this.btnCountOGM.TabIndex = 5;
            this.btnCountOGM.Text = "Рассчитать";
            this.btnCountOGM.UseVisualStyleBackColor = true;
            this.btnCountOGM.Click += new System.EventHandler(this.btnCountOGM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Шаг h";
            // 
            // nudHX1
            // 
            this.nudHX1.DecimalPlaces = 5;
            this.nudHX1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHX1.Location = new System.Drawing.Point(72, 19);
            this.nudHX1.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudHX1.Name = "nudHX1";
            this.nudHX1.Size = new System.Drawing.Size(122, 20);
            this.nudHX1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 368);
            this.Controls.Add(this.gbCountProcess);
            this.Controls.Add(this.gbCountMethods);
            this.MaximumSize = new System.Drawing.Size(631, 407);
            this.MinimumSize = new System.Drawing.Size(631, 407);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.tcOGM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbCountMethods.ResumeLayout(false);
            this.gbCountProcess.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcOGM;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCountOGM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOGMAnswer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudEps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudHX2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudStartX2;
        private System.Windows.Forms.NumericUpDown nudStartX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbCountMethods;
        private System.Windows.Forms.GroupBox gbCountProcess;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.NumericUpDown nudHX1;
        private System.Windows.Forms.Label label4;
    }
}

