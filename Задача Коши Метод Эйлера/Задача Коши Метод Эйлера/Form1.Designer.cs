namespace Задача_Коши_Метод_Эйлера
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x0 = new System.Windows.Forms.NumericUpDown();
            this.y0 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1, 1);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "График диф.уравнения";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1025, 445);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // x0
            // 
            this.x0.Location = new System.Drawing.Point(33, 492);
            this.x0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(100, 22);
            this.x0.TabIndex = 2;
            // 
            // y0
            // 
            this.y0.Location = new System.Drawing.Point(192, 492);
            this.y0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y0.Name = "y0";
            this.y0.Size = new System.Drawing.Size(100, 22);
            this.y0.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "x0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 464);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "y0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 464);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Количество итераций";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(372, 492);
            this.n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 22);
            this.n.TabIndex = 7;
            this.n.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 586);
            this.Controls.Add(this.n);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.y0);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown x0;
        private System.Windows.Forms.NumericUpDown y0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown n;
    }
}

