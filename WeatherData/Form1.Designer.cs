namespace Weatherdata
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bConnect = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.labelTemp = new System.Windows.Forms.Label();
			this.labelPress = new System.Windows.Forms.Label();
			this.labMMHG = new System.Windows.Forms.Label();
			this.bReload = new System.Windows.Forms.Button();
			this.labelHumd = new System.Windows.Forms.Label();
			this.bSettings = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.labelLux = new System.Windows.Forms.Label();
			this.labLUX = new System.Windows.Forms.Label();
			this.labPPM = new System.Windows.Forms.Label();
			this.labelCO2 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panelCO2 = new System.Windows.Forms.Panel();
			this.panelLux = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelTemp = new System.Windows.Forms.Panel();
			this.panelHumdZero = new System.Windows.Forms.Panel();
			this.panelHumdFull = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelDustM = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labelDustL = new System.Windows.Forms.Label();
			this.panel11 = new System.Windows.Forms.Panel();
			this.labelDustS = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel11.SuspendLayout();
			this.SuspendLayout();
			// 
			// bConnect
			// 
			this.bConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bConnect.Location = new System.Drawing.Point(184, 586);
			this.bConnect.Name = "bConnect";
			this.bConnect.Size = new System.Drawing.Size(73, 25);
			this.bConnect.TabIndex = 1;
			this.bConnect.Text = "Connect";
			this.bConnect.UseVisualStyleBackColor = true;
			this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(90, 588);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(88, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// labelTemp
			// 
			this.labelTemp.AutoSize = true;
			this.labelTemp.Font = new System.Drawing.Font("Maiandra GD", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTemp.Location = new System.Drawing.Point(50, 78);
			this.labelTemp.Name = "labelTemp";
			this.labelTemp.Size = new System.Drawing.Size(193, 85);
			this.labelTemp.TabIndex = 5;
			this.labelTemp.Text = "--.-°C";
			// 
			// labelPress
			// 
			this.labelPress.AutoSize = true;
			this.labelPress.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPress.Location = new System.Drawing.Point(481, 129);
			this.labelPress.Margin = new System.Windows.Forms.Padding(0);
			this.labelPress.Name = "labelPress";
			this.labelPress.Size = new System.Drawing.Size(93, 77);
			this.labelPress.TabIndex = 11;
			this.labelPress.Text = "---";
			// 
			// labMMHG
			// 
			this.labMMHG.AutoSize = true;
			this.labMMHG.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labMMHG.Location = new System.Drawing.Point(565, 170);
			this.labMMHG.Name = "labMMHG";
			this.labMMHG.Size = new System.Drawing.Size(63, 19);
			this.labMMHG.TabIndex = 13;
			this.labMMHG.Text = "mm Hg";
			// 
			// bReload
			// 
			this.bReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bReload.Location = new System.Drawing.Point(7, 588);
			this.bReload.Name = "bReload";
			this.bReload.Size = new System.Drawing.Size(75, 23);
			this.bReload.TabIndex = 14;
			this.bReload.Text = "reload";
			this.bReload.UseVisualStyleBackColor = true;
			this.bReload.Click += new System.EventHandler(this.bReload_Click);
			// 
			// labelHumd
			// 
			this.labelHumd.AutoSize = true;
			this.labelHumd.Font = new System.Drawing.Font("Maiandra GD", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHumd.Location = new System.Drawing.Point(797, 78);
			this.labelHumd.Name = "labelHumd";
			this.labelHumd.Size = new System.Drawing.Size(152, 85);
			this.labelHumd.TabIndex = 17;
			this.labelHumd.Text = "--%";
			// 
			// bSettings
			// 
			this.bSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bSettings.Location = new System.Drawing.Point(569, 561);
			this.bSettings.Name = "bSettings";
			this.bSettings.Size = new System.Drawing.Size(146, 48);
			this.bSettings.TabIndex = 20;
			this.bSettings.Text = "Налаштування";
			this.bSettings.UseVisualStyleBackColor = true;
			this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(379, 561);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(177, 48);
			this.button5.TabIndex = 21;
			this.button5.Text = "Графік";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.bChart_Click);
			// 
			// labelLux
			// 
			this.labelLux.AutoSize = true;
			this.labelLux.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLux.Location = new System.Drawing.Point(217, 303);
			this.labelLux.Margin = new System.Windows.Forms.Padding(0);
			this.labelLux.Name = "labelLux";
			this.labelLux.Size = new System.Drawing.Size(93, 77);
			this.labelLux.TabIndex = 25;
			this.labelLux.Text = "---";
			this.labelLux.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labLUX
			// 
			this.labLUX.AutoSize = true;
			this.labLUX.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLUX.Location = new System.Drawing.Point(301, 361);
			this.labLUX.Name = "labLUX";
			this.labLUX.Size = new System.Drawing.Size(30, 19);
			this.labLUX.TabIndex = 26;
			this.labLUX.Text = "lux";
			// 
			// labPPM
			// 
			this.labPPM.AutoSize = true;
			this.labPPM.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPPM.Location = new System.Drawing.Point(793, 361);
			this.labPPM.Name = "labPPM";
			this.labPPM.Size = new System.Drawing.Size(41, 19);
			this.labPPM.TabIndex = 30;
			this.labPPM.Text = "ppm";
			// 
			// labelCO2
			// 
			this.labelCO2.AutoSize = true;
			this.labelCO2.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCO2.Location = new System.Drawing.Point(709, 303);
			this.labelCO2.Margin = new System.Windows.Forms.Padding(0);
			this.labelCO2.Name = "labelCO2";
			this.labelCO2.Size = new System.Drawing.Size(93, 77);
			this.labelCO2.TabIndex = 29;
			this.labelCO2.Text = "---";
			this.labelCO2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// serialPort1
			// 
			this.serialPort1.RtsEnable = true;
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(926, 583);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 29);
			this.button1.TabIndex = 40;
			this.button1.Text = "Random data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.bRandom_Click);
			// 
			// panel10
			// 
			this.panel10.BackgroundImage = global::Weatherdata.Properties.Resources.sun1;
			this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel10.Location = new System.Drawing.Point(649, 32);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(52, 52);
			this.panel10.TabIndex = 39;
			// 
			// panel9
			// 
			this.panel9.BackgroundImage = global::Weatherdata.Properties.Resources.Cloud2;
			this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel9.Location = new System.Drawing.Point(332, 41);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(60, 32);
			this.panel9.TabIndex = 38;
			// 
			// panel8
			// 
			this.panel8.BackgroundImage = global::Weatherdata.Properties.Resources.co2;
			this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel8.Location = new System.Drawing.Point(910, 244);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(90, 92);
			this.panel8.TabIndex = 37;
			// 
			// panel5
			// 
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel5.Location = new System.Drawing.Point(11, 258);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(60, 60);
			this.panel5.TabIndex = 0;
			// 
			// panelCO2
			// 
			this.panelCO2.BackgroundImage = global::Weatherdata.Properties.Resources.PresArrowDown;
			this.panelCO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelCO2.Location = new System.Drawing.Point(671, 258);
			this.panelCO2.Name = "panelCO2";
			this.panelCO2.Size = new System.Drawing.Size(29, 19);
			this.panelCO2.TabIndex = 36;
			this.panelCO2.Visible = false;
			// 
			// panelLux
			// 
			this.panelLux.BackgroundImage = global::Weatherdata.Properties.Resources.PresArrowDown;
			this.panelLux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelLux.Location = new System.Drawing.Point(278, 258);
			this.panelLux.Name = "panelLux";
			this.panelLux.Size = new System.Drawing.Size(29, 19);
			this.panelLux.TabIndex = 35;
			this.panelLux.Visible = false;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.GreenYellow;
			this.panel7.BackgroundImage = global::Weatherdata.Properties.Resources.co2Geradient;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Location = new System.Drawing.Point(542, 277);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(347, 26);
			this.panel7.TabIndex = 33;
			// 
			// panel6
			// 
			this.panel6.BackgroundImage = global::Weatherdata.Properties.Resources.LuxGeradient;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Location = new System.Drawing.Point(91, 277);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(323, 27);
			this.panel6.TabIndex = 32;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = global::Weatherdata.Properties.Resources.PressScale;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new System.Drawing.Point(336, 58);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(362, 108);
			this.panel2.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::Weatherdata.Properties.Resources.therm;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Controls.Add(this.panelTemp);
			this.panel1.Location = new System.Drawing.Point(12, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(42, 106);
			this.panel1.TabIndex = 10;
			// 
			// panelTemp
			// 
			this.panelTemp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelTemp.Location = new System.Drawing.Point(18, 35);
			this.panelTemp.Name = "panelTemp";
			this.panelTemp.Size = new System.Drawing.Size(5, 42);
			this.panelTemp.TabIndex = 22;
			// 
			// panelHumdZero
			// 
			this.panelHumdZero.BackColor = System.Drawing.SystemColors.Control;
			this.panelHumdZero.BackgroundImage = global::Weatherdata.Properties.Resources.WaterDropletSmall;
			this.panelHumdZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelHumdZero.Location = new System.Drawing.Point(945, 78);
			this.panelHumdZero.Name = "panelHumdZero";
			this.panelHumdZero.Size = new System.Drawing.Size(41, 80);
			this.panelHumdZero.TabIndex = 34;
			// 
			// panelHumdFull
			// 
			this.panelHumdFull.BackColor = System.Drawing.SystemColors.Control;
			this.panelHumdFull.BackgroundImage = global::Weatherdata.Properties.Resources.WaterDropletFull1;
			this.panelHumdFull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelHumdFull.Location = new System.Drawing.Point(945, 78);
			this.panelHumdFull.Name = "panelHumdFull";
			this.panelHumdFull.Size = new System.Drawing.Size(41, 80);
			this.panelHumdFull.TabIndex = 35;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel3.Controls.Add(this.labelDustM);
			this.panel3.Location = new System.Drawing.Point(376, 421);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(260, 71);
			this.panel3.TabIndex = 41;
			// 
			// labelDustM
			// 
			this.labelDustM.AutoSize = true;
			this.labelDustM.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDustM.Location = new System.Drawing.Point(82, 6);
			this.labelDustM.Margin = new System.Windows.Forms.Padding(0);
			this.labelDustM.Name = "labelDustM";
			this.labelDustM.Size = new System.Drawing.Size(98, 57);
			this.labelDustM.TabIndex = 25;
			this.labelDustM.Text = "128";
			this.labelDustM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel4.Controls.Add(this.labelDustL);
			this.panel4.Location = new System.Drawing.Point(642, 421);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(260, 71);
			this.panel4.TabIndex = 42;
			// 
			// labelDustL
			// 
			this.labelDustL.AutoSize = true;
			this.labelDustL.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDustL.Location = new System.Drawing.Point(96, 6);
			this.labelDustL.Margin = new System.Windows.Forms.Padding(0);
			this.labelDustL.Name = "labelDustL";
			this.labelDustL.Size = new System.Drawing.Size(79, 57);
			this.labelDustL.TabIndex = 25;
			this.labelDustL.Text = "64";
			this.labelDustL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel11.Controls.Add(this.labelDustS);
			this.panel11.Location = new System.Drawing.Point(111, 421);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(260, 71);
			this.panel11.TabIndex = 42;
			// 
			// labelDustS
			// 
			this.labelDustS.AutoSize = true;
			this.labelDustS.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDustS.Location = new System.Drawing.Point(79, 6);
			this.labelDustS.Margin = new System.Windows.Forms.Padding(0);
			this.labelDustS.Name = "labelDustS";
			this.labelDustS.Size = new System.Drawing.Size(106, 57);
			this.labelDustS.TabIndex = 25;
			this.labelDustS.Text = "256";
			this.labelDustS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 617);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel10);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panelCO2);
			this.Controls.Add(this.panelLux);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.labPPM);
			this.Controls.Add(this.labelCO2);
			this.Controls.Add(this.labLUX);
			this.Controls.Add(this.labMMHG);
			this.Controls.Add(this.labelLux);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.bSettings);
			this.Controls.Add(this.labelPress);
			this.Controls.Add(this.bReload);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labelTemp);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.bConnect);
			this.Controls.Add(this.panelHumdZero);
			this.Controls.Add(this.panelHumdFull);
			this.Controls.Add(this.labelHumd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		internal System.Windows.Forms.Button bConnect;
		internal System.Windows.Forms.ComboBox comboBox1;
		internal System.Windows.Forms.Label labelTemp;
		internal System.Windows.Forms.Panel panel1;
		internal System.Windows.Forms.Label labelPress;
		internal System.Windows.Forms.Panel panel2;
		internal System.Windows.Forms.Label labMMHG;
		internal System.Windows.Forms.Button bReload;
		internal System.Windows.Forms.Label labelHumd;
		internal System.Windows.Forms.Button bSettings;
		internal System.Windows.Forms.Button button5;
		internal System.Windows.Forms.Panel panelTemp;
		internal System.Windows.Forms.Label labelLux;
		internal System.Windows.Forms.Label labLUX;
		internal System.Windows.Forms.Label labPPM;
		internal System.Windows.Forms.Label labelCO2;
		internal System.Windows.Forms.Panel panel6;
		internal System.Windows.Forms.Panel panel7;
		internal System.Windows.Forms.Panel panelLux;
		internal System.Windows.Forms.Panel panelCO2;
		internal System.Windows.Forms.Panel panelHumdZero;
		internal System.Windows.Forms.Panel panelHumdFull;
		internal System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		internal System.Windows.Forms.Panel panel5;
		internal System.Windows.Forms.Panel panel8;
		internal System.Windows.Forms.Panel panel9;
		internal System.Windows.Forms.Panel panel10;
		internal System.Windows.Forms.Button button1;
		internal System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Panel panel3;
		internal System.Windows.Forms.Label labelDustM;
		private System.Windows.Forms.Panel panel4;
		internal System.Windows.Forms.Label labelDustL;
		private System.Windows.Forms.Panel panel11;
		internal System.Windows.Forms.Label labelDustS;
	}
}

