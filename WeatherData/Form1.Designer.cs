namespace Weatherdata1
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelPress = new System.Windows.Forms.Label();
            this.labMMHG = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.labelHumd = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelLux = new System.Windows.Forms.Label();
            this.labLUX = new System.Windows.Forms.Label();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.labPPM = new System.Windows.Forms.Label();
            this.hScrollBar5 = new System.Windows.Forms.HScrollBar();
            this.labelCO2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.panelHumdFull = new System.Windows.Forms.Panel();
            this.panelHumdZero = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(189, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 598);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "COM";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Maiandra GD", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(50, 78);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(235, 85);
            this.labelTemp.TabIndex = 5;
            this.labelTemp.Text = "21.2°C";
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPress.Location = new System.Drawing.Point(437, 128);
            this.labelPress.Margin = new System.Windows.Forms.Padding(0);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(141, 77);
            this.labelPress.TabIndex = 11;
            this.labelPress.Text = "745";
            // 
            // labMMHG
            // 
            this.labMMHG.AutoSize = true;
            this.labMMHG.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMMHG.Location = new System.Drawing.Point(565, 169);
            this.labMMHG.Name = "labMMHG";
            this.labMMHG.Size = new System.Drawing.Size(63, 19);
            this.labMMHG.TabIndex = 13;
            this.labMMHG.Text = "mm Hg";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(372, 206);
            this.hScrollBar1.Maximum = 7700;
            this.hScrollBar1.Minimum = 7200;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(281, 22);
            this.hScrollBar1.TabIndex = 15;
            this.hScrollBar1.Value = 7450;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(12, 176);
            this.hScrollBar2.Maximum = 450;
            this.hScrollBar2.Minimum = 100;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(283, 22);
            this.hScrollBar2.TabIndex = 16;
            this.hScrollBar2.Value = 212;
            // 
            // labelHumd
            // 
            this.labelHumd.AutoSize = true;
            this.labelHumd.Font = new System.Drawing.Font("Maiandra GD", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumd.Location = new System.Drawing.Point(764, 78);
            this.labelHumd.Name = "labelHumd";
            this.labelHumd.Size = new System.Drawing.Size(188, 85);
            this.labelHumd.TabIndex = 17;
            this.labelHumd.Text = "54%";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(751, 166);
            this.hScrollBar3.Maximum = 990;
            this.hScrollBar3.Minimum = 10;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(227, 22);
            this.hScrollBar3.TabIndex = 18;
            this.hScrollBar3.Value = 540;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(411, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(835, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 48);
            this.button4.TabIndex = 20;
            this.button4.Text = "settings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(663, 552);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 48);
            this.button5.TabIndex = 21;
            this.button5.Text = "chart";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // labelLux
            // 
            this.labelLux.AutoSize = true;
            this.labelLux.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLux.Location = new System.Drawing.Point(169, 321);
            this.labelLux.Margin = new System.Windows.Forms.Padding(0);
            this.labelLux.Name = "labelLux";
            this.labelLux.Size = new System.Drawing.Size(105, 77);
            this.labelLux.TabIndex = 25;
            this.labelLux.Text = "96";
            this.labelLux.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLUX
            // 
            this.labLUX.AutoSize = true;
            this.labLUX.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLUX.Location = new System.Drawing.Point(264, 366);
            this.labLUX.Name = "labLUX";
            this.labLUX.Size = new System.Drawing.Size(30, 19);
            this.labLUX.TabIndex = 26;
            this.labLUX.Text = "lux";
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.LargeChange = 1;
            this.hScrollBar4.Location = new System.Drawing.Point(12, 390);
            this.hScrollBar4.Maximum = 9999;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(427, 22);
            this.hScrollBar4.TabIndex = 27;
            this.hScrollBar4.Value = 96;
            // 
            // labPPM
            // 
            this.labPPM.AutoSize = true;
            this.labPPM.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPPM.Location = new System.Drawing.Point(787, 366);
            this.labPPM.Name = "labPPM";
            this.labPPM.Size = new System.Drawing.Size(41, 19);
            this.labPPM.TabIndex = 30;
            this.labPPM.Text = "ppm";
            // 
            // hScrollBar5
            // 
            this.hScrollBar5.LargeChange = 1;
            this.hScrollBar5.Location = new System.Drawing.Point(469, 385);
            this.hScrollBar5.Maximum = 5000;
            this.hScrollBar5.Minimum = 400;
            this.hScrollBar5.Name = "hScrollBar5";
            this.hScrollBar5.Size = new System.Drawing.Size(534, 22);
            this.hScrollBar5.TabIndex = 31;
            this.hScrollBar5.Value = 670;
            // 
            // labelCO2
            // 
            this.labelCO2.AutoSize = true;
            this.labelCO2.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCO2.Location = new System.Drawing.Point(650, 321);
            this.labelCO2.Margin = new System.Windows.Forms.Padding(0);
            this.labelCO2.Name = "labelCO2";
            this.labelCO2.Size = new System.Drawing.Size(143, 77);
            this.labelCO2.TabIndex = 29;
            this.labelCO2.Text = "670";
            this.labelCO2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(704, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 19);
            this.panel4.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(232, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 19);
            this.panel3.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GreenYellow;
            this.panel7.BackgroundImage = global::Weatherdata.Properties.Resources.co2Geradient;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(523, 291);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(418, 26);
            this.panel7.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(46, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(344, 27);
            this.panel6.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(336, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 108);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
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
            // serialPort1
            // 
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 625);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.labPPM);
            this.Controls.Add(this.hScrollBar5);
            this.Controls.Add(this.labelCO2);
            this.Controls.Add(this.labLUX);
            this.Controls.Add(this.labMMHG);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.labelLux);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelHumdZero);
            this.Controls.Add(this.panelHumdFull);
            this.Controls.Add(this.labelHumd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labMMHG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label labelHumd;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Label labelLux;
        private System.Windows.Forms.Label labLUX;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Label labPPM;
        private System.Windows.Forms.HScrollBar hScrollBar5;
        private System.Windows.Forms.Label labelCO2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelHumdZero;
        private System.Windows.Forms.Panel panelHumdFull;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

