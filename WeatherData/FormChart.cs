using System;
using System.Windows.Forms;

namespace Weatherdata
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            this.InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ShowChart(0);
            bT.Focus();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public bool updateChartButtons()
        {
            bool hasPoints = false;
            if (chart1.Series["Temperature"].Points.Count > 0)
            {
                bT.Enabled = true;
                hasPoints = true;
            }
            else
                bT.Enabled = false;

            if (chart1.Series["Pressure"].Points.Count > 0)
            {
                bP.Enabled = true;
                hasPoints = true;
            }
            else
                bP.Enabled = false;

            if (chart1.Series["Humidity"].Points.Count > 0)
            {
                bH.Enabled = true;
                hasPoints = true;
            }
            else
                bH.Enabled = false;

            if (chart1.Series["CO2"].Points.Count > 0)
            {
                bC.Enabled = true;
                hasPoints = true;
            }
            else
                bC.Enabled = false;

            if (chart1.Series["Brightness"].Points.Count > 0)
            {
                bL.Enabled = true;
                hasPoints = true;
            }
            else
                bL.Enabled = false;

            if (chart1.Series["DustSmall"].Points.Count > 0)
            {
                bDS.Enabled = true;
                hasPoints = true;
            }
            else
                bDS.Enabled = false;

            if (chart1.Series["DustMed"].Points.Count > 0)
            {
                bDM.Enabled = true;
                hasPoints = true;
            }
            else
                bDM.Enabled = true;

            if (chart1.Series["DustLarge"].Points.Count > 0)
            {
                bDL.Enabled = true;
                hasPoints = true;
            }
            else
                bDL.Enabled = false;

            if (chart1.Series["Ion"].Points.Count > 0)
            {
                bI.Enabled = true;
                hasPoints = true;
            }
            else
                bI.Enabled = false;

            return hasPoints;
        }

        private void ShowChart(int[] ser)
        {
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                for (int j = 0; j < ser.Length; j++)
                {
                    chart1.Series[i].Enabled = (ser[j] == i) ? true : false;
                }
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowChart(int ser)
        {
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                chart1.Series[i].Enabled = (ser == i) ? true : false;
            }
            chart1.ChartAreas[0].RecalculateAxesScale();

        }

        private void bT_Click(object sender, EventArgs e)
        {
            this.ShowChart(0);
            Text = "Chart - Temperature";
        }

        private void bP_Click(object sender, EventArgs e)
        {
            this.ShowChart(1);
            Text = "Chart - Pressure";
        }

        private void bH_Click(object sender, EventArgs e)
        {
            this.ShowChart(2);
            Text = "Chart - Humidity";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            this.ShowChart(3);
            Text = "Chart - CO2";
        }

        private void bL_Click(object sender, EventArgs e)
        {
            this.ShowChart(4);
            Text = "Chart - Brightness";
        }

        private void bDS_Click(object sender, EventArgs e)
        {
            this.ShowChart(5);
            Text = "Chart - Small Dust";
        }

        private void bDM_Click(object sender, EventArgs e)
        {
            this.ShowChart(6);
            Text = "Chart - Medium Dust";
        }

        private void bDL_Click(object sender, EventArgs e)
        {
            this.ShowChart(7);
            Text = "Chart - Large Dust";
        }

        private void bI_Click(object sender, EventArgs e)
        {
            this.ShowChart(8);
            Text = "Chart - Ion";
        }
    }
}
