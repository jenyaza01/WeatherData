namespace Weatherdata
{
	partial class FormSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.cTemp = new System.Windows.Forms.CheckBox();
            this.cHumid = new System.Windows.Forms.CheckBox();
            this.cIon = new System.Windows.Forms.CheckBox();
            this.cPressure = new System.Windows.Forms.CheckBox();
            this.cCO2 = new System.Windows.Forms.CheckBox();
            this.cBrightness = new System.Windows.Forms.CheckBox();
            this.gbInputTypes = new System.Windows.Forms.GroupBox();
            this.cDust = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPeriodMinutes = new System.Windows.Forms.RadioButton();
            this.rbPeriodSeconds = new System.Windows.Forms.RadioButton();
            this.numRefRate = new System.Windows.Forms.NumericUpDown();
            this.numMeasureTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTotalTimeHours = new System.Windows.Forms.RadioButton();
            this.rbTotalTimeMinutes = new System.Windows.Forms.RadioButton();
            this.bSetMeasureTime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bСalibrationSend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IonB = new System.Windows.Forms.TextBox();
            this.CO2B = new System.Windows.Forms.TextBox();
            this.BrtnB = new System.Windows.Forms.TextBox();
            this.PresB = new System.Windows.Forms.TextBox();
            this.HumdB = new System.Windows.Forms.TextBox();
            this.TempB = new System.Windows.Forms.TextBox();
            this.IonA = new System.Windows.Forms.TextBox();
            this.CO2A = new System.Windows.Forms.TextBox();
            this.BrtnA = new System.Windows.Forms.TextBox();
            this.PresA = new System.Windows.Forms.TextBox();
            this.HumdA = new System.Windows.Forms.TextBox();
            this.TempA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bShowMore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbInputTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasureTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            //
            // cTemp
            //
            this.cTemp.AutoSize = true;
            this.cTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTemp.Location = new System.Drawing.Point(6, 25);
            this.cTemp.Name = "cTemp";
            this.cTemp.Size = new System.Drawing.Size(103, 19);
            this.cTemp.TabIndex = 0;
            this.cTemp.Text = "Температура";
            this.cTemp.UseVisualStyleBackColor = true;
            this.cTemp.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // cHumid
            //
            this.cHumid.AutoSize = true;
            this.cHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cHumid.Location = new System.Drawing.Point(6, 48);
            this.cHumid.Name = "cHumid";
            this.cHumid.Size = new System.Drawing.Size(83, 19);
            this.cHumid.TabIndex = 2;
            this.cHumid.Text = "Вологість";
            this.cHumid.UseVisualStyleBackColor = true;
            this.cHumid.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // cIon
            //
            this.cIon.AutoSize = true;
            this.cIon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cIon.Location = new System.Drawing.Point(6, 163);
            this.cIon.Name = "cIon";
            this.cIon.Size = new System.Drawing.Size(101, 19);
            this.cIon.TabIndex = 4;
            this.cIon.Text = "Іонний заряд";
            this.cIon.UseVisualStyleBackColor = true;
            this.cIon.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // cPressure
            //
            this.cPressure.AutoSize = true;
            this.cPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cPressure.Location = new System.Drawing.Point(6, 71);
            this.cPressure.Name = "cPressure";
            this.cPressure.Size = new System.Drawing.Size(81, 19);
            this.cPressure.TabIndex = 4;
            this.cPressure.Text = "Атм. тиск";
            this.cPressure.UseVisualStyleBackColor = true;
            this.cPressure.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // cCO2
            //
            this.cCO2.AutoSize = true;
            this.cCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCO2.Location = new System.Drawing.Point(6, 117);
            this.cCO2.Name = "cCO2";
            this.cCO2.Size = new System.Drawing.Size(86, 19);
            this.cCO2.TabIndex = 4;
            this.cCO2.Text = "Вміст CO2";
            this.cCO2.UseVisualStyleBackColor = true;
            this.cCO2.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // cBrightness
            //
            this.cBrightness.AutoSize = true;
            this.cBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBrightness.Location = new System.Drawing.Point(6, 94);
            this.cBrightness.Name = "cBrightness";
            this.cBrightness.Size = new System.Drawing.Size(102, 19);
            this.cBrightness.TabIndex = 4;
            this.cBrightness.Text = "Освітленість";
            this.cBrightness.UseVisualStyleBackColor = true;
            this.cBrightness.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // gbInputTypes
            //
            this.gbInputTypes.Controls.Add(this.cDust);
            this.gbInputTypes.Controls.Add(this.cIon);
            this.gbInputTypes.Controls.Add(this.cHumid);
            this.gbInputTypes.Controls.Add(this.cTemp);
            this.gbInputTypes.Controls.Add(this.cPressure);
            this.gbInputTypes.Controls.Add(this.cBrightness);
            this.gbInputTypes.Controls.Add(this.cCO2);
            this.gbInputTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInputTypes.Location = new System.Drawing.Point(12, 6);
            this.gbInputTypes.Name = "gbInputTypes";
            this.gbInputTypes.Size = new System.Drawing.Size(148, 191);
            this.gbInputTypes.TabIndex = 0;
            this.gbInputTypes.TabStop = false;
            this.gbInputTypes.Text = "Запис вимірювань";
            //
            // cDust
            //
            this.cDust.AutoSize = true;
            this.cDust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cDust.Location = new System.Drawing.Point(6, 140);
            this.cDust.Name = "cDust";
            this.cDust.Size = new System.Drawing.Size(49, 19);
            this.cDust.TabIndex = 14;
            this.cDust.Text = "Пил";
            this.cDust.UseVisualStyleBackColor = true;
            this.cDust.CheckedChanged += new System.EventHandler(this.DataSource_CheckedChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Періодичність";
            //
            // rbPeriodMinutes
            //
            this.rbPeriodMinutes.AutoSize = true;
            this.rbPeriodMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPeriodMinutes.Location = new System.Drawing.Point(82, 22);
            this.rbPeriodMinutes.Name = "rbPeriodMinutes";
            this.rbPeriodMinutes.Size = new System.Drawing.Size(40, 20);
            this.rbPeriodMinutes.TabIndex = 9;
            this.rbPeriodMinutes.Text = "хв";
            this.rbPeriodMinutes.UseVisualStyleBackColor = true;
            this.rbPeriodMinutes.CheckedChanged += new System.EventHandler(this.radioButtMinutes_CheckedChanged);
            //
            // rbPeriodSeconds
            //
            this.rbPeriodSeconds.AutoSize = true;
            this.rbPeriodSeconds.Checked = true;
            this.rbPeriodSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPeriodSeconds.Location = new System.Drawing.Point(82, 44);
            this.rbPeriodSeconds.Name = "rbPeriodSeconds";
            this.rbPeriodSeconds.Size = new System.Drawing.Size(48, 20);
            this.rbPeriodSeconds.TabIndex = 10;
            this.rbPeriodSeconds.TabStop = true;
            this.rbPeriodSeconds.Text = "сек";
            this.rbPeriodSeconds.UseVisualStyleBackColor = true;
            this.rbPeriodSeconds.CheckedChanged += new System.EventHandler(this.rbPeriodSeconds_CheckedChanged);
            //
            // numRefRate
            //
            this.numRefRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRefRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRefRate.Location = new System.Drawing.Point(11, 35);
            this.numRefRate.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numRefRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRefRate.Name = "numRefRate";
            this.numRefRate.Size = new System.Drawing.Size(53, 24);
            this.numRefRate.TabIndex = 5;
            this.numRefRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRefRate.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            //
            // numMeasureTime
            //
            this.numMeasureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMeasureTime.Location = new System.Drawing.Point(11, 37);
            this.numMeasureTime.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.numMeasureTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeasureTime.Name = "numMeasureTime";
            this.numMeasureTime.Size = new System.Drawing.Size(53, 24);
            this.numMeasureTime.TabIndex = 5;
            this.numMeasureTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeasureTime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Час вимірювання";
            //
            // rbTotalTimeHours
            //
            this.rbTotalTimeHours.AutoSize = true;
            this.rbTotalTimeHours.Checked = true;
            this.rbTotalTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTotalTimeHours.Location = new System.Drawing.Point(82, 28);
            this.rbTotalTimeHours.Name = "rbTotalTimeHours";
            this.rbTotalTimeHours.Size = new System.Drawing.Size(48, 20);
            this.rbTotalTimeHours.TabIndex = 9;
            this.rbTotalTimeHours.TabStop = true;
            this.rbTotalTimeHours.Text = "год";
            this.rbTotalTimeHours.UseVisualStyleBackColor = true;
            //
            // rbTotalTimeMinutes
            //
            this.rbTotalTimeMinutes.AutoSize = true;
            this.rbTotalTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTotalTimeMinutes.Location = new System.Drawing.Point(82, 50);
            this.rbTotalTimeMinutes.Name = "rbTotalTimeMinutes";
            this.rbTotalTimeMinutes.Size = new System.Drawing.Size(40, 20);
            this.rbTotalTimeMinutes.TabIndex = 10;
            this.rbTotalTimeMinutes.Text = "хв";
            this.rbTotalTimeMinutes.UseVisualStyleBackColor = true;
            this.rbTotalTimeMinutes.CheckedChanged += new System.EventHandler(this.rbPeriodSeconds_CheckedChanged);
            //
            // bSetMeasureTime
            //
            this.bSetMeasureTime.BackColor = System.Drawing.Color.Gray;
            this.bSetMeasureTime.Location = new System.Drawing.Point(167, 169);
            this.bSetMeasureTime.Name = "bSetMeasureTime";
            this.bSetMeasureTime.Size = new System.Drawing.Size(139, 60);
            this.bSetMeasureTime.TabIndex = 11;
            this.bSetMeasureTime.Text = "Встановити (00:00)";
            this.bSetMeasureTime.UseVisualStyleBackColor = false;
            this.bSetMeasureTime.Click += new System.EventHandler(this.bSetMeasureTime_Click);
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bСalibrationSend);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.IonB);
            this.groupBox2.Controls.Add(this.CO2B);
            this.groupBox2.Controls.Add(this.BrtnB);
            this.groupBox2.Controls.Add(this.PresB);
            this.groupBox2.Controls.Add(this.HumdB);
            this.groupBox2.Controls.Add(this.TempB);
            this.groupBox2.Controls.Add(this.IonA);
            this.groupBox2.Controls.Add(this.CO2A);
            this.groupBox2.Controls.Add(this.BrtnA);
            this.groupBox2.Controls.Add(this.PresA);
            this.groupBox2.Controls.Add(this.HumdA);
            this.groupBox2.Controls.Add(this.TempA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(347, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 207);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Калібровка       множник      доданок";
            //
            // button1
            //
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Прочитати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // bСalibrationSend
            //
            this.bСalibrationSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bСalibrationSend.Enabled = false;
            this.bСalibrationSend.Location = new System.Drawing.Point(118, 176);
            this.bСalibrationSend.Name = "bСalibrationSend";
            this.bСalibrationSend.Size = new System.Drawing.Size(118, 31);
            this.bСalibrationSend.TabIndex = 12;
            this.bСalibrationSend.Text = "Записати";
            this.bСalibrationSend.UseVisualStyleBackColor = true;
            this.bСalibrationSend.Click += new System.EventHandler(this.bСalibrationSend_Click);
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Іонний заряд";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Вміст СО2";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Освітленість";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Атм. тиск";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Вологість";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Температура";
            //
            // IonB
            //
            this.IonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IonB.Location = new System.Drawing.Point(174, 144);
            this.IonB.Name = "IonB";
            this.IonB.Size = new System.Drawing.Size(62, 21);
            this.IonB.TabIndex = 13;
            this.IonB.Text = "0.0";
            this.IonB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IonB.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // CO2B
            //
            this.CO2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CO2B.Location = new System.Drawing.Point(174, 119);
            this.CO2B.Name = "CO2B";
            this.CO2B.Size = new System.Drawing.Size(62, 21);
            this.CO2B.TabIndex = 13;
            this.CO2B.Text = "0.0";
            this.CO2B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CO2B.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // BrtnB
            //
            this.BrtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrtnB.Location = new System.Drawing.Point(174, 95);
            this.BrtnB.Name = "BrtnB";
            this.BrtnB.Size = new System.Drawing.Size(62, 21);
            this.BrtnB.TabIndex = 13;
            this.BrtnB.Text = "0.0";
            this.BrtnB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BrtnB.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // PresB
            //
            this.PresB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PresB.Location = new System.Drawing.Point(174, 71);
            this.PresB.Name = "PresB";
            this.PresB.Size = new System.Drawing.Size(62, 21);
            this.PresB.TabIndex = 13;
            this.PresB.Text = "0.0";
            this.PresB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PresB.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // HumdB
            //
            this.HumdB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumdB.Location = new System.Drawing.Point(174, 46);
            this.HumdB.Name = "HumdB";
            this.HumdB.Size = new System.Drawing.Size(62, 21);
            this.HumdB.TabIndex = 13;
            this.HumdB.Text = "0.0";
            this.HumdB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HumdB.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // TempB
            //
            this.TempB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempB.Location = new System.Drawing.Point(174, 23);
            this.TempB.Name = "TempB";
            this.TempB.Size = new System.Drawing.Size(62, 21);
            this.TempB.TabIndex = 13;
            this.TempB.Text = "0.0";
            this.TempB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TempB.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // IonA
            //
            this.IonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IonA.Location = new System.Drawing.Point(101, 144);
            this.IonA.Name = "IonA";
            this.IonA.Size = new System.Drawing.Size(62, 21);
            this.IonA.TabIndex = 12;
            this.IonA.Text = "1.0";
            this.IonA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IonA.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // CO2A
            //
            this.CO2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CO2A.Location = new System.Drawing.Point(101, 119);
            this.CO2A.Name = "CO2A";
            this.CO2A.Size = new System.Drawing.Size(62, 21);
            this.CO2A.TabIndex = 12;
            this.CO2A.Text = "1.0";
            this.CO2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CO2A.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // BrtnA
            //
            this.BrtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrtnA.Location = new System.Drawing.Point(101, 95);
            this.BrtnA.Name = "BrtnA";
            this.BrtnA.Size = new System.Drawing.Size(62, 21);
            this.BrtnA.TabIndex = 12;
            this.BrtnA.Text = "1.0";
            this.BrtnA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BrtnA.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // PresA
            //
            this.PresA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PresA.Location = new System.Drawing.Point(101, 71);
            this.PresA.Name = "PresA";
            this.PresA.Size = new System.Drawing.Size(62, 21);
            this.PresA.TabIndex = 12;
            this.PresA.Text = "1.0";
            this.PresA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PresA.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // HumdA
            //
            this.HumdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumdA.Location = new System.Drawing.Point(101, 46);
            this.HumdA.Name = "HumdA";
            this.HumdA.Size = new System.Drawing.Size(62, 21);
            this.HumdA.TabIndex = 12;
            this.HumdA.Text = "1.0";
            this.HumdA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HumdA.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // TempA
            //
            this.TempA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TempA.Location = new System.Drawing.Point(101, 23);
            this.TempA.Name = "TempA";
            this.TempA.Size = new System.Drawing.Size(62, 21);
            this.TempA.TabIndex = 12;
            this.TempA.Text = "1.0";
            this.TempA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TempA.Leave += new System.EventHandler(this.TextBoxCalibration_Leave);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.numRefRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbPeriodMinutes);
            this.panel1.Controls.Add(this.rbPeriodSeconds);
            this.panel1.Location = new System.Drawing.Point(166, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 66);
            this.panel1.TabIndex = 5;
            //
            // timer1
            //
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // panel2
            //
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rbTotalTimeHours);
            this.panel2.Controls.Add(this.rbTotalTimeMinutes);
            this.panel2.Controls.Add(this.numMeasureTime);
            this.panel2.Location = new System.Drawing.Point(166, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 78);
            this.panel2.TabIndex = 12;
            //
            // bShowMore
            //
            this.bShowMore.Location = new System.Drawing.Point(18, 198);
            this.bShowMore.Name = "bShowMore";
            this.bShowMore.Size = new System.Drawing.Size(69, 29);
            this.bShowMore.TabIndex = 13;
            this.bShowMore.Text = ">>>";
            this.bShowMore.UseVisualStyleBackColor = true;
            this.bShowMore.Click += new System.EventHandler(this.bWidth_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(91, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "LCD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // FormSettings
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 241);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bShowMore);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bSetMeasureTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInputTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSettings";
            this.Text = "Settings -";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.gbInputTypes.ResumeLayout(false);
            this.gbInputTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasureTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.CheckBox cTemp;
		public System.Windows.Forms.CheckBox cHumid;
		public System.Windows.Forms.CheckBox cIon;
		public System.Windows.Forms.CheckBox cPressure;
		public System.Windows.Forms.CheckBox cCO2;
		public System.Windows.Forms.CheckBox cBrightness;
		public System.Windows.Forms.GroupBox gbInputTypes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbPeriodMinutes;
		private System.Windows.Forms.RadioButton rbPeriodSeconds;
		public System.Windows.Forms.NumericUpDown numRefRate;
		public System.Windows.Forms.NumericUpDown numMeasureTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbTotalTimeHours;
		private System.Windows.Forms.RadioButton rbTotalTimeMinutes;
		public System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox IonB;
		private System.Windows.Forms.TextBox CO2B;
		private System.Windows.Forms.TextBox BrtnB;
		private System.Windows.Forms.TextBox PresB;
		private System.Windows.Forms.TextBox HumdB;
		private System.Windows.Forms.TextBox TempB;
		private System.Windows.Forms.TextBox IonA;
		private System.Windows.Forms.TextBox CO2A;
		private System.Windows.Forms.TextBox BrtnA;
		private System.Windows.Forms.TextBox PresA;
		private System.Windows.Forms.TextBox HumdA;
		private System.Windows.Forms.TextBox TempA;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button bShowMore;
		public System.Windows.Forms.CheckBox cDust;
		internal System.Windows.Forms.Button bSetMeasureTime;
		internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button bСalibrationSend;
        private System.Windows.Forms.Button button2;
    }
}
