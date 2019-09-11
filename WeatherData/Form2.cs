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

		private void Form2_Load(object sender, EventArgs e)
		{
			ShowChart(0);
			button1.Focus();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Hide();
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

		private void button1_Click(object sender, EventArgs e)
		{
			ShowChart(0);
			Text = "Chart - Temperature";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ShowChart(1);
			Text = "Chart - Pressure";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ShowChart(2);
			Text = "Chart - Humidity";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ShowChart(3);
			Text = "Chart - CO2";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ShowChart(4);
			Text = "Chart - Brightness";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int[] q = new int[] {5};
			ShowChart(q);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			ShowChart(6);
		}
	}
}
