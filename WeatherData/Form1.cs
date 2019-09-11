using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Weatherdata
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		public Form2 m2;
		public FormSettings formSettings;

		private Graphics g;
		private int luxPosition, pressPosition, co2Position, humdPosition; //labels
		private void Form1_Load(object sender, EventArgs e)
		{
			m2 = new Form2();
			formSettings = new FormSettings {
				parentForm = this
			};

			g = panel2.CreateGraphics();
			luxPosition = labelLux.Left + labelLux.Width;
			pressPosition = labelPress.Left + labelPress.Width;
			co2Position = labelCO2.Left + labelCO2.Width;
			humdPosition = labelHumd.Left + labelHumd.Width;

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

		private void button5_Click(object sender, EventArgs e)
		{
			if (m2.Visible)
				m2.Hide();
			else
				m2.Show();
		}



		private void button1_Click(object sender, EventArgs e)
		{
			refreshCOMPorts();
		}

		private void drawPressureArrow()
		{
			Point p = new Point();
			if (pressValue < 745)
				p.X = (int)Math.Round(0.0500037031 * Math.Pow(pressValue, 2) - 66.5063538402 * pressValue + 21975.2919826508);
			else
				p.X = (int)Math.Round(-0.0378580329 * Math.Pow(pressValue, 2) + 64.1265076250 * pressValue - 26582.0598220825);
			p.Y = (int)(262 - 243 * Math.Sin((pressValue + 712.7) / 32));
			g.DrawLine(new Pen(Color.Gray, 3), p, new Point(180, 220));
		}

		private double time => Math.Round(DateTime.Now.Hour + DateTime.Now.Minute / 60d + DateTime.Now.Second / 3600d + DateTime.Now.Millisecond / 3600000d, 6);


		private float _pressValue = 770;
		public float pressValue
		{
			get => _pressValue;
			set { _pressValue = value; PressureUpdate(); }
		}
		private void PressureUpdate()
		{
			panel2.Invalidate();
			Application.DoEvents();
			labelPress.Text = pressValue.ToString("000");
			drawPressureArrow();
			labelPress.Left = pressPosition - labelPress.Width;
			m2.chart1.Series["Pressure"].Points.AddXY(time, pressValue);
		}




		private float _tempValue = 21.3f;
		public float tempValue
		{
			get => _tempValue;
			set { _tempValue = value; TempUpdate(); }
		}
		private void TempUpdate()
		{
			labelTemp.Text = tempValue.ToString("00.0°C");
			panelTemp.Top = (int)Math.Round(81 - tempValue * 1.5f);
			panelTemp.Height = (int)Math.Round(tempValue * 1.5f);
			m2.chart1.Series["Temperature"].Points.AddXY(time, tempValue);
		}




		private float _humdValue;
		public float humdValue
		{
			get => _humdValue;
			set { _humdValue = value; HumdUpdate(); }
		}
		private void HumdUpdate()
		{
			labelHumd.Text = Math.Round(humdValue).ToString() + "%";
			labelHumd.Left = humdPosition - labelHumd.Width;
			panelHumdZero.Height = (int)Math.Round(73 - humdValue * 0.62);
			m2.chart1.Series["Humidity"].Points.AddXY(time, humdValue);
		}




		private int _co2Value;
		public int co2Value
		{
			get => _co2Value;
			set { _co2Value = value; CO2Update(); }
		}
		private void CO2Update()
		{
			labelCO2.Text = co2Value.ToString();
			labelCO2.Left = co2Position - labelCO2.Width;
			panel4.Left = (int)Math.Round(Math.Log(co2Value - 250) * 81 + 185);
			m2.chart1.Series["CO2"].Points.AddXY(time, co2Value);
		}




		private int _luxValue;
		public int luxValue
		{
			get => _luxValue;
			set { _luxValue = value; LuxUpdate(); }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				serialPort1.PortName = comboBox1.Text;
				serialPort1.Open();
			}
			catch (Exception)
			{
				//  Application.Exit();
			}
		}

		private void LuxUpdate()
		{
			labelLux.Text = luxValue.ToString();
			labelLux.Left = luxPosition - labelLux.Width;

			panel3.Left = (int)Math.Round(Math.Log(luxValue + 5) * 42 + 8);
			m2.chart1.Series["Brightness"].Points.AddXY(time, luxValue);
		}

		private Random rnd = new Random();
		private void button1_Click_1(object sender, EventArgs e)
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

		public void comSend(string s)
		{
			if (serialPort1.IsOpen)
				serialPort1.WriteLine(s);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (formSettings.Visible)
				formSettings.Hide();
			else
				formSettings.Show();
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			ParseWeatherString(serialPort1.ReadLine());
		}

		private void SaveWeatherString(string s)
		{
			if (!Directory.Exists(Application.StartupPath + @"/Data"))
				Directory.CreateDirectory(Application.StartupPath + @"/Data");

			using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"/Data/file_"
					  + DateTime.Now.ToShortDateString() + "d_" + DateTime.Now.Hour.ToString() + "h.txt", true)) //append
			{
				sw.Write(s);
				sw.Close();
			}
		}

		private void ParseWeatherString(string s)
		{
			string res = "S", t; // for file writing
			if (s[0].Equals('S')) //start data
			{
				Invoke(new Action(() =>
				{
					int index = 1;
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
							humdValue = Int16.Parse(s.Substring(++index, 3)) / 10f;
							index += 3;
						}

						if (s.Substring(index, 1).Equals("P"))
						{
							pressValue = Int16.Parse(s.Substring(++index, 4)) / 10f;
							index += 4;
						}

						if (s.Substring(index, 1).Equals("B"))
						{
							luxValue = Int16.Parse(s.Substring(++index, 4));
							index += 4;
						}

						if (s.Substring(index, 1).Equals("C"))
						{
							co2Value = Int16.Parse(s.Substring(++index, 4));
							index += 4;
						}

						if (s.Substring(index, 1).Equals("S"))
						{
							co2Value = Int16.Parse(s.Substring(++index, 4));
							index += 4;
						}

						if (s.Substring(index, 1).Equals("M"))
						{
							co2Value = Int16.Parse(s.Substring(++index, 4));
							index += 4;
						}
						if (s.Substring(index, 1).Equals("L"))
						{
							co2Value = Int16.Parse(s.Substring(++index, 4));
							index += 4;
						}
						if (s.Substring(index, 1).Equals("I"))
						{
							co2Value = Int16.Parse(s.Substring(++index, 4));
							index += 4;
						}
					}
				}));
			}
		}
	}
}
