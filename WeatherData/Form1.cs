using System;
using System.Drawing;
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

        private Graphics g;
        private int luxPosition, pressPosition, co2Position, humdPosition; //labels
        private void Form1_Load(Object sender, EventArgs e)
        {
            m2 = new Form2();

            g = panel2.CreateGraphics();
            luxPosition = labelLux.Left + labelLux.Width;
            pressPosition = labelPress.Left + labelPress.Width;
            co2Position = labelCO2.Left + labelCO2.Width;
            humdPosition = labelHumd.Left + labelHumd.Width;

            try
            {
                serialPort1.PortName = SerialPort.GetPortNames()[0];
                serialPort1.Open();
            }
            catch (Exception)
            {
                //  Application.Exit();
            }
        }


        private void button5_Click(Object sender, EventArgs e)
        {
            if (m2.Visible) m2.Hide(); else m2.Show();
        }



        private void button1_Click(Object sender, EventArgs e) // draw arrow for pressure
        {
            Point p = new Point();
            if (pressValue < 745)
                p.X = (int)Math.Round(0.0500037031 * Math.Pow(pressValue, 2) - 66.5063538402 * pressValue + 21975.2919826508);
            else
                p.X = (int)Math.Round(-0.0378580329 * Math.Pow(pressValue, 2) + 64.1265076250 * pressValue - 26582.0598220825);
            p.Y = (int)(262 - 243 * Math.Sin((pressValue + 712.7) / 32));
            g.DrawLine(new Pen(Color.Gray, 3), p, new Point(180, 220));
        }




        double time { get { return Math.Round(DateTime.Now.Hour + DateTime.Now.Minute / 60f + DateTime.Now.Second / 3600f,3); } }



        private float _pressValue = 770;
        public float pressValue
        {
            get { return _pressValue; }
            set { _pressValue = value; PressureUpdate(); }
        }
        private void PressureUpdate()
        {
            panel2.Invalidate();
            Application.DoEvents();
            labelPress.Text = pressValue.ToString("000");
            button1_Click(null, null);
            labelPress.Left = pressPosition - labelPress.Width;
            m2.chart1.Series["Pressure"].Points.AddXY(time, pressValue);
        }




        private float _tempValue = 21.3f;
        public float tempValue
        {
            get { return _tempValue; }
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
            get { return _humdValue; }
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
            get { return _co2Value; }
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
            get { return _luxValue; }
            set { _luxValue = value; LuxUpdate(); }
        }
        private void LuxUpdate()
        {
            labelLux.Text = luxValue.ToString();
            labelLux.Left = luxPosition - labelLux.Width;

            panel3.Left = (int)Math.Round(Math.Log(luxValue + 5) * 42 + 8);
            m2.chart1.Series["Brightness"].Points.AddXY(time, luxValue);
        }




        private void serialPort1_DataReceived(Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String s = serialPort1.ReadLine();
            ParseWeatherString(s);
        }

        private void ParseWeatherString(String s)
        {
            if (s[0].Equals('S'))
            {
                Invoke(new Action(() =>
                {
                    int index = 1;
                    while (!s[index].Equals('E'))
                    {
                        if (s.Substring(index, 1).Equals("T"))
                        {
                            tempValue = Int16.Parse(s.Substring(++index, 3)) / 10f;
                            index += 3;
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
                        /*
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
                        } */
                    }
                }));
            }
        }
    }
}
