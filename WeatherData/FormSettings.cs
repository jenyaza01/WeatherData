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
				bSetMeasureTime.BackColor = Color.Gray;
			else if (!hasToRecord)
				bSetMeasureTime.BackColor = Color.IndianRed;
			else if (!isRecordingEnabled)
				bSetMeasureTime.BackColor = Color.DarkSalmon;
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
		private int recordEvery = 1;
		private int recordCurrent = 1;

		public bool RecordCurrent()
		{
			if (recordCurrent >= recordEvery) { recordCurrent = 1; return true; }
			recordCurrent++;
			return false;
		}

		private void bSetMeasureTime_Click(object sender, EventArgs e)
		{
			if (parentForm.serialPort1.IsOpen)
				if (hasToRecord)
					if (!isRecordingEnabled)
					{
						timer1.Stop();

						if (radioButtMinutes.Checked)
							recordEvery = (int)numRefRate.Value * 6;
						else recordEvery = (int)numRefRate.Value / 10;

						recordCurrent = 1;

						if (radioButtonMinutes2.Checked)
							measureTimeMinutes = (int)numMeasureTime.Value;
						else measureTimeMinutes = (int)numMeasureTime.Value * 60;

						UpdRecordingState(); // this update isRecordingEnabled to true color to green
						int hours = measureTimeMinutes / 60;
						int min = measureTimeMinutes - (hours * 60);
						bSetMeasureTime.Text = $"Встановлено ({hours}:{min})";

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

		private void bСalibrationSend_Click(object sender, EventArgs e)
		{
			string str = "C";
			double val;

			if (Double.TryParse(TempA.Text.Replace(".", ","), out val))
				if (val != 1.0)
					str += "TA" + clamp2(val, 0.5, 2.0, 1000).ToString();
			if (Double.TryParse(TempB.Text.Replace(".", ","), out val))
				if (val != 0.0)
					str += "TB" + clamp2(val, -9.99, 99.99, 100).ToString();


			if (Double.TryParse(HumdA.Text.Replace(".", ","), out val))
				if (val != 1.0)
					str += "HA" + clamp2(val, 0.5, 2.0, 1000).ToString();
			if (Double.TryParse(HumdB.Text.Replace(".", ","), out val))
				if (val != 0.0)
					str += "HB" + clamp2(val, -9.99, 99.99, 100).ToString();


			if (Double.TryParse(PresA.Text.Replace(".", ","), out val))
				if (val != 1.0)
					str += "PA" + clamp2(val, 0.5, 2.0, 1000).ToString();
			if (Double.TryParse(PresB.Text.Replace(".", ","), out val))
				if (val != 0.0)
					str += "PB" + clamp2(val, -9.99, 99.99, 100).ToString();


			if (Double.TryParse(BrtnA.Text.Replace(".", ","), out val))
				if (val != 1.0)
					str += "BA" + clamp2(val, 0.5, 2.0, 1000).ToString();
			if (Double.TryParse(BrtnB.Text.Replace(".", ","), out val))
				if (val != 0.0)
					str += "BB" + clamp2(val, -9.99, 99.99, 100).ToString();


			if (Double.TryParse(CO2A.Text.Replace(".", ","), out val))
				if (val != 1.0)
					str += "CA" + clamp2(val, 0.5, 2.0, 1000).ToString();
			if (Double.TryParse(CO2B.Text.Replace(".", ","), out val))
				if (val != 0.0)
					str += "CB" + clamp2(val, -9.99, 99.99, 100).ToString();

			parentForm.serialPort1.WriteLine(str);
		}

		private int clamp2(double a, double min, double max, int multiplier)
		{
			return (int)((a < max ? a > min ? a : min : max) * multiplier);
		}

		private void radioButtMinutes_CheckedChanged(object sender, EventArgs e)
		{
			numRefRate.Increment = 1;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			measureTimeMinutes--;
			if (measureTimeMinutes == 0)
			{
				UpdRecordingState();
				timer1.Stop();
				bSetMeasureTime.Text = $"Встановити (00:00)";

				if (isRecordingEnabled)
				{
					cTemp.Checked = false;
					cHumid.Checked = false;
					cPressure.Checked = false;
					cBrightness.Checked = false;
					cCO2.Checked = false;
					cIon.Checked = false;
				}
				return;
			}
			int hours = measureTimeMinutes / 60;
			int min = measureTimeMinutes - (hours * 60);
			bSetMeasureTime.Text = $"Встановлено ({hours}:{"min:2d"})";
		}

		private int reloadTime;
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			numRefRate.Increment = 10;
			if (radioButtonSeconds.Checked)
				if (numRefRate.Value < 10)
					numRefRate.Value = 10;
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
