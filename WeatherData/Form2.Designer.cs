﻿namespace Weatherdata
{
    partial class Form2
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.AxisY.IsStartedFromZero = false;
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			this.chart1.Location = new System.Drawing.Point(-20, 0);
			this.chart1.Name = "chart1";
			series17.BorderWidth = 2;
			series17.ChartArea = "ChartArea1";
			series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series17.Color = System.Drawing.Color.Red;
			series17.Name = "Temperature";
			series18.ChartArea = "ChartArea1";
			series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			series18.Name = "Pressure";
			series19.ChartArea = "ChartArea1";
			series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series19.Color = System.Drawing.Color.Blue;
			series19.Name = "Humidity";
			series20.ChartArea = "ChartArea1";
			series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series20.Color = System.Drawing.Color.Magenta;
			series20.Name = "CO2";
			series21.ChartArea = "ChartArea1";
			series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series21.Name = "Brightness";
			series22.ChartArea = "ChartArea1";
			series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series22.Name = "Dust";
			series23.ChartArea = "ChartArea1";
			series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series23.Name = "Ion";
			series24.ChartArea = "ChartArea1";
			series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series24.Name = "A0";
			this.chart1.Series.Add(series17);
			this.chart1.Series.Add(series18);
			this.chart1.Series.Add(series19);
			this.chart1.Series.Add(series20);
			this.chart1.Series.Add(series21);
			this.chart1.Series.Add(series22);
			this.chart1.Series.Add(series23);
			this.chart1.Series.Add(series24);
			this.chart1.Size = new System.Drawing.Size(761, 446);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(716, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Температура";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(716, 90);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Тиск";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(716, 119);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Вологість";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(716, 148);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(85, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "СO2";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(716, 177);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(85, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "Яскравість";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(716, 206);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(85, 23);
			this.button6.TabIndex = 6;
			this.button6.Text = "Пил";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Location = new System.Drawing.Point(716, 235);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(85, 23);
			this.button7.TabIndex = 7;
			this.button7.Text = "Іони";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chart1);
			this.Name = "Form2";
			this.Text = "Chart - Temperature";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
	}
}