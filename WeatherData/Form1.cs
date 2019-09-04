using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Weatherdata1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics g;
        private int luxPosition, pressPosition, co2Position, humdPosition; //labels
        private void Form1_Load(Object sender, EventArgs e)
        {
            g = panel2.CreateGraphics();
            luxPosition = labelLux.Left + labelLux.Width;
            pressPosition = labelPress.Left + labelPress.Width;
            co2Position = labelCO2.Left + labelCO2.Width;
            humdPosition = labelHumd.Left + labelHumd.Width;

            
            serialPort1.PortName = SerialPort.GetPortNames()[0];
            serialPort1.Open();
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
            button1_Click(null, null); //draw arrow
            labelPress.Left = pressPosition - labelPress.Width;
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
            panel4.Left = (int)Math.Round(Math.Log(co2Value - 300) * 89 + 168);
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

            panel3.Left = (int)Math.Round(Math.Log(luxValue + 5) * 44 - 34);
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
                MessageBox.Show(s);
            }
        }
    }
}
