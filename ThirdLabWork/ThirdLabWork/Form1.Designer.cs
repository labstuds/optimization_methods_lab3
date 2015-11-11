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
            this.btnCountOGM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOGMAnswer = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudEps = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudStartX2 = new System.Windows.Forms.NumericUpDown();
            this.nudStartX1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DFPCalculateButton = new System.Windows.Forms.Button();
            this.DFPMethodAnswerLabel = new System.Windows.Forms.Label();
            this.DFPMethodEpsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DFPMethodX1Numeric = new System.Windows.Forms.NumericUpDown();
            this.DFPMethodX0Numeric = new System.Windows.Forms.NumericUpDown();
            this.gbCountMethods = new System.Windows.Forms.GroupBox();
            this.gbCountProcess = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudDichoEps = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDSKStep = new System.Windows.Forms.NumericUpDown();
            this.gbMinimizationParams = new System.Windows.Forms.GroupBox();
            this.tcOGM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodEpsNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX0Numeric)).BeginInit();
            this.gbCountMethods.SuspendLayout();
            this.gbCountProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDichoEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDSKStep)).BeginInit();
            this.gbMinimizationParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcOGM
            // 
            this.tcOGM.Controls.Add(this.tabPage1);
            this.tcOGM.Controls.Add(this.tabPage2);
            this.tcOGM.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcOGM.Location = new System.Drawing.Point(3, 16);
            this.tcOGM.Name = "tcOGM";
            this.tcOGM.SelectedIndex = 0;
            this.tcOGM.Size = new System.Drawing.Size(405, 171);
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
            this.tabPage1.Size = new System.Drawing.Size(397, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оптимальный градиентный метод (2.2.1)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCountOGM
            // 
            this.btnCountOGM.Location = new System.Drawing.Point(7, 119);
            this.btnCountOGM.Name = "btnCountOGM";
            this.btnCountOGM.Size = new System.Drawing.Size(113, 23);
            this.btnCountOGM.TabIndex = 5;
            this.btnCountOGM.Text = "Рассчитать";
            this.btnCountOGM.UseVisualStyleBackColor = true;
            this.btnCountOGM.Click += new System.EventHandler(this.btnCountOGM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ответ:";
            // 
            // tbOGMAnswer
            // 
            this.tbOGMAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOGMAnswer.Location = new System.Drawing.Point(176, 121);
            this.tbOGMAnswer.Name = "tbOGMAnswer";
            this.tbOGMAnswer.ReadOnly = true;
            this.tbOGMAnswer.Size = new System.Drawing.Size(212, 20);
            this.tbOGMAnswer.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudEps);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(261, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 99);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Точность";
            // 
            // nudEps
            // 
            this.nudEps.DecimalPlaces = 10;
            this.nudEps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEps.Location = new System.Drawing.Point(6, 69);
            this.nudEps.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.nudEps.Name = "nudEps";
            this.nudEps.Size = new System.Drawing.Size(112, 20);
            this.nudEps.TabIndex = 9;
            this.nudEps.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Epsilon";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudH);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(126, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 99);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Начальный шаг";
            // 
            // nudH
            // 
            this.nudH.DecimalPlaces = 10;
            this.nudH.Location = new System.Drawing.Point(7, 69);
            this.nudH.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(116, 20);
            this.nudH.TabIndex = 7;
            this.nudH.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Шаг alpha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudStartX2);
            this.groupBox3.Controls.Add(this.nudStartX1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Начальная точка";
            // 
            // nudStartX2
            // 
            this.nudStartX2.DecimalPlaces = 2;
            this.nudStartX2.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudStartX2.Location = new System.Drawing.Point(38, 70);
            this.nudStartX2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudStartX2.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudStartX2.Name = "nudStartX2";
            this.nudStartX2.Size = new System.Drawing.Size(66, 20);
            this.nudStartX2.TabIndex = 3;
            // 
            // nudStartX1
            // 
            this.nudStartX1.DecimalPlaces = 2;
            this.nudStartX1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudStartX1.Location = new System.Drawing.Point(38, 18);
            this.nudStartX1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudStartX1.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudStartX1.Name = "nudStartX1";
            this.nudStartX1.Size = new System.Drawing.Size(66, 20);
            this.nudStartX1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DFPCalculateButton);
            this.tabPage2.Controls.Add(this.DFPMethodAnswerLabel);
            this.tabPage2.Controls.Add(this.DFPMethodEpsNumeric);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 145);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2.2.3. Метод переменной метрики Дэвидона-Флетчера-Пауэлла ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DFPCalculateButton
            // 
            this.DFPCalculateButton.Location = new System.Drawing.Point(12, 115);
            this.DFPCalculateButton.Name = "DFPCalculateButton";
            this.DFPCalculateButton.Size = new System.Drawing.Size(163, 23);
            this.DFPCalculateButton.TabIndex = 4;
            this.DFPCalculateButton.Text = "Произвести рассчеты";
            this.DFPCalculateButton.UseVisualStyleBackColor = true;
            this.DFPCalculateButton.Click += new System.EventHandler(this.DFPCalculateButton_Click);
            // 
            // DFPMethodAnswerLabel
            // 
            this.DFPMethodAnswerLabel.AutoSize = true;
            this.DFPMethodAnswerLabel.Location = new System.Drawing.Point(178, 120);
            this.DFPMethodAnswerLabel.Name = "DFPMethodAnswerLabel";
            this.DFPMethodAnswerLabel.Size = new System.Drawing.Size(158, 13);
            this.DFPMethodAnswerLabel.TabIndex = 3;
            this.DFPMethodAnswerLabel.Text = "Здесь будет отображен ответ";
            // 
            // DFPMethodEpsNumeric
            // 
            this.DFPMethodEpsNumeric.DecimalPlaces = 5;
            this.DFPMethodEpsNumeric.Location = new System.Drawing.Point(181, 22);
            this.DFPMethodEpsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DFPMethodEpsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.DFPMethodEpsNumeric.Name = "DFPMethodEpsNumeric";
            this.DFPMethodEpsNumeric.Size = new System.Drawing.Size(109, 20);
            this.DFPMethodEpsNumeric.TabIndex = 2;
            this.DFPMethodEpsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Точность ɛ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DFPMethodX1Numeric);
            this.groupBox1.Controls.Add(this.DFPMethodX0Numeric);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальная точка поиска";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "X1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "X0";
            // 
            // DFPMethodX1Numeric
            // 
            this.DFPMethodX1Numeric.DecimalPlaces = 5;
            this.DFPMethodX1Numeric.Location = new System.Drawing.Point(6, 77);
            this.DFPMethodX1Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DFPMethodX1Numeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.DFPMethodX1Numeric.Name = "DFPMethodX1Numeric";
            this.DFPMethodX1Numeric.Size = new System.Drawing.Size(109, 20);
            this.DFPMethodX1Numeric.TabIndex = 4;
            // 
            // DFPMethodX0Numeric
            // 
            this.DFPMethodX0Numeric.DecimalPlaces = 5;
            this.DFPMethodX0Numeric.Location = new System.Drawing.Point(6, 32);
            this.DFPMethodX0Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DFPMethodX0Numeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.DFPMethodX0Numeric.Name = "DFPMethodX0Numeric";
            this.DFPMethodX0Numeric.Size = new System.Drawing.Size(109, 20);
            this.DFPMethodX0Numeric.TabIndex = 3;
            // 
            // gbCountMethods
            // 
            this.gbCountMethods.Controls.Add(this.gbMinimizationParams);
            this.gbCountMethods.Controls.Add(this.tcOGM);
            this.gbCountMethods.Location = new System.Drawing.Point(12, 12);
            this.gbCountMethods.Name = "gbCountMethods";
            this.gbCountMethods.Size = new System.Drawing.Size(625, 190);
            this.gbCountMethods.TabIndex = 1;
            this.gbCountMethods.TabStop = false;
            this.gbCountMethods.Text = "Методы вычислений";
            // 
            // gbCountProcess
            // 
            this.gbCountProcess.Controls.Add(this.rtbLog);
            this.gbCountProcess.Location = new System.Drawing.Point(12, 208);
            this.gbCountProcess.Name = "gbCountProcess";
            this.gbCountProcess.Size = new System.Drawing.Size(625, 146);
            this.gbCountProcess.TabIndex = 2;
            this.gbCountProcess.TabStop = false;
            this.gbCountProcess.Text = "Ход вычислений";
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(3, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(619, 127);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Eps для дихотомии";
            // 
            // nudDichoEps
            // 
            this.nudDichoEps.DecimalPlaces = 10;
            this.nudDichoEps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDichoEps.Location = new System.Drawing.Point(36, 68);
            this.nudDichoEps.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDichoEps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.nudDichoEps.Name = "nudDichoEps";
            this.nudDichoEps.Size = new System.Drawing.Size(122, 20);
            this.nudDichoEps.TabIndex = 11;
            this.nudDichoEps.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(32, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Шаг h для ДСК";
            // 
            // nudDSKStep
            // 
            this.nudDSKStep.DecimalPlaces = 10;
            this.nudDSKStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDSKStep.Location = new System.Drawing.Point(36, 139);
            this.nudDSKStep.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDSKStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.nudDSKStep.Name = "nudDSKStep";
            this.nudDSKStep.Size = new System.Drawing.Size(122, 20);
            this.nudDSKStep.TabIndex = 13;
            this.nudDSKStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // gbMinimizationParams
            // 
            this.gbMinimizationParams.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMinimizationParams.Controls.Add(this.label10);
            this.gbMinimizationParams.Controls.Add(this.nudDSKStep);
            this.gbMinimizationParams.Controls.Add(this.label9);
            this.gbMinimizationParams.Controls.Add(this.nudDichoEps);
            this.gbMinimizationParams.Location = new System.Drawing.Point(414, 16);
            this.gbMinimizationParams.Name = "gbMinimizationParams";
            this.gbMinimizationParams.Size = new System.Drawing.Size(205, 167);
            this.gbMinimizationParams.TabIndex = 14;
            this.gbMinimizationParams.TabStop = false;
            this.gbMinimizationParams.Text = "Параметры для метода одномерной минимазации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 368);
            this.Controls.Add(this.gbCountProcess);
            this.Controls.Add(this.gbCountMethods);
            this.MaximumSize = new System.Drawing.Size(662, 407);
            this.MinimumSize = new System.Drawing.Size(662, 407);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.tcOGM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodEpsNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX0Numeric)).EndInit();
            this.gbCountMethods.ResumeLayout(false);
            this.gbCountProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDichoEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDSKStep)).EndInit();
            this.gbMinimizationParams.ResumeLayout(false);
            this.gbMinimizationParams.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudStartX2;
        private System.Windows.Forms.NumericUpDown nudStartX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbCountMethods;
        private System.Windows.Forms.GroupBox gbCountProcess;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DFPCalculateButton;
        private System.Windows.Forms.Label DFPMethodAnswerLabel;
        private System.Windows.Forms.NumericUpDown DFPMethodEpsNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DFPMethodX1Numeric;
        private System.Windows.Forms.NumericUpDown DFPMethodX0Numeric;
        private System.Windows.Forms.NumericUpDown nudDichoEps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudDSKStep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbMinimizationParams;
    }
}

