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
			this.cTemp = new System.Windows.Forms.CheckBox();
			this.cHumid = new System.Windows.Forms.CheckBox();
			this.cIon = new System.Windows.Forms.CheckBox();
			this.cPressure = new System.Windows.Forms.CheckBox();
			this.cCO2 = new System.Windows.Forms.CheckBox();
			this.cBrightness = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(148, 190);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Запис вимірювань";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(187, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Оновлення кожні";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton1.Location = new System.Drawing.Point(266, 40);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(40, 20);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "хв";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton2.Location = new System.Drawing.Point(266, 62);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(48, 20);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "сек";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDown1.Location = new System.Drawing.Point(190, 49);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(53, 24);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(190, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 31);
			this.button1.TabIndex = 11;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 216);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormSettings";
			this.Text = "Settings -";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
			this.Load += new System.EventHandler(this.FormSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button1;
	}
}