using System;
using System.Drawing;
using System.Windows.Forms;

namespace Weatherdata
{
    internal partial class FormSettings : Form
    {
        internal FormMain parentForm;
        internal FormSettings()
        {
            InitializeComponent();
            Width = 332;
        }

        private void FormSettings_Load(object sender, EventArgs e) => UpdateButtonColor();

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        //y = Ax + B, for calibrating
        internal float TempFixA = 1f, TempFixB = 0f;
        internal float HumdFixA = 1f, HumdFixB = 0f;
        internal float PresFixA = 1f, PresFixB = 0f;
        internal float BrtnFixA = 1f, BrtnFixB = 0f;
        internal float CO2FixA = 1f, CO2FixB = 0f;
        internal float IonFixA = 1f, IonFixB = 0f;

        internal bool isRecordingActive = false;
        internal bool hasDataToRecord = false; // is there some checkboxes?



        private void UpdHasToRecordState()
        {
            hasDataToRecord = cTemp.Checked || cHumid.Checked || cPressure.Checked || cBrightness.Checked || cCO2.Checked || cIon.Checked ? true : false;
            UpdateButtonColor();
        }

        internal void UpdateButtonColor()
        {
            if (!parentForm.serialPort1.IsOpen)
                bSetMeasureTime.BackColor = Color.Gray;
            else if (!hasDataToRecord)
                bSetMeasureTime.BackColor = Color.IndianRed;
            else if (!isRecordingActive)
                bSetMeasureTime.BackColor = Color.DarkSalmon;
            else
                bSetMeasureTime.BackColor = Color.LimeGreen;
        }


        public void disableAllCheckbox()
        {
            cTemp.Checked = false;
            cHumid.Checked = false;
            cPressure.Checked = false;
            cBrightness.Checked = false;
            cCO2.Checked = false;
            cIon.Checked = false;
        }

        internal void ToggleRecordingState()
        {
            if (hasDataToRecord && !isRecordingActive)
            {
                isRecordingActive = true;
                UpdateButtonColor();
            }
            else
            {
                isRecordingActive = false;
                UpdateButtonColor();
            }
        }

        private void TextBoxCalibration_Leave(object sender, EventArgs e) //apply calibrating
        {
            TextBox tb = sender as TextBox;
            string str = tb.Text.Replace(".", ",");
            switch (tb.Name)
            {
                case "TempA":
                    TempFixA = float.Parse(str);
                    break;
                case "TempB":
                    TempFixB = float.Parse(str);
                    break;

                case "HumdA":
                    HumdFixA = float.Parse(str);
                    break;
                case "HumdB":
                    HumdFixB = float.Parse(str);
                    break;

                case "PresA":
                    PresFixA = float.Parse(str);
                    break;
                case "PresB":
                    PresFixB = float.Parse(str);
                    break;

                case "BrtnA":
                    BrtnFixA = float.Parse(str);
                    break;
                case "BrtnB":
                    BrtnFixB = float.Parse(str);
                    break;

                case "CO2A":
                    CO2FixA = float.Parse(str);
                    break;
                case "CO2B":
                    CO2FixB = float.Parse(str);
                    break;

                case "IonA":
                    IonFixA = float.Parse(str);
                    break;
                case "IonB":
                    IonFixB = float.Parse(str);
                    break;

                default:
                    throw new NotImplementedException($"Name {tb.Name} not listed here");
            }
        }


        private int measureTimeMinutes = 0;
        private int recordEveryN = 1;
        private int recordCurrN = 1;

        public bool needRecordCurrent()
        {
            if (recordCurrN >= recordEveryN)
            { recordCurrN = 1; return true; }
            recordCurrN++;
            return false;
        }

        private void bSetMeasureTime_Click(object sender, EventArgs e)
        {
            if (parentForm.serialPort1.IsOpen)
                if (hasDataToRecord)
                    if (!isRecordingActive)
                    {
                        recordEveryN = rbPeriodMinutes.Checked ? (int)numRefRate.Value * 6 : (int)numRefRate.Value / 10;

                        recordCurrN = 1;

                        measureTimeMinutes = rbTotalTimeMinutes.Checked ? (int)numMeasureTime.Value : (int)numMeasureTime.Value * 60;

                        ToggleRecordingState(); // set isRecordingActive to true
                        int hours = measureTimeMinutes / 60;
                        int min = measureTimeMinutes - (hours * 60);
                        bSetMeasureTime.Text = "Встановлено (" +
                            hours.ToString("00:") + min.ToString("00)");

                        gbInputTypes.Enabled = false;

                        timer1.Start();

                        parentForm.nIcon.Visible = true;
                    }
                    else
                    {
                        timer1.Stop();
                        gbInputTypes.Enabled = true;
                        ToggleRecordingState(); // set isRecordingActive to false
                        bSetMeasureTime.Text = $"Встановити (00:00)";
                        parentForm.nIcon.Visible = false;
                    }
                else
                {
                    timer1.Stop();
                    ToggleRecordingState();
                    gbInputTypes.Enabled = true;
                    MessageBox.Show("Не обрано дані для запису");
                    bSetMeasureTime.Text = $"Встановити (00:00)";
                }
            else
            {
                timer1.Stop();
                ToggleRecordingState();
                gbInputTypes.Enabled = true;
                MessageBox.Show("Не підключено до пристрою через SerialPort");
                bSetMeasureTime.Text = $"Встановити (00:00)";
            }
        }

        private void bWidth_Click(object sender, EventArgs e) => Width = Width == 332 ? 625 : 332;

        private void DataSource_CheckedChanged(object sender, EventArgs e) => UpdHasToRecordState();

        private void button1_Click(object sender, EventArgs e)
        {
            if (parentForm.serialPort1.IsOpen)
                parentForm.serialPort1.Write("D");
        }


        internal void ParseStringD(string str)
        {
            int i = 1; // one step over 'D'

            TempA.Text = (int.Parse(str.Substring(i, 5)) / 1000f).ToString();
            TempB.Text = (int.Parse(str.Substring(i += 5, 5)) / 100f).ToString();

            HumdA.Text = (int.Parse(str.Substring(i += 5, 5)) / 1000f).ToString();
            HumdB.Text = (int.Parse(str.Substring(i += 5, 5)) / 100f).ToString();

            PresA.Text = (int.Parse(str.Substring(i += 5, 5)) / 1000f).ToString();
            PresB.Text = (int.Parse(str.Substring(i += 5, 5)) / 100f).ToString();

            BrtnA.Text = (int.Parse(str.Substring(i += 5, 5)) / 1000f).ToString();
            BrtnB.Text = (int.Parse(str.Substring(i += 5, 5)) / 100f).ToString();

            CO2A.Text = (int.Parse(str.Substring(i += 5, 5)) / 1000f).ToString();
            CO2B.Text = (int.Parse(str.Substring(i += 5, 5)) / 10f).ToString();

            i += 30; // no dust

            IonA.Text = (int.Parse(str.Substring(i += 5, 5)) / 1000f).ToString();
            IonB.Text = (int.Parse(str.Substring(i += 5, 5)) / 100f).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (parentForm.serialPort1.IsOpen)
                parentForm.serialPort1.Write("L");
        }

        private void bСalibrationSend_Click(object sender, EventArgs e)
        {
            string str = "C";

            if (double.TryParse(TempA.Text.Replace(".", ","), out double val))
                str += "TA" + clamp2(val, 0.5, 2.0, 1000).ToString("0000");
            if (double.TryParse(TempB.Text.Replace(".", ","), out val))
                str += "TB" + clamp2(val, -99.99, 99.99, 100).ToString("0000");


            if (double.TryParse(HumdA.Text.Replace(".", ","), out val))
                str += "HA" + clamp2(val, 0.5, 2.0, 1000).ToString("0000");
            if (double.TryParse(HumdB.Text.Replace(".", ","), out val))
                str += "HB" + clamp2(val, -99.99, 99.99, 100).ToString("0000");


            if (double.TryParse(PresA.Text.Replace(".", ","), out val))
                str += "PA" + clamp2(val, 0.5, 2.0, 1000).ToString("0000");
            if (double.TryParse(PresB.Text.Replace(".", ","), out val))
                str += "PB" + clamp2(val, -99.99, 99.99, 100).ToString("0000");


            if (double.TryParse(BrtnA.Text.Replace(".", ","), out val))
                str += "BA" + clamp2(val, 0.5, 2.0, 1000).ToString("0000");
            if (double.TryParse(BrtnB.Text.Replace(".", ","), out val))
                str += "BB" + clamp2(val, -99.99, 99.99, 100).ToString("0000");


            if (double.TryParse(CO2A.Text.Replace(".", ","), out val))
                str += "CA" + clamp2(val, 0.5, 2.0, 1000).ToString("0000");
            if (double.TryParse(CO2B.Text.Replace(".", ","), out val))
                str += "CB" + clamp2(val, -999.9, 999.9, 10).ToString("0000");

            parentForm.serialPort1.WriteLine(str);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            measureTimeMinutes--;
            if (measureTimeMinutes == 0)
            {
                timer1.Stop();
                gbInputTypes.Enabled = true;
                ToggleRecordingState(); // set isRecordingActive to false
                bSetMeasureTime.Text = $"Встановити (00:00)";
                parentForm.nIcon.Visible = false;
                parentForm.Show();
                return;
            }
            int hours = measureTimeMinutes / 60;
            int min = measureTimeMinutes - (hours * 60);

            bSetMeasureTime.Text = "Встановлено (" + hours.ToString("00:") + min.ToString("00)");
        }


        private int clamp2(double a, double min, double max, int multiplier) => (int)((a < max ? a > min ? a : min : max) * multiplier);

        private void radioButtMinutes_CheckedChanged(object sender, EventArgs e) => numRefRate.Increment = 1;

        private void rbPeriodSeconds_CheckedChanged(object sender, EventArgs e)
        {
            numRefRate.Increment = 10;
            if (rbPeriodSeconds.Checked)
                if (numRefRate.Value < 10)
                    numRefRate.Value = 10;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (rbPeriodSeconds.Checked)
                if (numRefRate.Value < 10)
                    numRefRate.Value = 10;
        }
    }
}
