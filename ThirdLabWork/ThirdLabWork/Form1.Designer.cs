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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudStartX2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStartX1 = new System.Windows.Forms.NumericUpDown();
            this.tcOGM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodEpsNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX0Numeric)).BeginInit();
            this.gbCountMethods.SuspendLayout();
            this.gbCountProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX1)).BeginInit();
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
            this.tcOGM.Size = new System.Drawing.Size(614, 122);
            this.tcOGM.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCountOGM);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbOGMAnswer);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оптимальный градиентный метод (2.2.1)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCountOGM
            // 
            this.btnCountOGM.Location = new System.Drawing.Point(6, 66);
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
            this.label6.Location = new System.Drawing.Point(129, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ответ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbOGMAnswer
            // 
            this.tbOGMAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOGMAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOGMAnswer.Location = new System.Drawing.Point(175, 68);
            this.tbOGMAnswer.Name = "tbOGMAnswer";
            this.tbOGMAnswer.ReadOnly = true;
            this.tbOGMAnswer.Size = new System.Drawing.Size(294, 20);
            this.tbOGMAnswer.TabIndex = 3;
            this.tbOGMAnswer.TextChanged += new System.EventHandler(this.tbOGMAnswer_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.nudEps);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(475, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 82);
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
            this.nudEps.Location = new System.Drawing.Point(6, 57);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.nudStartX2);
            this.groupBox3.Controls.Add(this.nudStartX1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 54);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Начальная точка";
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
            this.tabPage2.Size = new System.Drawing.Size(746, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2.2.3. Метод переменной метрики Дэвидона-Флетчера-Пауэлла ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DFPCalculateButton
            // 
            this.DFPCalculateButton.Location = new System.Drawing.Point(6, 62);
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
            this.DFPMethodAnswerLabel.Location = new System.Drawing.Point(178, 67);
            this.DFPMethodAnswerLabel.Name = "DFPMethodAnswerLabel";
            this.DFPMethodAnswerLabel.Size = new System.Drawing.Size(158, 13);
            this.DFPMethodAnswerLabel.TabIndex = 3;
            this.DFPMethodAnswerLabel.Text = "Здесь будет отображен ответ";
            // 
            // DFPMethodEpsNumeric
            // 
            this.DFPMethodEpsNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DFPMethodEpsNumeric.DecimalPlaces = 5;
            this.DFPMethodEpsNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.DFPMethodEpsNumeric.Location = new System.Drawing.Point(491, 25);
            this.DFPMethodEpsNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            393216});
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
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Точность ɛ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DFPMethodX1Numeric);
            this.groupBox1.Controls.Add(this.DFPMethodX0Numeric);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальная точка поиска";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "X1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "X0";
            // 
            // DFPMethodX1Numeric
            // 
            this.DFPMethodX1Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DFPMethodX1Numeric.DecimalPlaces = 5;
            this.DFPMethodX1Numeric.Location = new System.Drawing.Point(215, 19);
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
            this.DFPMethodX0Numeric.Location = new System.Drawing.Point(29, 19);
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
            this.gbCountMethods.Controls.Add(this.tcOGM);
            this.gbCountMethods.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCountMethods.Location = new System.Drawing.Point(0, 0);
            this.gbCountMethods.Name = "gbCountMethods";
            this.gbCountMethods.Size = new System.Drawing.Size(620, 141);
            this.gbCountMethods.TabIndex = 1;
            this.gbCountMethods.TabStop = false;
            this.gbCountMethods.Text = "Методы вычислений";
            // 
            // gbCountProcess
            // 
            this.gbCountProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCountProcess.Controls.Add(this.rtbLog);
            this.gbCountProcess.Location = new System.Drawing.Point(0, 147);
            this.gbCountProcess.Name = "gbCountProcess";
            this.gbCountProcess.Size = new System.Drawing.Size(617, 204);
            this.gbCountProcess.TabIndex = 2;
            this.gbCountProcess.TabStop = false;
            this.gbCountProcess.Text = "Ход вычислений";
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(3, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(611, 185);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
            // 
            // nudStartX2
            // 
            this.nudStartX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStartX2.DecimalPlaces = 2;
            this.nudStartX2.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudStartX2.Location = new System.Drawing.Point(283, 18);
            this.nudStartX2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStartX2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudStartX2.Name = "nudStartX2";
            this.nudStartX2.Size = new System.Drawing.Size(174, 20);
            this.nudStartX2.TabIndex = 3;
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
            10000,
            0,
            0,
            0});
            this.nudStartX1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudStartX1.Name = "nudStartX1";
            this.nudStartX1.Size = new System.Drawing.Size(174, 20);
            this.nudStartX1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 363);
            this.Controls.Add(this.gbCountProcess);
            this.Controls.Add(this.gbCountMethods);
            this.MinimumSize = new System.Drawing.Size(636, 39);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.tcOGM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodEpsNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DFPMethodX0Numeric)).EndInit();
            this.gbCountMethods.ResumeLayout(false);
            this.gbCountProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbCountMethods;
        private System.Windows.Forms.GroupBox gbCountProcess;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button DFPCalculateButton;
        private System.Windows.Forms.Label DFPMethodAnswerLabel;
        private System.Windows.Forms.NumericUpDown DFPMethodEpsNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DFPMethodX1Numeric;
        private System.Windows.Forms.NumericUpDown DFPMethodX0Numeric;
        private System.Windows.Forms.NumericUpDown nudStartX2;
        private System.Windows.Forms.NumericUpDown nudStartX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

