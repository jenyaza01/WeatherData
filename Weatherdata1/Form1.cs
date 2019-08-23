using System;
using System.Drawing;
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

        int luxPosition, pressPosition, co2Position ;
        private void Form1_Load(Object sender, EventArgs e)
        {
            g = panel2.CreateGraphics();
            luxPosition = labelLux.Left + labelLux.Width;
            pressPosition = labelPress.Left + labelPress.Width;
            co2Position = labelCO2.Left + labelCO2.Width;
        }


        private static Bitmap RotateImage(Bitmap bmp, float angle)
        {
            float alpha = angle;

            //edit: negative angle +360
            while (alpha < 0) alpha += 360;

            float gamma = 90;
            float beta = 180 - angle - gamma;

            float c1 = bmp.Height;
            float a1 = (float)(c1 * Math.Sin(alpha * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));
            float b1 = (float)(c1 * Math.Sin(beta * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));

            float c2 = bmp.Width;
            float a2 = (float)(c2 * Math.Sin(alpha * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));
            float b2 = (float)(c2 * Math.Sin(beta * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));

            int width = Convert.ToInt32(b2 + a1);
            int height = Convert.ToInt32(b1 + a2);

            Bitmap rotatedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(angle); //rotate
                g.TranslateTransform(-rotatedImage.Width / 2, -rotatedImage.Height / 2); //restore rotation point into the matrix
                g.DrawImage(bmp, new Point((width - bmp.Width) / 2, (height - bmp.Height) / 2)); //draw the image on the new bitmap
            }
            return rotatedImage;
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            Point p = new Point();
            if (pressValue < 745)
                p.X = (int)Math.Round(0.0500037031 * Math.Pow(pressValue, 2) - 66.5063538402 * pressValue + 21975.2919826508);
            else
                p.X = (int)Math.Round(-0.0378580329 * Math.Pow(pressValue, 2) + 64.1265076250 * pressValue - 26582.0598220825);
            p.Y = (int)(262 - 243 * Math.Sin((pressValue + 712.7) / 32));
            g.DrawLine(new Pen(Color.Gray, 3), p, new Point(180, 220));
        }

        private void panel2_MouseMove(Object sender, MouseEventArgs e)
        {
            button1.Text = e.X.ToString() + " x " + e.Y.ToString();
        }



        private float pressValue = 770;
        private void hScrollBar1_ValueChanged(Object sender, EventArgs e)
        {
            panel2.Invalidate();
            Application.DoEvents();
            pressValue = hScrollBar1.Value / 10f;
            labelPress.Text = pressValue.ToString("000");
            button1_Click(null, null); //draw arrow
            labelPress.Left = pressPosition - labelPress.Width;
        }


        private float tempValue = 21.3f;
        private void hScrollBar2_ValueChanged(Object sender, EventArgs e)
        {
            tempValue = hScrollBar2.Value / 10f;
            labelTemp.Text = tempValue.ToString("00.0°C");
            panelTemp.Top = (int)Math.Round(81 - tempValue * 1.5f);
            panelTemp.Height = (int)Math.Round(tempValue * 1.5f);
        }


        private float humdValue;
        private void hScrollBar3_ValueChanged(Object sender, EventArgs e)
        {
            humdValue = hScrollBar3.Value / 10f;
            labelHumd.Text = Math.Round(humdValue).ToString() + "%";

        }

        private int co2Value;
        private void hScrollBar5_ValueChanged(Object sender, EventArgs e)
        {
            co2Value = hScrollBar5.Value;
            labelCO2.Text = co2Value.ToString();
            labelCO2.Left =  co2Position - labelCO2.Width;
            panelCO2.Width = (int)Math.Round(Math.Log(co2Value-250)*117-581);
        }

        private int luxValue;
        private void hScrollBar4_ValueChanged(Object sender, EventArgs e)
        {
            luxValue = hScrollBar4.Value;
            labelLux.Text = luxValue.ToString();
            labelLux.Left = luxPosition - labelLux.Width;
            panelLux.Width = (int)Math.Round(Math.Log(luxValue+5)*44 - 69);
        }
    }
}
