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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButtMinutes = new System.Windows.Forms.RadioButton();
			this.radioButtonSeconds = new System.Windows.Forms.RadioButton();
			this.numRefRate = new System.Windows.Forms.NumericUpDown();
			this.bRefRate = new System.Windows.Forms.Button();
			this.numMeasureTime = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButtonHours2 = new System.Windows.Forms.RadioButton();
			this.radioButtonMinutes2 = new System.Windows.Forms.RadioButton();
			this.bMeasureTime = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
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
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numRefRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMeasureTime)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.cTemp.CheckedChanged += new System.EventHandler(this.cTemp_CheckedChanged);
			// 
			// cHumid
			// 
			this.cHumid.AutoSize = true;
			this.cHumid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cHumid.Location = new System.Drawing.Point(6, 50);
			this.cHumid.Name = "cHumid";
			this.cHumid.Size = new System.Drawing.Size(83, 19);
			this.cHumid.TabIndex = 2;
			this.cHumid.Text = "Вологість";
			this.cHumid.UseVisualStyleBackColor = true;
			this.cHumid.CheckedChanged += new System.EventHandler(this.cHumid_CheckedChanged);
			// 
			// cIon
			// 
			this.cIon.AutoSize = true;
			this.cIon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cIon.Location = new System.Drawing.Point(6, 150);
			this.cIon.Name = "cIon";
			this.cIon.Size = new System.Drawing.Size(101, 19);
			this.cIon.TabIndex = 4;
			this.cIon.Text = "Іонний заряд";
			this.cIon.UseVisualStyleBackColor = true;
			this.cIon.CheckedChanged += new System.EventHandler(this.cIon_CheckedChanged);
			// 
			// cPressure
			// 
			this.cPressure.AutoSize = true;
			this.cPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cPressure.Location = new System.Drawing.Point(6, 75);
			this.cPressure.Name = "cPressure";
			this.cPressure.Size = new System.Drawing.Size(81, 19);
			this.cPressure.TabIndex = 4;
			this.cPressure.Text = "Атм. тиск";
			this.cPressure.UseVisualStyleBackColor = true;
			this.cPressure.CheckedChanged += new System.EventHandler(this.cPressure_CheckedChanged);
			// 
			// cCO2
			// 
			this.cCO2.AutoSize = true;
			this.cCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cCO2.Location = new System.Drawing.Point(6, 125);
			this.cCO2.Name = "cCO2";
			this.cCO2.Size = new System.Drawing.Size(86, 19);
			this.cCO2.TabIndex = 4;
			this.cCO2.Text = "Вміст CO2";
			this.cCO2.UseVisualStyleBackColor = true;
			this.cCO2.CheckedChanged += new System.EventHandler(this.cCO2_CheckedChanged);
			// 
			// cBrightness
			// 
			this.cBrightness.AutoSize = true;
			this.cBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cBrightness.Location = new System.Drawing.Point(6, 100);
			this.cBrightness.Name = "cBrightness";
			this.cBrightness.Size = new System.Drawing.Size(91, 19);
			this.cBrightness.TabIndex = 4;
			this.cBrightness.Text = "Яскравість";
			this.cBrightness.UseVisualStyleBackColor = true;
			this.cBrightness.CheckedChanged += new System.EventHandler(this.cBrightness_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cHumid);
			this.groupBox1.Controls.Add(this.cIon);
			this.groupBox1.Controls.Add(this.cTemp);
			this.groupBox1.Controls.Add(this.cPressure);
			this.groupBox1.Controls.Add(this.cBrightness);
			this.groupBox1.Controls.Add(this.cCO2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(167, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(148, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Запис вимірювань";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Період";
			// 
			// radioButtMinutes
			// 
			this.radioButtMinutes.AutoSize = true;
			this.radioButtMinutes.Checked = true;
			this.radioButtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButtMinutes.Location = new System.Drawing.Point(87, 22);
			this.radioButtMinutes.Name = "radioButtMinutes";
			this.radioButtMinutes.Size = new System.Drawing.Size(40, 20);
			this.radioButtMinutes.TabIndex = 9;
			this.radioButtMinutes.TabStop = true;
			this.radioButtMinutes.Text = "хв";
			this.radioButtMinutes.UseVisualStyleBackColor = true;
			// 
			// radioButtonSeconds
			// 
			this.radioButtonSeconds.AutoSize = true;
			this.radioButtonSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButtonSeconds.Location = new System.Drawing.Point(87, 44);
			this.radioButtonSeconds.Name = "radioButtonSeconds";
			this.radioButtonSeconds.Size = new System.Drawing.Size(48, 20);
			this.radioButtonSeconds.TabIndex = 10;
			this.radioButtonSeconds.Text = "сек";
			this.radioButtonSeconds.UseVisualStyleBackColor = true;
			this.radioButtonSeconds.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// numRefRate
			// 
			this.numRefRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numRefRate.Location = new System.Drawing.Point(11, 31);
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
            1,
            0,
            0,
            0});
			this.numRefRate.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// bRefRate
			// 
			this.bRefRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bRefRate.Location = new System.Drawing.Point(2, 70);
			this.bRefRate.Name = "bRefRate";
			this.bRefRate.Size = new System.Drawing.Size(137, 31);
			this.bRefRate.TabIndex = 11;
			this.bRefRate.Text = "Встановити (1 хв)";
			this.bRefRate.UseVisualStyleBackColor = true;
			this.bRefRate.Click += new System.EventHandler(this.bRefRate_Click);
			// 
			// numMeasureTime
			// 
			this.numMeasureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numMeasureTime.Location = new System.Drawing.Point(11, 146);
			this.numMeasureTime.Maximum = new decimal(new int[] {
            60,
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
			this.label2.Location = new System.Drawing.Point(12, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Час вимірювання";
			// 
			// radioButtonHours2
			// 
			this.radioButtonHours2.AutoSize = true;
			this.radioButtonHours2.Checked = true;
			this.radioButtonHours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButtonHours2.Location = new System.Drawing.Point(87, 137);
			this.radioButtonHours2.Name = "radioButtonHours2";
			this.radioButtonHours2.Size = new System.Drawing.Size(48, 20);
			this.radioButtonHours2.TabIndex = 9;
			this.radioButtonHours2.TabStop = true;
			this.radioButtonHours2.Text = "год";
			this.radioButtonHours2.UseVisualStyleBackColor = true;
			// 
			// radioButtonMinutes2
			// 
			this.radioButtonMinutes2.AutoSize = true;
			this.radioButtonMinutes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButtonMinutes2.Location = new System.Drawing.Point(87, 159);
			this.radioButtonMinutes2.Name = "radioButtonMinutes2";
			this.radioButtonMinutes2.Size = new System.Drawing.Size(40, 20);
			this.radioButtonMinutes2.TabIndex = 10;
			this.radioButtonMinutes2.Text = "хв";
			this.radioButtonMinutes2.UseVisualStyleBackColor = true;
			this.radioButtonMinutes2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// bMeasureTime
			// 
			this.bMeasureTime.Location = new System.Drawing.Point(3, 185);
			this.bMeasureTime.Name = "bMeasureTime";
			this.bMeasureTime.Size = new System.Drawing.Size(134, 31);
			this.bMeasureTime.TabIndex = 11;
			this.bMeasureTime.Text = "Встановити (00:00)";
			this.bMeasureTime.UseVisualStyleBackColor = true;
			this.bMeasureTime.Click += new System.EventHandler(this.bMeasureTime_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
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
			this.groupBox2.Location = new System.Drawing.Point(333, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(251, 213);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Калібровка       множник      доданок";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(9, 176);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(227, 31);
			this.button3.TabIndex = 12;
			this.button3.Text = "Встановити";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(6, 151);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "Іонний заряд";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(6, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 15);
			this.label7.TabIndex = 18;
			this.label7.Text = "Вміст СО2";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(6, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 15);
			this.label6.TabIndex = 17;
			this.label6.Text = "Яскравість";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(6, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 15);
			this.label5.TabIndex = 16;
			this.label5.Text = "Атм. тиск";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(6, 51);
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
			this.IonB.Location = new System.Drawing.Point(174, 148);
			this.IonB.Name = "IonB";
			this.IonB.Size = new System.Drawing.Size(62, 22);
			this.IonB.TabIndex = 13;
			this.IonB.Text = "0.0";
			this.IonB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.IonB.Leave += new System.EventHandler(this.FixChanged);
			// 
			// CO2B
			// 
			this.CO2B.Location = new System.Drawing.Point(174, 123);
			this.CO2B.Name = "CO2B";
			this.CO2B.Size = new System.Drawing.Size(62, 22);
			this.CO2B.TabIndex = 13;
			this.CO2B.Text = "0.0";
			this.CO2B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CO2B.Leave += new System.EventHandler(this.FixChanged);
			// 
			// BrtnB
			// 
			this.BrtnB.Location = new System.Drawing.Point(174, 98);
			this.BrtnB.Name = "BrtnB";
			this.BrtnB.Size = new System.Drawing.Size(62, 22);
			this.BrtnB.TabIndex = 13;
			this.BrtnB.Text = "0.0";
			this.BrtnB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.BrtnB.Leave += new System.EventHandler(this.FixChanged);
			// 
			// PresB
			// 
			this.PresB.Location = new System.Drawing.Point(174, 73);
			this.PresB.Name = "PresB";
			this.PresB.Size = new System.Drawing.Size(62, 22);
			this.PresB.TabIndex = 13;
			this.PresB.Text = "0.0";
			this.PresB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.PresB.Leave += new System.EventHandler(this.FixChanged);
			// 
			// HumdB
			// 
			this.HumdB.Location = new System.Drawing.Point(174, 48);
			this.HumdB.Name = "HumdB";
			this.HumdB.Size = new System.Drawing.Size(62, 22);
			this.HumdB.TabIndex = 13;
			this.HumdB.Text = "0.0";
			this.HumdB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.HumdB.Leave += new System.EventHandler(this.FixChanged);
			// 
			// TempB
			// 
			this.TempB.Location = new System.Drawing.Point(174, 23);
			this.TempB.Name = "TempB";
			this.TempB.Size = new System.Drawing.Size(62, 22);
			this.TempB.TabIndex = 13;
			this.TempB.Text = "0.0";
			this.TempB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TempB.Leave += new System.EventHandler(this.FixChanged);
			// 
			// IonA
			// 
			this.IonA.Location = new System.Drawing.Point(101, 148);
			this.IonA.Name = "IonA";
			this.IonA.Size = new System.Drawing.Size(62, 22);
			this.IonA.TabIndex = 12;
			this.IonA.Text = "1.0";
			this.IonA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.IonA.Leave += new System.EventHandler(this.FixChanged);
			// 
			// CO2A
			// 
			this.CO2A.Location = new System.Drawing.Point(101, 123);
			this.CO2A.Name = "CO2A";
			this.CO2A.Size = new System.Drawing.Size(62, 22);
			this.CO2A.TabIndex = 12;
			this.CO2A.Text = "1.0";
			this.CO2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.CO2A.Leave += new System.EventHandler(this.FixChanged);
			// 
			// BrtnA
			// 
			this.BrtnA.Location = new System.Drawing.Point(101, 98);
			this.BrtnA.Name = "BrtnA";
			this.BrtnA.Size = new System.Drawing.Size(62, 22);
			this.BrtnA.TabIndex = 12;
			this.BrtnA.Text = "1.0";
			this.BrtnA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.BrtnA.Leave += new System.EventHandler(this.FixChanged);
			// 
			// PresA
			// 
			this.PresA.Location = new System.Drawing.Point(101, 73);
			this.PresA.Name = "PresA";
			this.PresA.Size = new System.Drawing.Size(62, 22);
			this.PresA.TabIndex = 12;
			this.PresA.Text = "1.0";
			this.PresA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.PresA.Leave += new System.EventHandler(this.FixChanged);
			// 
			// HumdA
			// 
			this.HumdA.Location = new System.Drawing.Point(101, 48);
			this.HumdA.Name = "HumdA";
			this.HumdA.Size = new System.Drawing.Size(62, 22);
			this.HumdA.TabIndex = 12;
			this.HumdA.Text = "1.0";
			this.HumdA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.HumdA.Leave += new System.EventHandler(this.FixChanged);
			// 
			// TempA
			// 
			this.TempA.Location = new System.Drawing.Point(101, 23);
			this.TempA.Name = "TempA";
			this.TempA.Size = new System.Drawing.Size(62, 22);
			this.TempA.TabIndex = 12;
			this.TempA.Text = "1.0";
			this.TempA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TempA.Leave += new System.EventHandler(this.FixChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numRefRate);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.bMeasureTime);
			this.panel1.Controls.Add(this.numMeasureTime);
			this.panel1.Controls.Add(this.radioButtonMinutes2);
			this.panel1.Controls.Add(this.radioButtMinutes);
			this.panel1.Controls.Add(this.bRefRate);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.radioButtonHours2);
			this.panel1.Controls.Add(this.radioButtonSeconds);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(140, 220);
			this.panel1.TabIndex = 5;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 237);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormSettings";
			this.Text = "Settings -";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
			this.Load += new System.EventHandler(this.FormSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numRefRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMeasureTime)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.CheckBox cTemp;
		public System.Windows.Forms.CheckBox cHumid;
		public System.Windows.Forms.CheckBox cIon;
		public System.Windows.Forms.CheckBox cPressure;
		public System.Windows.Forms.CheckBox cCO2;
		public System.Windows.Forms.CheckBox cBrightness;
		public System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtMinutes;
		private System.Windows.Forms.RadioButton radioButtonSeconds;
		public System.Windows.Forms.NumericUpDown numRefRate;
		private System.Windows.Forms.Button bRefRate;
		public System.Windows.Forms.NumericUpDown numMeasureTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioButtonHours2;
		private System.Windows.Forms.RadioButton radioButtonMinutes2;
		private System.Windows.Forms.Button bMeasureTime;
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
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer1;
	}
}