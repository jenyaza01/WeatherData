using System;
using System.Drawing;
using System.Windows.Forms;

namespace Weatherdata
{
	internal partial class FormSettings : Form
	{

		//y = Ax + B, for calibrating
		internal float TempFixA = 1f, TempFixB = 0f;
		internal float HumdFixA = 1f, HumdFixB = 0f;
		internal float PresFixA = 1f, PresFixB = 0f;
		internal float BrtnFixA = 1f, BrtnFixB = 0f;
		internal float CO2FixA = 1f, CO2FixB = 0f;
		internal float IonFixA = 1f, IonFixB = 0f;



		internal FormSettings()
		{
			InitializeComponent();
		}

		private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

		internal bool isRecordingEnabled = false;
		internal bool hasToRecord = false;

		private void UpdHasToRecordState()
		{
			if (cTemp.Checked || cHumid.Checked || cPressure.Checked || cBrightness.Checked || cCO2.Checked || cIon.Checked)
				hasToRecord = true;
			else hasToRecord = false;
			UpdateButtonColor();
		}

		internal void UpdRecordingState()
		{
			if (!isRecordingEnabled && hasToRecord)
			{
				isRecordingEnabled = true;
				UpdateButtonColor();
			}
			else
			{
				isRecordingEnabled = false;
				UpdateButtonColor();
			}
		}

		internal void UpdateButtonColor()
		{
			if (!parentForm.serialPort1.IsOpen)
				bSetMeasureTime.BackColor = Color.DimGray;
			else if (!hasToRecord)
				bSetMeasureTime.BackColor = Color.DarkRed;
			else if (!isRecordingEnabled)
				bSetMeasureTime.BackColor = Color.Salmon;
			else bSetMeasureTime.BackColor = Color.LimeGreen;
		}


		private void FixChanged(object sender, EventArgs e) //apply calibrating
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
		private void bSetMeasureTime_Click(object sender, EventArgs e)
		{
			if (parentForm.serialPort1.IsOpen)
				if (hasToRecord)
					if (!isRecordingEnabled)
					{
						timer1.Stop();
						if (radioButtonMinutes2.Checked)
							measureTimeMinutes = (int)numMeasureTime.Value;
						else measureTimeMinutes = (int)numMeasureTime.Value * 60;

						UpdRecordingState(); // this update isRecordingEnabled to true color to green
						int hours = measureTimeMinutes / 60;
						int min = measureTimeMinutes - (hours * 60);
						bSetMeasureTime.Text = $"Встановити ({hours}:{min})";

						timer1.Start();
					}
					else
					{
						timer1.Stop();
						UpdRecordingState(); // this update isRecordingEnabled to false and color to redish
						bSetMeasureTime.Text = $"Встановити (00:00)";
					}
				else
				{
					isRecordingEnabled = false; // just in case
					MessageBox.Show("Оберіть необхідні покази для запису");
					bSetMeasureTime.Text = $"Встановити (00:00)";
				}
			else
			{
				isRecordingEnabled = false; // just in case
				MessageBox.Show("Не підключено до пристрою через SerialPort");
				bSetMeasureTime.Text = $"Встановити (00:00)";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Width == 630)
				Width = 341;
			else Width = 630;
		}

		private void DataSource_CheckedChanged(object sender, EventArgs e)
		{
			UpdHasToRecordState();
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			UpdateButtonColor();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (measureTimeMinutes == 1)
			{
				UpdRecordingState();
				timer1.Stop();

				if (isRecordingEnabled)
				{
					cTemp.Checked = false;
					cHumid.Checked = false;
					cPressure.Checked = false;
					cBrightness.Checked = false;
					cCO2.Checked = false;
					cIon.Checked = false;
				}
			}
			measureTimeMinutes--;
			int hours = measureTimeMinutes / 60;
			int min = measureTimeMinutes - (hours * 60);
			bSetMeasureTime.Text = $"Встановити ({hours}:{"min:00"})";
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
				if (numRefRate.Value < 10)
					numRefRate.Value = 10;
		}

		internal Form1 parentForm;
		private void SendReloadPeriod()
		{
			reloadTime = (int)numRefRate.Value;
			if (radioButtMinutes.Checked)
				reloadTime *= 60;
			parentForm.serialPort1.WriteLine("R" + reloadTime.ToString());
		}

		/*	private void bRefRate_Click(object sender, EventArgs e)
			{
				string s = radioButtMinutes.Checked ? "хв" : "сек";
				bRefRate.Text = $"Встановити ({numRefRate.Value} {s})";
			} */
	}
}
