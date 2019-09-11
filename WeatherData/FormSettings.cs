using System;
using System.Windows.Forms;

namespace Weatherdata
{
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
		}

		private void cTemp_CheckedChanged(object sender, EventArgs e)
		{
			updatePanel();
		}

		private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
		/*
			cbTempPeriod.SelectedIndex = 1;
			cbHumidPeriod.SelectedIndex = 1;
			cbPressPeriod.SelectedIndex = 1;
			cbBrightPeriod.SelectedIndex = 1;
			cbIonPeriod.SelectedIndex = 1;
			cbCO2Period.SelectedIndex = 1;

			cbTempPeriod.Enabled = false;
			cbHumidPeriod.Enabled = false;
			cbPressPeriod.Enabled = false;
			cbBrightPeriod.Enabled = false;
			cbIonPeriod.Enabled = false;
			cbCO2Period.Enabled = false; */
		}

		private void cHumid_CheckedChanged(object sender, EventArgs e)
		{
		//	cbHumidPeriod.Enabled = cHumid.Checked;
			updatePanel();
		}

		private void cPressure_CheckedChanged(object sender, EventArgs e)
		{
		//	cbPressPeriod.Enabled = cPressure.Checked;
			updatePanel();
		}

		private void cBrightness_CheckedChanged(object sender, EventArgs e)
		{
		//	cbBrightPeriod.Enabled = cBrightness.Checked;
			updatePanel();
		}

		private void cCO2_CheckedChanged(object sender, EventArgs e)
		{
		//	cbCO2Period.Enabled = cCO2.Checked;
			updatePanel();
		}

		private void cIon_CheckedChanged(object sender, EventArgs e)
		{
		//	cbIonPeriod.Enabled = cIon.Checked;
			updatePanel();
		}


		public bool isRecordingEnabled = false;
		private void updatePanel()
		{
			if (cTemp.Checked || cHumid.Checked || cPressure.Checked || cBrightness.Checked || cCO2.Checked || cIon.Checked)
			{
				isRecordingEnabled = true;
				Text = "Settings +";
			}
			else
			{
				isRecordingEnabled = false;
				Text = "Settings -";
			}
		}


		int reloadTime;
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
				if (numericUpDown1.Value < 15)
					numericUpDown1.Value = 15;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
				if (numericUpDown1.Value < 15)
					numericUpDown1.Value = 15;
		}

		public Form1 parentForm;
		private void SendReloadPeriod()
		{
			reloadTime = (int)numericUpDown1.Value;
			if (radioButton1.Checked)
				reloadTime *= 60;
			parentForm.comSend(reloadTime.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SendReloadPeriod();
		}
	}
}
