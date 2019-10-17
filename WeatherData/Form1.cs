using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weatherdata
{
	internal partial class Form1 : Form
	{
		internal Form1()
		{
			InitializeComponent();
		}

		#region variables

		internal Form2 m2;
		internal FormSettings formSettings;

		private Graphics g;
		private Pen pen = new Pen(Color.Gray, 3);
		private Point point = new Point();

		private Random rnd = new Random();

		private int luxPosition, pressPosition, co2Position, humdPosition;
		private int dustSPosition, dustMPosition, dustLPosition;

		private double currTime => Math.Round(DateTime.Now.Hour + DateTime.Now.Minute /
		60d + DateTime.Now.Second / 3600d, 4);

		#endregion


		#region interface

		private void Form1_Load(object sender, EventArgs e)
		{
			m2 = new Form2();
			formSettings = new FormSettings
			{
				parentForm = this
			};

			g = panel2.CreateGraphics();
			luxPosition = labelLux.Left + labelLux.Width;
			pressPosition = labelPress.Left + labelPress.Width;
			co2Position = labelCO2.Left + labelCO2.Width;
			humdPosition = labelHumd.Left + labelHumd.Width;
			dustSPosition = labelDustS.Left + labelDustS.Width;
			dustMPosition = labelDustM.Left + labelDustM.Width;
			dustLPosition = labelDustL.Left + labelDustL.Width;

			refreshCOMPorts();

			drawPressureArrow();
		}

		private void bChart_Click(object sender, EventArgs e)
		{
			if (m2.Visible)
				m2.Hide();
			else
			{
				m2.Show();
				m2.Activate();
			}
		}

		private void bReload_Click(object sender, EventArgs e)
		{
			refreshCOMPorts();
		}

		private void refreshCOMPorts()
		{
			string[] ComPortList = SerialPort.GetPortNames();
			comboBox1.Items.Clear();
			comboBox1.Items.AddRange(ComPortList);

			if (comboBox1.Items.Count == 0)
			{
				comboBox1.Items.Add("no COM ports");
				comboBox1.Enabled = false;
				bConnect.Enabled = false;
			}
			else
			{
				bConnect.Enabled = true;
				comboBox1.Enabled = true;
			}

			comboBox1.SelectedIndex = 0;
		}

		private void drawPressureArrow()
		{
			if (pressValue < 745)
				point.X = (int)Math.Round(0.0500037031 * Math.Pow(pressValue, 2) - 66.5063538402 * pressValue + 21975.2919826508);
			else
				point.X = (int)Math.Round(-0.0378580329 * Math.Pow(pressValue, 2) + 64.1265076250 * pressValue - 26582.0598220825);
			point.Y = (int)(262 - 243 * Math.Sin((pressValue + 712.7) / 32));

		}

		private void bConnect_Click(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen)
			{
				try
				{
					serialPort1.Close();
				}
				catch (Exception)
				{
					MessageBox.Show("Порт закритий з помилкою.\nВірогідно, пристрій вже від'єднано");
				}
				finally
				{
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
				formSettings.UpdRecordingState();
				bReload.Enabled = false;
				comboBox1.Enabled = false;
				bConnect.Text = "Disconnect";
			}
		}

		private void bRandom_Click(object sender, EventArgs e)
		{
			string s = "Z";
			s += "T" + rnd.Next(100, 400).ToString("0000");
			s += "P" + rnd.Next(7200, 7800).ToString("0000");
			s += "H" + rnd.Next(0, 1000).ToString("0000");
			s += "B" + rnd.Next(0, 9999).ToString("0000");
			s += "C" + rnd.Next(400, 5000).ToString("0000");
			s += "S" + rnd.Next(0, 100).ToString("0000");
			s += "M" + rnd.Next(0, 100).ToString("0000");
			s += "L" + rnd.Next(0, 100).ToString("0000");
			s += "E";
			ParseWeatherStringS(s);
		}

		private void bSettings_Click(object sender, EventArgs e)
		{
			if (formSettings.Visible)
				formSettings.Hide();
			else
				formSettings.Show();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			g.DrawLine(pen, point, new Point(180, 220));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			go();
		}

		private async void go()
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 300; i++)
				{
					Invoke(new Action(() => { bRandom_Click(this, null); m2.chart1.ChartAreas[0].RecalculateAxesScale(); }));

					Task.Delay(50).Wait();
				}
			});
		}

		#endregion


		#region weather wariables

		private float _tempValue;
		internal float tempValue
		{
			get => _tempValue;
			set { _tempValue = value; TempUpdate(); }
		}

		private float _humdValue;
		internal float humdValue
		{
			get => _humdValue;
			set { _humdValue = value; HumdUpdate(); }
		}

		private float _pressValue = 720;
		internal float pressValue
		{
			get => _pressValue;
			set { _pressValue = value; PressureUpdate(); }
		}

		private int _co2Value;
		internal int co2Value
		{
			get => _co2Value;
			set { _co2Value = value; CO2Update(); }
		}

		private int _luxValue;
		internal int luxValue
		{
			get => _luxValue;
			set { _luxValue = value; LuxUpdate(); }
		}

		private int _dustSValue;
		internal int dustSValue
		{
			get => _dustSValue;
			set { _dustSValue = value; DustSUpdate(); }
		}

		private int _dustMValue;
		internal int dustMValue
		{
			get => _dustMValue;
			set { _dustMValue = value; DustMUpdate(); }
		}

		private int _dustLValue;
		internal int dustLValue
		{
			get => _dustLValue;
			set { _dustLValue = value; DustLUpdate(); }
		}

		private int _ionValue;
		internal int ionValue
		{
			get => _ionValue;
			set { _ionValue = value; IonUpdate(); }
		}

		#endregion


		#region variable updaters

		private void PressureUpdate()
		{
			panel2.Invalidate();
			Application.DoEvents();
			drawPressureArrow();
			labelPress.Text = pressValue.ToString("000");
			labelPress.Left = pressPosition - labelPress.Width;
			if (m2.chart1.Series["Pressure"].Points.Count > 250) m2.chart1.Series["Pressure"].Points.RemoveAt(0);
			m2.chart1.Series["Pressure"].Points.AddXY(currTime, pressValue);
		}

		private void TempUpdate()
		{
			labelTemp.Text = tempValue.ToString("00.0°C");
			panelTemp.Top = (int)Math.Round(81 - tempValue * 1.5f);
			panelTemp.Height = (int)Math.Round(tempValue * 1.5f);
			if (m2.chart1.Series["Temperature"].Points.Count > 250) m2.chart1.Series["Temperature"].Points.RemoveAt(0);
			m2.chart1.Series["Temperature"].Points.AddXY(currTime, tempValue);
		}

		private void HumdUpdate()
		{
			labelHumd.Text = Math.Round(humdValue).ToString() + "%";
			labelHumd.Left = humdPosition - labelHumd.Width;
			panelHumdZero.Height = (int)Math.Round(73 - humdValue * 0.62);
			if (m2.chart1.Series["Humidity"].Points.Count > 250) m2.chart1.Series["Humidity"].Points.RemoveAt(0);
			m2.chart1.Series["Humidity"].Points.AddXY(currTime, humdValue);
		}

		private void CO2Update()
		{
			labelCO2.Text = co2Value.ToString();
			labelCO2.Left = co2Position - labelCO2.Width;
			panelCO2.Left = (int)Math.Round(Math.Log(co2Value - 250) * 81 + 185);
			if (m2.chart1.Series["CO2"].Points.Count > 250) m2.chart1.Series["CO2"].Points.RemoveAt(0);
			m2.chart1.Series["CO2"].Points.AddXY(currTime, co2Value);

			if (!panelCO2.Visible) panelCO2.Visible = true;
		}

		private void LuxUpdate()
		{
			labelLux.Text = luxValue.ToString();
			labelLux.Left = luxPosition - labelLux.Width;

			panelLux.Left = (int)Math.Round(Math.Log(luxValue + 5) * 42 + 8);
			if (m2.chart1.Series["Brightness"].Points.Count > 250) m2.chart1.Series["Brightness"].Points.RemoveAt(0);
			m2.chart1.Series["Brightness"].Points.AddXY(currTime, luxValue);
			if (!panelLux.Visible) panelLux.Visible = true;
		}

		private void IonUpdate()
		{
			//	labelIon.Text = IonValue.ToString();
			//	labelIon.Left = ionPosition - labelIon.Width;

			//	panelIon.Left = 0;
			//	m2.chart1.Series["Ion"].Points.AddXY(time, ionValue);
			//	if (!panelIon.Visible) panelIon.Visible = true;
		}

		private void DustSUpdate()
		{
			labelDustS.Text = dustSValue.ToString();
			labelDustS.Left = dustSPosition - labelDustS.Width;

			//	panelDustS.Left = 0;
			// m2.chart1.Series["Dust"].Points.AddXY(time, dustSValue);
			//	if (!panelDustS.Visible) panelDustS.Visible = true;
		}

		private void DustMUpdate()
		{
			labelDustM.Text = dustMValue.ToString();
			labelDustM.Left = dustMPosition - labelDustM.Width;

			//panelDustM.Left = 0;
			if (m2.chart1.Series["Dust"].Points.Count > 250) m2.chart1.Series["Dust"].Points.RemoveAt(0);
			m2.chart1.Series["Dust"].Points.AddXY(currTime, dustMValue);
			//	if (!panelDustM.Visible) panelDustM.Visible = true;
		}

		private void DustLUpdate()
		{
			labelDustL.Text = dustLValue.ToString();
			labelDustL.Left = dustLPosition - labelDustL.Width;

			//	panelDustL.Left = 0;
			// m2.chart1.Series["Dust"].Points.AddXY(time, dustLValue);
			//	if (!panelDustL.Visible) panelDustL.Visible = true;
		}

		#endregion


		#region receiving data

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			string str = serialPort1.ReadLine();
			if (IsValidLength(str.Length))
				if (str[str.Length - 1].Equals("E"))
					if (str[0].Equals("S"))
						ParseWeatherStringS(str);
					else if (str[0].Equals("Z"))
						ParseWeatherStringZ(str);
			// else wrong start char (nor S or Z)
			// else last is not E
			// else not full string received 
		}

		private bool IsValidLength(int length)
		{
			return (((length - 2) % 4) == 0);
		}

		private void ParseWeatherStringS(string s)
		{
			string res = "D", t; // for file writing

			res += DateTime.Now.ToString("HHmmss");

			short index = 1;
			while (!s[index].Equals('E')) //while not end
			{
				if (s.Substring(index, 1).Equals("T")) //Temperature
				{
					t = s.Substring(++index, 4);
					tempValue = Int16.Parse(t) / 10f;
					index += 4;
					if (formSettings.cTemp.Checked)
						res += "T" + t;
				}

				if (s.Substring(index, 1).Equals("H"))
				{
					t = s.Substring(++index, 4);
					humdValue = Int16.Parse(t) / 10f;
					index += 4;
					if (formSettings.cHumid.Checked)
						res += "H" + t;
				}

				if (s.Substring(index, 1).Equals("P"))
				{
					t = s.Substring(++index, 4);
					pressValue = Int16.Parse(t) / 10f;
					index += 4;
					if (formSettings.cPressure.Checked)
						res += "P" + t;
				}

				if (s.Substring(index, 1).Equals("B"))
				{
					t = s.Substring(++index, 4);
					luxValue = Int16.Parse(t);
					index += 4;
					if (formSettings.cBrightness.Checked)
						res += "B" + t;
				}

				if (s.Substring(index, 1).Equals("C"))
				{
					t = s.Substring(++index, 4);
					co2Value = Int16.Parse(t);
					index += 4;
					if (formSettings.cCO2.Checked)
						res += "C" + t;
				}

				if (s.Substring(index, 1).Equals("S"))
				{
					t = s.Substring(++index, 4);
					dustSValue = Int16.Parse(t);
					index += 4;
					if (formSettings.cDust.Checked)
						res += "S" + t;
				}

				if (s.Substring(index, 1).Equals("M"))
				{
					t = s.Substring(++index, 4);
					dustMValue = Int16.Parse(t);
					index += 4;
					if (formSettings.cDust.Checked)
						res += "M" + t;
				}
				if (s.Substring(index, 1).Equals("L"))
				{
					t = s.Substring(++index, 4);
					dustLValue = Int16.Parse(t);
					index += 4;
					if (formSettings.cDust.Checked)
						res += "L" + t;
				}
				if (s.Substring(index, 1).Equals("I"))
				{
					t = s.Substring(++index, 4);
					co2Value = Int16.Parse(t);
					index += 4;
					if (formSettings.cIon.Checked)
						res += "T" + t;
				}
			}
			res += "E\n";

			if (formSettings.isRecordingEnabled && formSettings.RecordCurrent()) SaveWeatherString(res);
		}

		private void SaveWeatherString(string s)
		{
			if (!Directory.Exists(Application.StartupPath + @"/Data"))
				Directory.CreateDirectory(Application.StartupPath + @"/Data");

			using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"/Data/file_"
					  + DateTime.Now.ToShortDateString() + "d.txt", true)) //append
			{
				sw.Write(s);
				sw.Close();
			}
		}

		private void ParseWeatherStringZ(string s)
		{
			string t;
			Invoke(new Action(() =>
			{
				short index = 1;
				while (!s[index].Equals('E')) //while not end
				{
					if (s.Substring(index, 1).Equals("T")) //Temperature
					{
						t = s.Substring(++index, 4);
						tempValue = Int16.Parse(t) / 10f;
						index += 4;

					}

					if (s.Substring(index, 1).Equals("H"))
					{
						t = s.Substring(++index, 4);
						humdValue = Int16.Parse(t) / 10f;
						index += 4;
					}

					if (s.Substring(index, 1).Equals("P"))
					{
						t = s.Substring(++index, 4);
						pressValue = Int16.Parse(t) / 10f;
						index += 4;
					}

					if (s.Substring(index, 1).Equals("B"))
					{
						t = s.Substring(++index, 4);
						luxValue = Int16.Parse(t);
						index += 4;
					}

					if (s.Substring(index, 1).Equals("C"))
					{
						t = s.Substring(++index, 4);
						co2Value = Int16.Parse(t);
						index += 4;
					}

					if (s.Substring(index, 1).Equals("S"))
					{
						t = s.Substring(++index, 4);
						dustSValue = Int16.Parse(t);
						index += 4;
					}

					if (s.Substring(index, 1).Equals("M"))
					{
						t = s.Substring(++index, 4);
						dustMValue = Int16.Parse(t);
						index += 4;
					}
					if (s.Substring(index, 1).Equals("L"))
					{
						t = s.Substring(++index, 4);
						dustLValue = Int16.Parse(t);
						index += 4;
					}
					if (s.Substring(index, 1).Equals("I"))
					{
						t = s.Substring(++index, 4);
						co2Value = Int16.Parse(t);
						index += 4;
					}
				}
			}));
		}

		#endregion
	}
}
