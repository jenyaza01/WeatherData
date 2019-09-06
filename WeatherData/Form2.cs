using System;
using System.Windows.Forms;

namespace Weatherdata
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(Object sender, EventArgs e)
        {
            ShowChart(0);
            button1.Focus();
        }

        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ShowChart(int ser)
        {
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[i].Enabled = (ser == i) ? true : false;
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            ShowChart(0);
        }

        private void button2_Click(Object sender, EventArgs e)
        {
            ShowChart(1);
        }

        private void button3_Click(Object sender, EventArgs e)
        {
            ShowChart(2);
        }

        private void button4_Click(Object sender, EventArgs e)
        {
            ShowChart(3);
        }

        private void button5_Click(Object sender, EventArgs e)
        {
            ShowChart(4);
        }
    }
}
