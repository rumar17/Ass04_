namespace Ass04_TampusTicod
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
            this.gbxGraph = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.gbxFanControl = new System.Windows.Forms.GroupBox();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.lblRPM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tempReading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStts = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxComport = new System.Windows.Forms.ComboBox();
            this.testSpeed = new System.Windows.Forms.TextBox();
            this.intDiff = new System.Windows.Forms.Label();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.gbxManual.SuspendLayout();
            this.gbxAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempControl)).BeginInit();
            this.gbxConfig.SuspendLayout();
            this.panelSpeedControlChooser.SuspendLayout();
            this.gbxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.gbxFanControl.SuspendLayout();
            this.gbxTemp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial
            // 
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
            this.gbxManual.Location = new System.Drawing.Point(6, 52);
            this.gbxManual.Name = "gbxManual";
            this.gbxManual.Size = new System.Drawing.Size(100, 135);
            this.gbxManual.TabIndex = 0;
            this.gbxManual.TabStop = false;
            this.gbxManual.Text = "Fan Control";
            // 
            // radioBtn_speedOff
            // 
            this.radioBtn_speedOff.AutoSize = true;
            this.radioBtn_speedOff.Checked = true;
            this.radioBtn_speedOff.Location = new System.Drawing.Point(19, 29);
            this.radioBtn_speedOff.Name = "radioBtn_speedOff";
            this.radioBtn_speedOff.Size = new System.Drawing.Size(46, 17);
            this.radioBtn_speedOff.TabIndex = 4;
            this.radioBtn_speedOff.TabStop = true;
            this.radioBtn_speedOff.Text = "OFF";
            this.radioBtn_speedOff.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedHigh
            // 
            this.radioBtn_speedHigh.AutoSize = true;
            this.radioBtn_speedHigh.Location = new System.Drawing.Point(19, 98);
            this.radioBtn_speedHigh.Name = "radioBtn_speedHigh";
            this.radioBtn_speedHigh.Size = new System.Drawing.Size(50, 17);
            this.radioBtn_speedHigh.TabIndex = 3;
            this.radioBtn_speedHigh.Text = "High";
            this.radioBtn_speedHigh.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedMedium
            // 
            this.radioBtn_speedMedium.AutoSize = true;
            this.radioBtn_speedMedium.Location = new System.Drawing.Point(19, 75);
            this.radioBtn_speedMedium.Name = "radioBtn_speedMedium";
            this.radioBtn_speedMedium.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_speedMedium.TabIndex = 2;
            this.radioBtn_speedMedium.Text = "Medium";
            this.radioBtn_speedMedium.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedLow
            // 
            this.radioBtn_speedLow.AutoSize = true;
            this.radioBtn_speedLow.Location = new System.Drawing.Point(19, 52);
            this.radioBtn_speedLow.Name = "radioBtn_speedLow";
            this.radioBtn_speedLow.Size = new System.Drawing.Size(46, 17);
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
            this.gbxAuto.Location = new System.Drawing.Point(114, 127);
            this.gbxAuto.Name = "gbxAuto";
            this.gbxAuto.Size = new System.Drawing.Size(180, 60);
            this.gbxAuto.TabIndex = 1;
            this.gbxAuto.TabStop = false;
            this.gbxAuto.Text = "Temperature Control";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Target Temperature:";
            // 
            // tempControl
            // 
            this.tempControl.AutoSize = true;
            this.tempControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempControl.Location = new System.Drawing.Point(116, 25);
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
            this.tempControl.Size = new System.Drawing.Size(37, 22);
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
            this.lblDegreeSign.Location = new System.Drawing.Point(154, 26);
            this.lblDegreeSign.Name = "lblDegreeSign";
            this.lblDegreeSign.Size = new System.Drawing.Size(20, 15);
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
            this.gbxConfig.Location = new System.Drawing.Point(126, 34);
            this.gbxConfig.Name = "gbxConfig";
            this.gbxConfig.Size = new System.Drawing.Size(186, 55);
            this.gbxConfig.TabIndex = 2;
            this.gbxConfig.TabStop = false;
            this.gbxConfig.Text = "Baud Rate";
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnSerialConnect.Location = new System.Drawing.Point(98, 20);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(72, 23);
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
            this.cboxBaudrate.Location = new System.Drawing.Point(17, 22);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(75, 21);
            this.cboxBaudrate.TabIndex = 0;
            // 
            // radioBtn_Manual
            // 
            this.radioBtn_Manual.AutoSize = true;
            this.radioBtn_Manual.Checked = true;
            this.radioBtn_Manual.Location = new System.Drawing.Point(20, 3);
            this.radioBtn_Manual.Name = "radioBtn_Manual";
            this.radioBtn_Manual.Size = new System.Drawing.Size(64, 17);
            this.radioBtn_Manual.TabIndex = 4;
            this.radioBtn_Manual.TabStop = true;
            this.radioBtn_Manual.Text = "Manual";
            this.radioBtn_Manual.UseVisualStyleBackColor = true;
            this.radioBtn_Manual.CheckedChanged += new System.EventHandler(this.radioBtn_Manual_CheckedChanged);
            // 
            // radioBtn_Auto
            // 
            this.radioBtn_Auto.AutoSize = true;
            this.radioBtn_Auto.Location = new System.Drawing.Point(125, 3);
            this.radioBtn_Auto.Name = "radioBtn_Auto";
            this.radioBtn_Auto.Size = new System.Drawing.Size(50, 17);
            this.radioBtn_Auto.TabIndex = 5;
            this.radioBtn_Auto.Text = "Auto";
            this.radioBtn_Auto.UseVisualStyleBackColor = true;
            this.radioBtn_Auto.CheckedChanged += new System.EventHandler(this.radioBtn_Auto_CheckedChanged);
            // 
            // panelSpeedControlChooser
            // 
            this.panelSpeedControlChooser.Controls.Add(this.radioBtn_Manual);
            this.panelSpeedControlChooser.Controls.Add(this.radioBtn_Auto);
            this.panelSpeedControlChooser.Location = new System.Drawing.Point(6, 19);
            this.panelSpeedControlChooser.Name = "panelSpeedControlChooser";
            this.panelSpeedControlChooser.Size = new System.Drawing.Size(288, 23);
            this.panelSpeedControlChooser.TabIndex = 6;
            // 
            // gbxGraph
            // 
            this.gbxGraph.Controls.Add(this.label5);
            this.gbxGraph.Controls.Add(this.label4);
            this.gbxGraph.Controls.Add(this.label8);
            this.gbxGraph.Controls.Add(this.label7);
            this.gbxGraph.Controls.Add(this.label3);
            this.gbxGraph.Controls.Add(this.pbGraph);
            this.gbxGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxGraph.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxGraph.Location = new System.Drawing.Point(12, 95);
            this.gbxGraph.Name = "gbxGraph";
            this.gbxGraph.Size = new System.Drawing.Size(300, 150);
            this.gbxGraph.TabIndex = 7;
            this.gbxGraph.TabStop = false;
            this.gbxGraph.Text = "Temperature Graph";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "110 °C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "0 °C";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "75 °C";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "50 °C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "25 °C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbGraph
            // 
            this.pbGraph.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGraph.Location = new System.Drawing.Point(54, 18);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(240, 125);
            this.pbGraph.TabIndex = 4;
            this.pbGraph.TabStop = false;
            this.pbGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraph_Paint);
            // 
            // gbxFanControl
            // 
            this.gbxFanControl.Controls.Add(this.gbxTemp);
            this.gbxFanControl.Controls.Add(this.panelSpeedControlChooser);
            this.gbxFanControl.Controls.Add(this.gbxManual);
            this.gbxFanControl.Controls.Add(this.gbxAuto);
            this.gbxFanControl.Enabled = false;
            this.gbxFanControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFanControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxFanControl.Location = new System.Drawing.Point(12, 251);
            this.gbxFanControl.Name = "gbxFanControl";
            this.gbxFanControl.Size = new System.Drawing.Size(300, 193);
            this.gbxFanControl.TabIndex = 8;
            this.gbxFanControl.TabStop = false;
            this.gbxFanControl.Text = "Fan Control";
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.lblRPM);
            this.gbxTemp.Controls.Add(this.label6);
            this.gbxTemp.Controls.Add(this.tempReading);
            this.gbxTemp.Controls.Add(this.label2);
            this.gbxTemp.Controls.Add(this.label1);
            this.gbxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gbxTemp.Location = new System.Drawing.Point(114, 52);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(180, 69);
            this.gbxTemp.TabIndex = 7;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "Diagnostics";
            // 
            // lblRPM
            // 
            this.lblRPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPM.Location = new System.Drawing.Point(104, 41);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(40, 13);
            this.lblRPM.TabIndex = 9;
            this.lblRPM.Text = "OFF";
            this.lblRPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "RPM (approx.):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempReading
            // 
            this.tempReading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempReading.Location = new System.Drawing.Point(109, 23);
            this.tempReading.Name = "tempReading";
            this.tempReading.Size = new System.Drawing.Size(35, 13);
            this.tempReading.TabIndex = 7;
            this.tempReading.Text = "NaN";
            this.tempReading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Reading:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "°C";
            // 
            // lblStts
            // 
            this.lblStts.AutoSize = true;
            this.lblStts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblStts.Location = new System.Drawing.Point(149, 9);
            this.lblStts.Name = "lblStts";
            this.lblStts.Size = new System.Drawing.Size(42, 13);
            this.lblStts.TabIndex = 1;
            this.lblStts.Text = "Status:";
            this.lblStts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.ForeColor = System.Drawing.Color.Firebrick;
            this.lblStatusText.Location = new System.Drawing.Point(190, 9);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(77, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // cboxComport
            // 
            this.cboxComport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(17, 22);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(75, 21);
            this.cboxComport.TabIndex = 0;
            this.cboxComport.Click += new System.EventHandler(this.cboxComport_Click);
            // 
            // testSpeed
            // 
            this.testSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testSpeed.Location = new System.Drawing.Point(12, 9);
            this.testSpeed.Name = "testSpeed";
            this.testSpeed.Size = new System.Drawing.Size(60, 20);
            this.testSpeed.TabIndex = 9;
            // 
            // intDiff
            // 
            this.intDiff.Location = new System.Drawing.Point(86, 9);
            this.intDiff.Name = "intDiff";
            this.intDiff.Size = new System.Drawing.Size(43, 20);
            this.intDiff.TabIndex = 15;
            this.intDiff.Text = "99";
            this.intDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawTimer
            // 
            this.drawTimer.Interval = 200;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // fanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(324, 456);
            this.Controls.Add(this.gbxFanControl);
            this.Controls.Add(this.intDiff);
            this.Controls.Add(this.lblStts);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.gbxConfig);
            this.Controls.Add(this.testSpeed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fanControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fan Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fanControl_FormClosed);
            this.gbxManual.ResumeLayout(false);
            this.gbxManual.PerformLayout();
            this.gbxAuto.ResumeLayout(false);
            this.gbxAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempControl)).EndInit();
            this.gbxConfig.ResumeLayout(false);
            this.panelSpeedControlChooser.ResumeLayout(false);
            this.panelSpeedControlChooser.PerformLayout();
            this.gbxGraph.ResumeLayout(false);
            this.gbxGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.gbxFanControl.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbxGraph;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempReading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.TextBox testSpeed;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.Label intDiff;
        private System.Windows.Forms.NumericUpDown tempControl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer drawTimer;
    }
}

