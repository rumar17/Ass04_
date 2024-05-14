namespace Ass04_Macapobre
{
    partial class fanControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fanControl));
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.gbxManual = new System.Windows.Forms.GroupBox();
            this.radioBtn_speedOff = new System.Windows.Forms.RadioButton();
            this.radioBtn_speedHigh = new System.Windows.Forms.RadioButton();
            this.radioBtn_speedMedium = new System.Windows.Forms.RadioButton();
            this.radioBtn_speedLow = new System.Windows.Forms.RadioButton();
            this.gbxAuto = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tempControl = new System.Windows.Forms.NumericUpDown();
            this.lblDegreeSign = new System.Windows.Forms.Label();
            this.gbxConfig = new System.Windows.Forms.GroupBox();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.cboxBaudrate = new System.Windows.Forms.ComboBox();
            this.radioBtn_Manual = new System.Windows.Forms.RadioButton();
            this.radioBtn_Auto = new System.Windows.Forms.RadioButton();
            this.panelSpeedControlChooser = new System.Windows.Forms.Panel();
            this.gbxFanControl = new System.Windows.Forms.GroupBox();
            this.lblMinPWM = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minPWM = new System.Windows.Forms.TrackBar();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.pwmSpeedAmt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tempReading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStts = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxComport = new System.Windows.Forms.ComboBox();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.gbxManual.SuspendLayout();
            this.gbxAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempControl)).BeginInit();
            this.gbxConfig.SuspendLayout();
            this.panelSpeedControlChooser.SuspendLayout();
            this.gbxFanControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPWM)).BeginInit();
            this.gbxTemp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.DtrEnable = true;
            this.Serial.WriteTimeout = 3000;
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_DataReceived);
            // 
            // gbxManual
            // 
            this.gbxManual.Controls.Add(this.radioBtn_speedOff);
            this.gbxManual.Controls.Add(this.radioBtn_speedHigh);
            this.gbxManual.Controls.Add(this.radioBtn_speedMedium);
            this.gbxManual.Controls.Add(this.radioBtn_speedLow);
            this.gbxManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxManual.Location = new System.Drawing.Point(8, 64);
            this.gbxManual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxManual.Name = "gbxManual";
            this.gbxManual.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxManual.Size = new System.Drawing.Size(133, 166);
            this.gbxManual.TabIndex = 0;
            this.gbxManual.TabStop = false;
            this.gbxManual.Text = "Fan Control";
            // 
            // radioBtn_speedOff
            // 
            this.radioBtn_speedOff.AutoSize = true;
            this.radioBtn_speedOff.Checked = true;
            this.radioBtn_speedOff.Location = new System.Drawing.Point(25, 36);
            this.radioBtn_speedOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtn_speedOff.Name = "radioBtn_speedOff";
            this.radioBtn_speedOff.Size = new System.Drawing.Size(55, 23);
            this.radioBtn_speedOff.TabIndex = 4;
            this.radioBtn_speedOff.TabStop = true;
            this.radioBtn_speedOff.Text = "OFF";
            this.radioBtn_speedOff.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedHigh
            // 
            this.radioBtn_speedHigh.AutoSize = true;
            this.radioBtn_speedHigh.Location = new System.Drawing.Point(25, 121);
            this.radioBtn_speedHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtn_speedHigh.Name = "radioBtn_speedHigh";
            this.radioBtn_speedHigh.Size = new System.Drawing.Size(59, 23);
            this.radioBtn_speedHigh.TabIndex = 3;
            this.radioBtn_speedHigh.Text = "High";
            this.radioBtn_speedHigh.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedMedium
            // 
            this.radioBtn_speedMedium.AutoSize = true;
            this.radioBtn_speedMedium.Location = new System.Drawing.Point(25, 92);
            this.radioBtn_speedMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtn_speedMedium.Name = "radioBtn_speedMedium";
            this.radioBtn_speedMedium.Size = new System.Drawing.Size(81, 23);
            this.radioBtn_speedMedium.TabIndex = 2;
            this.radioBtn_speedMedium.Text = "Medium";
            this.radioBtn_speedMedium.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedLow
            // 
            this.radioBtn_speedLow.AutoSize = true;
            this.radioBtn_speedLow.Location = new System.Drawing.Point(25, 64);
            this.radioBtn_speedLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtn_speedLow.Name = "radioBtn_speedLow";
            this.radioBtn_speedLow.Size = new System.Drawing.Size(55, 23);
            this.radioBtn_speedLow.TabIndex = 1;
            this.radioBtn_speedLow.Text = "Low";
            this.radioBtn_speedLow.UseVisualStyleBackColor = true;
            // 
            // gbxAuto
            // 
            this.gbxAuto.Controls.Add(this.label14);
            this.gbxAuto.Controls.Add(this.tempControl);
            this.gbxAuto.Controls.Add(this.lblDegreeSign);
            this.gbxAuto.Enabled = false;
            this.gbxAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxAuto.Location = new System.Drawing.Point(152, 156);
            this.gbxAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxAuto.Name = "gbxAuto";
            this.gbxAuto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxAuto.Size = new System.Drawing.Size(240, 74);
            this.gbxAuto.TabIndex = 1;
            this.gbxAuto.TabStop = false;
            this.gbxAuto.Text = "Temperature Control";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Temperature:";
            // 
            // tempControl
            // 
            this.tempControl.AutoSize = true;
            this.tempControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempControl.Location = new System.Drawing.Point(135, 31);
            this.tempControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempControl.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.tempControl.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tempControl.Name = "tempControl";
            this.tempControl.ReadOnly = true;
            this.tempControl.Size = new System.Drawing.Size(60, 26);
            this.tempControl.TabIndex = 4;
            this.tempControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempControl.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.tempControl.ValueChanged += new System.EventHandler(this.tempControl_ValueChanged);
            // 
            // lblDegreeSign
            // 
            this.lblDegreeSign.AutoSize = true;
            this.lblDegreeSign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeSign.Location = new System.Drawing.Point(185, 32);
            this.lblDegreeSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegreeSign.Name = "lblDegreeSign";
            this.lblDegreeSign.Size = new System.Drawing.Size(24, 20);
            this.lblDegreeSign.TabIndex = 3;
            this.lblDegreeSign.Text = "°C";
            // 
            // gbxConfig
            // 
            this.gbxConfig.Controls.Add(this.btnSerialConnect);
            this.gbxConfig.Controls.Add(this.cboxBaudrate);
            this.gbxConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxConfig.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxConfig.Location = new System.Drawing.Point(168, 42);
            this.gbxConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxConfig.Name = "gbxConfig";
            this.gbxConfig.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxConfig.Size = new System.Drawing.Size(248, 68);
            this.gbxConfig.TabIndex = 2;
            this.gbxConfig.TabStop = false;
            this.gbxConfig.Text = "Baud Rate";
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnSerialConnect.Location = new System.Drawing.Point(131, 25);
            this.btnSerialConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(96, 28);
            this.btnSerialConnect.TabIndex = 7;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // cboxBaudrate
            // 
            this.cboxBaudrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxBaudrate.FormattingEnabled = true;
            this.cboxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200",
            "230400",
            "460800",
            "921600",
            "3860000"});
            this.cboxBaudrate.Location = new System.Drawing.Point(23, 27);
            this.cboxBaudrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(99, 27);
            this.cboxBaudrate.TabIndex = 0;
            // 
            // radioBtn_Manual
            // 
            this.radioBtn_Manual.AutoSize = true;
            this.radioBtn_Manual.Checked = true;
            this.radioBtn_Manual.Location = new System.Drawing.Point(7, 4);
            this.radioBtn_Manual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtn_Manual.Name = "radioBtn_Manual";
            this.radioBtn_Manual.Size = new System.Drawing.Size(76, 23);
            this.radioBtn_Manual.TabIndex = 4;
            this.radioBtn_Manual.TabStop = true;
            this.radioBtn_Manual.Text = "Manual";
            this.radioBtn_Manual.UseVisualStyleBackColor = true;
            this.radioBtn_Manual.CheckedChanged += new System.EventHandler(this.radioBtn_Manual_CheckedChanged);
            // 
            // radioBtn_Auto
            // 
            this.radioBtn_Auto.AutoSize = true;
            this.radioBtn_Auto.Location = new System.Drawing.Point(100, 4);
            this.radioBtn_Auto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtn_Auto.Name = "radioBtn_Auto";
            this.radioBtn_Auto.Size = new System.Drawing.Size(60, 23);
            this.radioBtn_Auto.TabIndex = 5;
            this.radioBtn_Auto.Text = "Auto";
            this.radioBtn_Auto.UseVisualStyleBackColor = true;
            this.radioBtn_Auto.CheckedChanged += new System.EventHandler(this.radioBtn_Auto_CheckedChanged);
            // 
            // panelSpeedControlChooser
            // 
            this.panelSpeedControlChooser.Controls.Add(this.radioBtn_Manual);
            this.panelSpeedControlChooser.Controls.Add(this.radioBtn_Auto);
            this.panelSpeedControlChooser.Location = new System.Drawing.Point(8, 23);
            this.panelSpeedControlChooser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSpeedControlChooser.Name = "panelSpeedControlChooser";
            this.panelSpeedControlChooser.Size = new System.Drawing.Size(181, 28);
            this.panelSpeedControlChooser.TabIndex = 6;
            // 
            // gbxFanControl
            // 
            this.gbxFanControl.Controls.Add(this.lblMinPWM);
            this.gbxFanControl.Controls.Add(this.label10);
            this.gbxFanControl.Controls.Add(this.minPWM);
            this.gbxFanControl.Controls.Add(this.gbxTemp);
            this.gbxFanControl.Controls.Add(this.panelSpeedControlChooser);
            this.gbxFanControl.Controls.Add(this.gbxManual);
            this.gbxFanControl.Controls.Add(this.gbxAuto);
            this.gbxFanControl.Enabled = false;
            this.gbxFanControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFanControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxFanControl.Location = new System.Drawing.Point(16, 309);
            this.gbxFanControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFanControl.Name = "gbxFanControl";
            this.gbxFanControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFanControl.Size = new System.Drawing.Size(400, 238);
            this.gbxFanControl.TabIndex = 8;
            this.gbxFanControl.TabStop = false;
            this.gbxFanControl.Text = "Fan Control";
            // 
            // lblMinPWM
            // 
            this.lblMinPWM.AutoSize = true;
            this.lblMinPWM.Enabled = false;
            this.lblMinPWM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPWM.Location = new System.Drawing.Point(357, 30);
            this.lblMinPWM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinPWM.Name = "lblMinPWM";
            this.lblMinPWM.Size = new System.Drawing.Size(25, 19);
            this.lblMinPWM.TabIndex = 12;
            this.lblMinPWM.Text = "50";
            this.lblMinPWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Min PWM %";
            // 
            // minPWM
            // 
            this.minPWM.AutoSize = false;
            this.minPWM.Enabled = false;
            this.minPWM.LargeChange = 25;
            this.minPWM.Location = new System.Drawing.Point(263, 26);
            this.minPWM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minPWM.Maximum = 100;
            this.minPWM.Minimum = 25;
            this.minPWM.Name = "minPWM";
            this.minPWM.Size = new System.Drawing.Size(100, 25);
            this.minPWM.SmallChange = 5;
            this.minPWM.TabIndex = 11;
            this.minPWM.TickStyle = System.Windows.Forms.TickStyle.None;
            this.minPWM.Value = 50;
            this.minPWM.ValueChanged += new System.EventHandler(this.minPWM_ValueChanged);
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.pwmSpeedAmt);
            this.gbxTemp.Controls.Add(this.label6);
            this.gbxTemp.Controls.Add(this.tempReading);
            this.gbxTemp.Controls.Add(this.label2);
            this.gbxTemp.Controls.Add(this.label1);
            this.gbxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxTemp.Location = new System.Drawing.Point(152, 64);
            this.gbxTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTemp.Size = new System.Drawing.Size(240, 85);
            this.gbxTemp.TabIndex = 7;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "Diagnostics";
            // 
            // pwmSpeedAmt
            // 
            this.pwmSpeedAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwmSpeedAmt.Location = new System.Drawing.Point(139, 50);
            this.pwmSpeedAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwmSpeedAmt.Name = "pwmSpeedAmt";
            this.pwmSpeedAmt.Size = new System.Drawing.Size(53, 16);
            this.pwmSpeedAmt.TabIndex = 9;
            this.pwmSpeedAmt.Text = "OFF";
            this.pwmSpeedAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fan Speed:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempReading
            // 
            this.tempReading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempReading.Location = new System.Drawing.Point(145, 28);
            this.tempReading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempReading.Name = "tempReading";
            this.tempReading.Size = new System.Drawing.Size(47, 16);
            this.tempReading.TabIndex = 7;
            this.tempReading.Text = "NaN";
            this.tempReading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Reading:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "°C";
            // 
            // lblStts
            // 
            this.lblStts.AutoSize = true;
            this.lblStts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblStts.Location = new System.Drawing.Point(192, 11);
            this.lblStts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStts.Name = "lblStts";
            this.lblStts.Size = new System.Drawing.Size(50, 19);
            this.lblStts.TabIndex = 1;
            this.lblStts.Text = "Status:";
            this.lblStts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.ForeColor = System.Drawing.Color.Firebrick;
            this.lblStatusText.Location = new System.Drawing.Point(247, 11);
            this.lblStatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(91, 19);
            this.lblStatusText.TabIndex = 2;
            this.lblStatusText.Text = "Disconnected";
            this.lblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxComport);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(144, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // cboxComport
            // 
            this.cboxComport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(23, 27);
            this.cboxComport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(99, 27);
            this.cboxComport.TabIndex = 0;
            this.cboxComport.Click += new System.EventHandler(this.cboxComport_Click);
            // 
            // drawTimer
            // 
            this.drawTimer.Interval = 200;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // fanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 561);
            this.Controls.Add(this.gbxFanControl);
            this.Controls.Add(this.lblStts);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.gbxConfig);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fanControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fan Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fanControl_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fanControl_FormClosed);
            this.gbxManual.ResumeLayout(false);
            this.gbxManual.PerformLayout();
            this.gbxAuto.ResumeLayout(false);
            this.gbxAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempControl)).EndInit();
            this.gbxConfig.ResumeLayout(false);
            this.panelSpeedControlChooser.ResumeLayout(false);
            this.panelSpeedControlChooser.PerformLayout();
            this.gbxFanControl.ResumeLayout(false);
            this.gbxFanControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPWM)).EndInit();
            this.gbxTemp.ResumeLayout(false);
            this.gbxTemp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.GroupBox gbxManual;
        private System.Windows.Forms.GroupBox gbxAuto;
        private System.Windows.Forms.GroupBox gbxConfig;
        private System.Windows.Forms.RadioButton radioBtn_Manual;
        private System.Windows.Forms.RadioButton radioBtn_Auto;
        private System.Windows.Forms.Panel panelSpeedControlChooser;
        private System.Windows.Forms.RadioButton radioBtn_speedHigh;
        private System.Windows.Forms.RadioButton radioBtn_speedMedium;
        private System.Windows.Forms.RadioButton radioBtn_speedLow;
        private System.Windows.Forms.GroupBox gbxFanControl;
        private System.Windows.Forms.Label lblDegreeSign;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtn_speedOff;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStts;
        private System.Windows.Forms.ComboBox cboxBaudrate;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.Label tempReading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.Label pwmSpeedAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tempControl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.TrackBar minPWM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMinPWM;
    }
}

