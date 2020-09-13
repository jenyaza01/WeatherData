using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Weatherdata
{
    internal partial class FormMain : Form
    {
        internal FormMain()
        {
            this.InitializeComponent();
            nIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region variables

        internal FormChart formChart;
        internal FormSettings formSettings;

        private Graphics pressGraphics;
        private Pen pen = new Pen(Color.Gray, 3);
        private Point pressPoint = new Point();

        private Random rnd = new Random();

        private int luxPosition, pressPosition, co2Position, humdPosition;
        private int dustSPosition, dustMPosition, dustLPosition;

        #endregion


        #region interface

        private void Form1_Load(object sender, EventArgs e)
        {

#if DEBUG
            bRandomString.Visible = true;
            bChart.Enabled = true;
#endif

            formChart = new FormChart();
            formSettings = new FormSettings
            {
                parentForm = this
            };

            pressGraphics = pPress.CreateGraphics();
            luxPosition = labelLux.Left + labelLux.Width;
            pressPosition = labelPress.Left + labelPress.Width;
            co2Position = labelCO2.Left + labelCO2.Width;
            humdPosition = labelHumd.Left + labelHumd.Width;
            dustSPosition = labelDustS.Left + labelDustS.Width;
            dustMPosition = labelDustM.Left + labelDustM.Width;
            dustLPosition = labelDustL.Left + labelDustL.Width;

            this.refreshCOMPorts();
        }

        private void bChart_Click(object sender, EventArgs e)
        {
            formChart.updateChartButtons();
            formChart.Show();
            if (formChart.WindowState == FormWindowState.Minimized)
                formChart.WindowState = FormWindowState.Normal;
            formChart.BringToFront();
        }

        private void bReload_Click(object sender, EventArgs e)
        {
            this.refreshCOMPorts();
        }

        private void refreshCOMPorts()
        {
            string[] ComPortList = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ComPortList);

            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add(" no COM ports");
                comboBox1.Enabled = false;
                bConnect.Enabled = false;
            }
            else
            {
                bConnect.Enabled = true;
                comboBox1.Enabled = true;
            }

            // software COM usually last
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void CalcPressureArrowPoint()
        {
            pressPoint = new Point
            {
                X = pressValue < 745
? (int)Math.Round(0.0500037 * Math.Pow(pressValue, 2) - 66.506353 * pressValue + 21975.291983)
: (int)Math.Round(-0.037858 * Math.Pow(pressValue, 2) + 64.126507 * pressValue - 26582.059822),

                Y = (int)(262 - 243 * Math.Sin((pressValue + 712.7) / 32))
            };
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (formSettings.isRecordingActive)
                {
                    if (MessageBox.Show("Активний запис даних з пристрою.\nДійсно від'єднатися?", "Увага!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        formSettings.disableAllCheckbox();
                        formSettings.isRecordingActive = false;
                        formSettings.timer1.Stop();
                        formSettings.bSetMeasureTime.Text = $"Встановити (00:00)";
                        nIcon.Visible = false;
                    }
                    else
                        return;
                }

                try
                {
                    serialPort1.Write("X");
                    serialPort1.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Порт закритий з помилкою.\nВірогідно, пристрій вже від'єднано");
                }
                finally
                {
                    formSettings.disableAllCheckbox();
                    bConnect.Text = "Connect";
                    bReload.Enabled = true;
                    comboBox1.Enabled = true;
                    formSettings.UpdateButtonColor();

                }
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Не вдалося відкрити порт.\nПеревірте з'єднання пристрою з ПК");
                }
                formSettings.disableAllCheckbox();
                formSettings.ToggleRecordingState();
                bReload.Enabled = false;
                comboBox1.Enabled = false;
                bConnect.Text = "Disconnect";
            }
        }

        private void bRandom_Click(object sender, EventArgs e)
        {
            string str = "Z";
            str += "T" + rnd.Next(50, 450).ToString("0000");
            str += "P" + rnd.Next(7100, 7800).ToString("0000");
            str += "H" + rnd.Next(0, 1000).ToString("0000");
            str += "B" + rnd.Next(0, 9999).ToString("0000");
            str += "C" + rnd.Next(400, 7000).ToString("0000");
            str += "S" + rnd.Next(0, 100).ToString("0000");
            str += "M" + rnd.Next(0, 100).ToString("0000");
            str += "L" + rnd.Next(0, 100).ToString("0000");
            str += "E";
            this.ParseWeatherStringZ(str);
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            if (formSettings.WindowState == FormWindowState.Minimized)
                formSettings.WindowState = FormWindowState.Normal;
            formSettings.Show();
            formSettings.BringToFront();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pressGraphics.DrawLine(pen, new Point(180, 220), pressPoint);
        }

        #endregion


        #region weather wariables

        private float _tempValue;
        internal float tempValue
        {
            get => _tempValue;
            set { _tempValue = value; this.TempUpdate(); }
        }

        private float _humdValue;
        internal float humdValue
        {
            get => _humdValue;
            set { _humdValue = value; this.HumdUpdate(); }
        }

        private float _pressValue = 720;
        internal float pressValue
        {
            get => _pressValue;
            set { _pressValue = value; this.PressureUpdate(); }
        }

        private int _co2Value;
        internal int co2Value
        {
            get => _co2Value;
            set { _co2Value = value; this.CO2Update(); }
        }

        private int _luxValue;
        internal int luxValue
        {
            get => _luxValue;
            set { _luxValue = value; this.LuxUpdate(); }
        }

        private int _dustSValue;
        internal int dustSValue
        {
            get => _dustSValue;
            set { _dustSValue = value; this.DustSUpdate(); }
        }

        private int _dustMValue;
        internal int dustMValue
        {
            get => _dustMValue;
            set { _dustMValue = value; this.DustMUpdate(); }
        }

        private int _dustLValue;
        internal int dustLValue
        {
            get => _dustLValue;
            set { _dustLValue = value; this.DustLUpdate(); }
        }

        private int _ionValue;
        internal int ionValue
        {
            get => _ionValue;
            set { _ionValue = value; this.IonUpdate(); }
        }

        #endregion


        #region variable updaters

        private readonly int CHART_POINTS = 600;

        private void ChartScaleUpdate()
        {
            if (formChart.Visible)
                formChart.chart1.ChartAreas[0].RecalculateAxesScale();
        }


        private void PressureUpdate()
        {
            pPress.Invalidate();
            Application.DoEvents();
            this.CalcPressureArrowPoint();

            labelPress.Text = pressValue.ToString("000");
            labelPress.Left = pressPosition - labelPress.Width;

            if (formChart.chart1.Series["Pressure"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["Pressure"].Points.RemoveAt(0);
            formChart.chart1.Series["Pressure"].Points.AddXY(DateTime.Now, pressValue);
        }

        private void TempUpdate()
        {
            labelTemp.Text = tempValue.ToString("00.0°C");
            panelTemp.Top = (int)Math.Round(81 - tempValue * 1.5f);
            panelTemp.Height = (int)Math.Round(tempValue * 1.5f);

            if (formChart.chart1.Series["Temperature"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["Temperature"].Points.RemoveAt(0);
            formChart.chart1.Series["Temperature"].Points.AddXY(DateTime.Now, tempValue);
        }

        private void HumdUpdate()
        {
            labelHumd.Text = Math.Round(humdValue).ToString() + "%";
            labelHumd.Left = humdPosition - labelHumd.Width;
            panelHumdZero.Height = (int)Math.Round(73 - humdValue * 0.62);

            if (formChart.chart1.Series["Humidity"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["Humidity"].Points.RemoveAt(0);
            formChart.chart1.Series["Humidity"].Points.AddXY(DateTime.Now, humdValue);

        }

        private void CO2Update()
        {
            labelCO2.Text = co2Value.ToString();
            labelCO2.Left = co2Position - labelCO2.Width;
            panelCO2.Left = (int)Math.Round(Math.Log(co2Value - CHART_POINTS) * 75 + 180);

            if (formChart.chart1.Series["CO2"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["CO2"].Points.RemoveAt(0);
            formChart.chart1.Series["CO2"].Points.AddXY(DateTime.Now, co2Value);

            if (!panelCO2.Visible)
                panelCO2.Visible = true;
        }

        private void LuxUpdate()
        {
            labelLux.Text = luxValue.ToString();
            labelLux.Left = luxPosition - labelLux.Width;

            panelLux.Left = (int)Math.Round(Math.Log(luxValue + 5) * 42 + 8);
            if (formChart.chart1.Series["Brightness"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["Brightness"].Points.RemoveAt(0);
            formChart.chart1.Series["Brightness"].Points.AddXY(DateTime.Now, luxValue);

            if (!panelLux.Visible)
                panelLux.Visible = true;
        }

        private void IonUpdate()
        {
            //	labelIon.Text = IonValue.ToString(); // not exist
            //	labelIon.Left = ionPosition - labelIon.Width;

            //	panelIon.Left = 0;
            //	m2.chart1.Series["Ion"].Points.AddXY(time, ionValue);
            //	if (!panelIon.Visible) panelIon.Visible = true;
        }

        private void DustSUpdate()
        {
            labelDustS.Text = dustSValue.ToString();
            labelDustS.Left = dustSPosition - labelDustS.Width;

            if (formChart.chart1.Series["DustSmall"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["DustSmall"].Points.RemoveAt(0);
            formChart.chart1.Series["DustSmall"].Points.AddXY(DateTime.Now, dustSValue);
        }

        private void DustMUpdate()
        {
            labelDustM.Text = dustMValue.ToString();
            labelDustM.Left = dustMPosition - labelDustM.Width;

            if (formChart.chart1.Series["DustMed"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["DustMed"].Points.RemoveAt(0);
            formChart.chart1.Series["DustMed"].Points.AddXY(DateTime.Now, dustMValue);
        }

        private void DustLUpdate()
        {
            labelDustL.Text = dustLValue.ToString();
            labelDustL.Left = dustLPosition - labelDustL.Width;

            if (formChart.chart1.Series["DustLarge"].Points.Count > CHART_POINTS)
                formChart.chart1.Series["DustLarge"].Points.RemoveAt(0);
            formChart.chart1.Series["DustLarge"].Points.AddXY(DateTime.Now, dustLValue);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nIcon.Visible)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("X");
                    serialPort1.Close();
                }
                catch (Exception)
                {
                    // just close
                }
            }
        }

        private void nIcon_Click(object sender, EventArgs e)
        {
            if (!Visible || WindowState == FormWindowState.Minimized)
            { this.Show(); this.Activate(); WindowState = FormWindowState.Normal; }
        }

        #endregion



        #region receiving data

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadLine();
            if (str[0].Equals('S'))  // that's data for saving
            {
                if (this.IsValidSLength(str.Length))
                {
                    bChart.Enabled = formChart.updateChartButtons();
                    this.ParseWeatherStringS(str);
                }
            }
            else if (str[0].Equals('Z'))   // that's data for display, not save
            {
                if (this.IsValidSLength(str.Length))
                {
                    bChart.Enabled = formChart.updateChartButtons();
                    this.ParseWeatherStringZ(str);
                }
            }
            else if (str[0].Equals('D')) // that's data for settings > calibration
            {
                if (this.IsValidDLength(str.Length))
                {
                    formSettings.bСalibrationSend.Enabled = true;
                    formSettings.ParseStringD(str);
                }
            }
        }


        private bool IsValidSLength(int length)
        {
            return (((length - 3) % 5) == 0);
        }

        private bool IsValidDLength(int length)
        {
            return (((length - 3) % 5) == 0);
        }

        private void ParseWeatherStringS(string s)
        {
            string res = "@", t; // for file writing

            res += DateTime.Now.ToString("HHmmss");

            short index = 1;
            this.Invoke(new Action(() =>
            {
                while (!s[index].Equals('E')) //while not end
                {
                    if (s.Substring(index, 1).Equals("T")) //Temperature
                    {
                        t = s.Substring(++index, 4);
                        tempValue = short.Parse(t) / 10f;
                        index += 4;
                        if (formSettings.cTemp.Checked)
                            res += "T" + t;
                    }

                    if (s.Substring(index, 1).Equals("H"))
                    {
                        t = s.Substring(++index, 4);
                        humdValue = short.Parse(t) / 10f;
                        index += 4;
                        if (formSettings.cHumid.Checked)
                            res += "H" + t;
                    }

                    if (s.Substring(index, 1).Equals("P"))
                    {
                        t = s.Substring(++index, 4);
                        pressValue = short.Parse(t) / 10f;
                        index += 4;
                        if (formSettings.cPressure.Checked)
                            res += "P" + t;
                    }

                    if (s.Substring(index, 1).Equals("B"))
                    {
                        t = s.Substring(++index, 4);
                        luxValue = short.Parse(t);
                        index += 4;
                        if (formSettings.cBrightness.Checked)
                            res += "B" + t;
                    }

                    if (s.Substring(index, 1).Equals("C"))
                    {
                        t = s.Substring(++index, 4);
                        co2Value = short.Parse(t);
                        index += 4;
                        if (formSettings.cCO2.Checked)
                            res += "C" + t;
                    }

                    if (s.Substring(index, 1).Equals("S"))
                    {
                        t = s.Substring(++index, 4);
                        dustSValue = short.Parse(t);
                        index += 4;
                        if (formSettings.cDust.Checked)
                            res += "S" + t;
                    }

                    if (s.Substring(index, 1).Equals("M"))
                    {
                        t = s.Substring(++index, 4);
                        dustMValue = short.Parse(t);
                        index += 4;
                        if (formSettings.cDust.Checked)
                            res += "M" + t;
                    }
                    if (s.Substring(index, 1).Equals("L"))
                    {
                        t = s.Substring(++index, 4);
                        dustLValue = short.Parse(t);
                        index += 4;
                        if (formSettings.cDust.Checked)
                            res += "L" + t;
                    }
                    if (s.Substring(index, 1).Equals("I"))
                    {
                        t = s.Substring(++index, 4);
                        co2Value = short.Parse(t);
                        index += 4;
                        if (formSettings.cIon.Checked)
                            res += "I" + t;
                    }
                }
                this.ChartScaleUpdate();
            }));
            res += "E\n";

            if (formSettings.isRecordingActive && formSettings.needRecordCurrent())
                this.SaveWeatherString(res);
            this.Invoke(new Action(() => bChart.Enabled = formChart.updateChartButtons()));
        }

        private StreamWriter sw;
        private void SaveWeatherString(string s)
        {
            if (!Directory.Exists(Application.StartupPath + @"\Data"))
                Directory.CreateDirectory(Application.StartupPath + @"\Data");
            string filename = "file_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

            if (!File.Exists(Application.StartupPath + "\\Data\\" + filename))
            {
                sw = new StreamWriter(Application.StartupPath + "\\Data\\" + filename, true);
                sw.WriteLine("D" + DateTime.Now.ToString("ddMMyyyy"));
            }
            else
                sw = new StreamWriter(Application.StartupPath + "\\Data\\" + filename, true);

            sw.Write(s);
            sw.Close();
        }

        private void ParseWeatherStringZ(string s)
        {
            string t;
            this.Invoke(new Action(() =>
            {
                short index = 1;
                while (!s[index].Equals('E')) //while not end
                {
                    if (s.Substring(index, 1).Equals("T")) //Temperature
                    {
                        t = s.Substring(++index, 4);
                        tempValue = short.Parse(t) / 10f;
                        index += 4;

                    }

                    if (s.Substring(index, 1).Equals("H"))
                    {
                        t = s.Substring(++index, 4);
                        humdValue = short.Parse(t) / 10f;
                        index += 4;
                    }

                    if (s.Substring(index, 1).Equals("P"))
                    {
                        t = s.Substring(++index, 4);
                        pressValue = short.Parse(t) / 10f;
                        index += 4;
                    }

                    if (s.Substring(index, 1).Equals("B"))
                    {
                        t = s.Substring(++index, 4);
                        luxValue = short.Parse(t);
                        index += 4;
                    }

                    if (s.Substring(index, 1).Equals("C"))
                    {
                        t = s.Substring(++index, 4);
                        co2Value = short.Parse(t);
                        index += 4;
                    }

                    if (s.Substring(index, 1).Equals("S"))
                    {
                        t = s.Substring(++index, 4);
                        dustSValue = short.Parse(t);
                        index += 4;
                    }

                    if (s.Substring(index, 1).Equals("M"))
                    {
                        t = s.Substring(++index, 4);
                        dustMValue = short.Parse(t);
                        index += 4;
                    }
                    if (s.Substring(index, 1).Equals("L"))
                    {
                        t = s.Substring(++index, 4);
                        dustLValue = short.Parse(t);
                        index += 4;
                    }
                    if (s.Substring(index, 1).Equals("I"))
                    {
                        t = s.Substring(++index, 4);
                        co2Value = short.Parse(t);
                        index += 4;
                    }
                }
            }));
        }

        #endregion
    }
}
