using System;
using System.Windows.Forms;

namespace Weatherdata
{
	public partial class FormSettings : Form
	{

		//y = Ax + B
		public float TempFixA = 1f, TempFixB = 0f;
		public float HumdFixA = 1f, HumdFixB = 0f;
		public float PresFixA = 1f, PresFixB = 0f;
		public float BrtnFixA = 1f, BrtnFixB = 0f;
		public float CO2FixA = 1f, CO2FixB = 0f;
		public float IonFixA = 1f, IonFixB = 0f;




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

		private void FixChanged(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			string s = tb.Text.Replace(".", ",");
			switch (tb.Name)
			{
				case "TempA": TempFixA = Single.Parse(s); break;
				case "TempB": TempFixB = Single.Parse(s); break;

				case "HumdA": HumdFixA = Single.Parse(s); break;
				case "HumdB": HumdFixB = Single.Parse(s); break;

				case "PresA": PresFixA = Single.Parse(s); break;
				case "PresB": PresFixB = Single.Parse(s); break;

				case "BrtnA": BrtnFixA = Single.Parse(s); break;
				case "BrtnB": BrtnFixB = Single.Parse(s); break;

				case "CO2A": CO2FixA = Single.Parse(s); break;
				case "CO2B": CO2FixB = Single.Parse(s); break;

				case "IonA": IonFixA = Single.Parse(s); break;
				case "IonB": IonFixB = Single.Parse(s); break;

				default: throw new NotImplementedException($"Name {tb.Name} unlisted here");
			}

		}

		private volatile int measureTimeMinutes = 0;
		private void bMeasureTime_Click(object sender, EventArgs e)
		{
			if (radioButtonMinutes2.Checked)
				measureTimeMinutes = (int)numMeasureTime.Value;
			else measureTimeMinutes = (int)numMeasureTime.Value * 60;
			parentForm.comSend("E1"); //enable, in case it was disabled
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (measureTimeMinutes == 1)
			{
				parentForm.comSend("E0"); //disable sending
				timer1.Stop();
			}
			measureTimeMinutes--;
			var hours = measureTimeMinutes / 60;
			var min = measureTimeMinutes - (hours * 60);
			bMeasureTime.Text = $"Встановити ({hours}:{min})";
		}

		private int reloadTime;
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonSeconds.Checked)
				if (numRefRate.Value < 15)
					numRefRate.Value = 15;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (radioButtonSeconds.Checked)
				if (numRefRate.Value < 15)
					numRefRate.Value = 15;
		}

		public Form1 parentForm;
		private void SendReloadPeriod()
		{
			reloadTime = (int)numRefRate.Value;
			if (radioButtMinutes.Checked)
				reloadTime *= 60;
			parentForm.comSend("R" + reloadTime.ToString());
		}

		private void bRefRate_Click(object sender, EventArgs e)
		{
			SendReloadPeriod();
			string s = radioButtMinutes.Checked ? "хв" : "сек";
			bRefRate.Text = $"Встановити ({numRefRate.Value} {s})";
		}
	}
}
