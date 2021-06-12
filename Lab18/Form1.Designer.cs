namespace Lab18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edNumber = new System.Windows.Forms.NumericUpDown();
            this.edT = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edLambda = new System.Windows.Forms.NumericUpDown();
            this.edMu = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.edOperators = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOperators)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // edNumber
            // 
            this.edNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edNumber.Location = new System.Drawing.Point(122, 7);
            this.edNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edNumber.Name = "edNumber";
            this.edNumber.Size = new System.Drawing.Size(47, 20);
            this.edNumber.TabIndex = 3;
            this.edNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // edT
            // 
            this.edT.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edT.Location = new System.Drawing.Point(122, 59);
            this.edT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edT.Name = "edT";
            this.edT.Size = new System.Drawing.Size(47, 20);
            this.edT.TabIndex = 4;
            this.edT.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "lyambda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "mu";
            // 
            // edLambda
            // 
            this.edLambda.DecimalPlaces = 2;
            this.edLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edLambda.Location = new System.Drawing.Point(246, 7);
            this.edLambda.Name = "edLambda";
            this.edLambda.Size = new System.Drawing.Size(47, 20);
            this.edLambda.TabIndex = 7;
            this.edLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edMu
            // 
            this.edMu.DecimalPlaces = 2;
            this.edMu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edMu.Location = new System.Drawing.Point(246, 33);
            this.edMu.Name = "edMu";
            this.edMu.Size = new System.Drawing.Size(47, 20);
            this.edMu.TabIndex = 8;
            this.edMu.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 88);
            this.chart1.Name = "chart1";
            series1.BackSecondaryColor = System.Drawing.Color.Gray;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Empirical Data";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Theoretical Data";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(714, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of operators";
            // 
            // edOperators
            // 
            this.edOperators.Location = new System.Drawing.Point(122, 33);
            this.edOperators.Name = "edOperators";
            this.edOperators.Size = new System.Drawing.Size(47, 20);
            this.edOperators.TabIndex = 13;
            this.edOperators.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 393);
            this.Controls.Add(this.edOperators);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.edMu);
            this.Controls.Add(this.edLambda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edT);
            this.Controls.Add(this.edNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOperators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edNumber;
        private System.Windows.Forms.NumericUpDown edT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edLambda;
        private System.Windows.Forms.NumericUpDown edMu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edOperators;
    }
}

