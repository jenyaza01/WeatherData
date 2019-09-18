using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Weatherdata
{
	internal partial class Form1 : Form
	{
		internal Form1()
		{
			InitializeComponent();
		}


		internal Form2 m2;
		internal FormSettings formSettings;

		private Graphics g;
		private int luxPosition, pressPosition, co2Position, humdPosition; //labels
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

			refreshCOMPorts();

			drawPressureArrow();
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

		private Point point = new Point();
		private void drawPressureArrow()
		{
			if (pressValue < 745)
				point.X = (int)Math.Round(0.0500037031 * Math.Pow(pressValue, 2) - 66.5063538402 * pressValue + 21975.2919826508);
			else
				point.X = (int)Math.Round(-0.0378580329 * Math.Pow(pressValue, 2) + 64.1265076250 * pressValue - 26582.0598220825);
			point.Y = (int)(262 - 243 * Math.Sin((pressValue + 712.7) / 32));

		}

		private double time => Math.Round(DateTime.Now.Hour + DateTime.Now.Minute / 60d + DateTime.Now.Second / 3600d + DateTime.Now.Millisecond / 3600000d, 4);


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
			m2.chart1.Series["Pressure"].Points.AddXY(time, pressValue);
		}

		private void TempUpdate()
		{
			labelTemp.Text = tempValue.ToString("00.0°C");
			panelTemp.Top = (int)Math.Round(81 - tempValue * 1.5f);
			panelTemp.Height = (int)Math.Round(tempValue * 1.5f);
			m2.chart1.Series["Temperature"].Points.AddXY(time, tempValue);
		}

		private void HumdUpdate()
		{
			labelHumd.Text = Math.Round(humdValue).ToString() + "%";
			labelHumd.Left = humdPosition - labelHumd.Width;
			panelHumdZero.Height = (int)Math.Round(73 - humdValue * 0.62);
			m2.chart1.Series["Humidity"].Points.AddXY(time, humdValue);
		}

		private void CO2Update()
		{
			labelCO2.Text = co2Value.ToString();
			labelCO2.Left = co2Position - labelCO2.Width;
			panelCO2.Left = (int)Math.Round(Math.Log(co2Value - 250) * 81 + 185);
			m2.chart1.Series["CO2"].Points.AddXY(time, co2Value);
			if (!panelCO2.Visible) panelCO2.Visible = true;
		}

		private void LuxUpdate()
		{
			labelLux.Text = luxValue.ToString();
			labelLux.Left = luxPosition - labelLux.Width;

			panelLux.Left = (int)Math.Round(Math.Log(luxValue + 5) * 42 + 8);
			m2.chart1.Series["Brightness"].Points.AddXY(time, luxValue);
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
			//	labelDustS.Text = DustSValue.ToString();
			//	labelDustS.Left = dustSPosition - labelDustS.Width;

			//	panelDustS.Left = 0;
			//	m2.chart1.Series["DustS"].Points.AddXY(time, dustSValue);
			//	if (!panelDustS.Visible) panelDustS.Visible = true;
		}

		private void DustMUpdate()
		{
			//	labelDustM.Text = DustMValue.ToMtring();
			//	labelDustM.Left = dustMPosition - labelDustM.Width;

			//	panelDustM.Left = 0;
			//	m2.chart1.Meries["DustM"].Points.AddXY(time, dustMValue);
			//	if (!panelDustM.Visible) panelDustM.Visible = true;
		}

		private void DustLUpdate()
		{
			//	labelDustL.Text = DustLValue.ToLtring();
			//	labelDustL.Left = dustLPosition - labelDustL.Width;

			//	panelDustL.Left = 0;
			//	m2.chart1.Leries["DustL"].Points.AddXY(time, dustLValue);
			//	if (!panelDustL.Visible) panelDustL.Visible = true;
		}

		#endregion



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


		
		private Random rnd = new Random();
		private void bRandom_Click(object sender, EventArgs e)
		{
			string s = "S";
			s += "T" + rnd.Next(200, 300).ToString("000");
			s += "P" + rnd.Next(7400, 7600).ToString("0000");
			s += "H" + rnd.Next(450, 650).ToString("000");
			s += "B" + rnd.Next(040, 100).ToString("0000");
			s += "C" + rnd.Next(450, 650).ToString("0000");
			s += "E";
			ParseWeatherString(s);
		}


		private void bSettings_Click(object sender, EventArgs e)
		{
			if (formSettings.Visible)
				formSettings.Hide();
			else
				formSettings.Show();
		}

		private Pen pen = new Pen(Color.Gray, 3);
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			g.DrawLine(pen, point, new Point(180, 220));
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			string s = serialPort1.ReadLine();
			if (s[0].Equals('S'))
				ParseWeatherString(s);
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


		private void ParseWeatherString(string s)
		{
			string res = "D", t; // for file writing

			Invoke(new Action(() =>
			{
				res += DateTime.Now.ToString("HHmmss");

				short index = 1;
				while (!s[index].Equals('E')) //while not end
				{
					if (s.Substring(index, 1).Equals("T")) //Temperature
					{
						t = s.Substring(++index, 3);
						tempValue = Int16.Parse(t) / 10f;
						index += 3;
						if (formSettings.cTemp.Checked)
							res += "T" + t;

					}

					if (s.Substring(index, 1).Equals("H"))
					{
						t = s.Substring(++index, 3);
						humdValue = Int16.Parse(t) / 10f;
						index += 3;
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
						co2Value = Int16.Parse(t);
						index += 4;
						if (formSettings.cDust.Checked)
							res += "S" + t;
					}

					if (s.Substring(index, 1).Equals("M"))
					{
						t = s.Substring(++index, 4);
						co2Value = Int16.Parse(t);
						index += 4;
						if (formSettings.cDust.Checked)
							res += "M" + t;
					}
					if (s.Substring(index, 1).Equals("L"))
					{
						t = s.Substring(++index, 4);
						co2Value = Int16.Parse(t);
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
			}));
			res += "E\n";

			if (formSettings.isRecordingEnabled) SaveWeatherString(res);
		}

		private float readTempValue;
		private float readHumdValue;
		private float readPressValue;
		private short readCO2Value;
		private short readLuxvalue;
		private short readDustSValue;
		private short readDustMValue;

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void labelTemp_Click(object sender, EventArgs e)
		{

		}

		private void labelPress_Click(object sender, EventArgs e)
		{

		}

		private void labMMHG_Click(object sender, EventArgs e)
		{

		}

		private void labelHumd_Click(object sender, EventArgs e)
		{

		}

		private void labelLux_Click(object sender, EventArgs e)
		{

		}

		private void labLUX_Click(object sender, EventArgs e)
		{

		}

		private void labPPM_Click(object sender, EventArgs e)
		{

		}

		private void labelCO2_Click(object sender, EventArgs e)
		{

		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{

		}

		private void panel10_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel9_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel8_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelCO2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelLux_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelTemp_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelHumdZero_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelHumdFull_Paint(object sender, PaintEventArgs e)
		{

		}

		private short readDustLValue;
		private short readIonvalue;

		private void ReadWeatherString(string path)
		{
			if (!File.Exists(path)) { MessageBox.Show("Обраного файла не існує"); return; };

			using (StreamReader sr = new StreamReader(path))
			{
				while (!sr.EndOfStream)
				{
					string s = sr.ReadLine();
					if (s[0].Equals('D')) //time of record
					{
						short hour = Int16.Parse(s.Substring(1, 2));
						short minute = Int16.Parse(s.Substring(3, 2));
						short second = Int16.Parse(s.Substring(5, 2));

						short index = 7;
						string t;
						while (!s[index].Equals('E')) //while not end
						{
							if (s.Substring(index, 1).Equals("T")) //Temperature
							{
								t = s.Substring(++index, 3);
								readTempValue = Int16.Parse(t) / 10f;
								index += 3;
							}

							if (s.Substring(index, 1).Equals("H"))
							{
								t = s.Substring(++index, 3);
								readHumdValue = Int16.Parse(t) / 10f;
								index += 3;
							}

							if (s.Substring(index, 1).Equals("P"))
							{
								t = s.Substring(++index, 4);
								readPressValue = Int16.Parse(t) / 10f;
								index += 4;
							}

							if (s.Substring(index, 1).Equals("B"))
							{
								t = s.Substring(++index, 4);
								readLuxvalue = Int16.Parse(t);
								index += 4;
							}

							if (s.Substring(index, 1).Equals("C"))
							{
								t = s.Substring(++index, 4);
								readCO2Value = Int16.Parse(t);
								index += 4;
							}

							if (s.Substring(index, 1).Equals("S"))
							{
								t = s.Substring(++index, 4);
								readDustSValue = Int16.Parse(t);
								index += 4;
							}

							if (s.Substring(index, 1).Equals("M"))
							{
								t = s.Substring(++index, 4);
								readDustMValue = Int16.Parse(t);
								index += 4;
							}
							if (s.Substring(index, 1).Equals("L"))
							{
								t = s.Substring(++index, 4);
								readDustLValue = Int16.Parse(t);
								index += 4;
							}
							if (s.Substring(index, 1).Equals("I"))
							{
								t = s.Substring(++index, 4);
								readIonvalue = Int16.Parse(t);
								index += 4;
							}
						}
					}

					// here you have time and all values
				}
			}
		}
	}
}
