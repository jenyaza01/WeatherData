namespace Weatherdata
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bT = new System.Windows.Forms.Button();
            this.bP = new System.Windows.Forms.Button();
            this.bH = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bL = new System.Windows.Forms.Button();
            this.bDM = new System.Windows.Forms.Button();
            this.bI = new System.Windows.Forms.Button();
            this.bDL = new System.Windows.Forms.Button();
            this.bDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            //
            // chart1
            //
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.LabelStyle.Format = "HH:mm";
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(-20, 0);
            this.chart1.Name = "chart1";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.MarkerSize = 6;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series10.Name = "Temperature";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Green;
            series11.MarkerSize = 6;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series11.Name = "Pressure";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.MarkerSize = 6;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series12.Name = "Humidity";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Firebrick;
            series13.MarkerSize = 6;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series13.Name = "CO2";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Orange;
            series14.MarkerSize = 6;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series14.Name = "Brightness";
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Name = "DustSmall";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.SeaGreen;
            series16.MarkerSize = 6;
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series16.Name = "DustMed";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Name = "DustLarge";
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series18.BorderWidth = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.RoyalBlue;
            series18.MarkerSize = 6;
            series18.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series18.Name = "Ion";
            series18.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Size = new System.Drawing.Size(737, 446);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            //
            // bT
            //
            this.bT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bT.Location = new System.Drawing.Point(716, 61);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(85, 23);
            this.bT.TabIndex = 1;
            this.bT.Text = "Температура";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.bT_Click);
            //
            // bP
            //
            this.bP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bP.Location = new System.Drawing.Point(716, 90);
            this.bP.Name = "bP";
            this.bP.Size = new System.Drawing.Size(85, 23);
            this.bP.TabIndex = 2;
            this.bP.Text = "Тиск";
            this.bP.UseVisualStyleBackColor = true;
            this.bP.Click += new System.EventHandler(this.bP_Click);
            //
            // bH
            //
            this.bH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bH.Location = new System.Drawing.Point(716, 119);
            this.bH.Name = "bH";
            this.bH.Size = new System.Drawing.Size(85, 23);
            this.bH.TabIndex = 3;
            this.bH.Text = "Вологість";
            this.bH.UseVisualStyleBackColor = true;
            this.bH.Click += new System.EventHandler(this.bH_Click);
            //
            // bC
            //
            this.bC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bC.Location = new System.Drawing.Point(716, 148);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(85, 23);
            this.bC.TabIndex = 4;
            this.bC.Text = "СO2";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            //
            // bL
            //
            this.bL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bL.Location = new System.Drawing.Point(716, 177);
            this.bL.Name = "bL";
            this.bL.Size = new System.Drawing.Size(85, 23);
            this.bL.TabIndex = 5;
            this.bL.Text = "Освітленість";
            this.bL.UseVisualStyleBackColor = true;
            this.bL.Click += new System.EventHandler(this.bL_Click);
            //
            // bDM
            //
            this.bDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDM.Location = new System.Drawing.Point(716, 235);
            this.bDM.Name = "bDM";
            this.bDM.Size = new System.Drawing.Size(85, 23);
            this.bDM.TabIndex = 6;
            this.bDM.Text = "Середній пил";
            this.bDM.UseVisualStyleBackColor = true;
            this.bDM.Click += new System.EventHandler(this.bDM_Click);
            //
            // bI
            //
            this.bI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bI.Location = new System.Drawing.Point(716, 293);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(85, 23);
            this.bI.TabIndex = 7;
            this.bI.Text = "Іони";
            this.bI.UseVisualStyleBackColor = true;
            this.bI.Click += new System.EventHandler(this.bI_Click);
            //
            // bDL
            //
            this.bDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDL.Location = new System.Drawing.Point(716, 264);
            this.bDL.Name = "bDL";
            this.bDL.Size = new System.Drawing.Size(85, 23);
            this.bDL.TabIndex = 8;
            this.bDL.Text = "Великий пил";
            this.bDL.UseVisualStyleBackColor = true;
            this.bDL.Click += new System.EventHandler(this.bDL_Click);
            //
            // bDS
            //
            this.bDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDS.Location = new System.Drawing.Point(716, 206);
            this.bDS.Name = "bDS";
            this.bDS.Size = new System.Drawing.Size(85, 23);
            this.bDS.TabIndex = 9;
            this.bDS.Text = "Дрібний пил";
            this.bDS.UseVisualStyleBackColor = true;
            this.bDS.Click += new System.EventHandler(this.bDS_Click);
            //
            // FormChart
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDS);
            this.Controls.Add(this.bDL);
            this.Controls.Add(this.bI);
            this.Controls.Add(this.bDM);
            this.Controls.Add(this.bL);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bH);
            this.Controls.Add(this.bP);
            this.Controls.Add(this.bT);
            this.Controls.Add(this.chart1);
            this.Name = "FormChart";
            this.Text = "Chart - Temperature";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.Button bP;
        private System.Windows.Forms.Button bH;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bL;
		private System.Windows.Forms.Button bDM;
		private System.Windows.Forms.Button bI;
        private System.Windows.Forms.Button bDL;
        private System.Windows.Forms.Button bDS;
    }
}
