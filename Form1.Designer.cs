namespace Ass04_TampusTicod
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbxManual = new System.Windows.Forms.GroupBox();
            this.gbxAuto = new System.Windows.Forms.GroupBox();
            this.gbxConfig = new System.Windows.Forms.GroupBox();
            this.radioBtn_Manual = new System.Windows.Forms.RadioButton();
            this.radioBtn_Auto = new System.Windows.Forms.RadioButton();
            this.panelSpeedControlChooser = new System.Windows.Forms.Panel();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.radioBtn_speedLow = new System.Windows.Forms.RadioButton();
            this.radioBtn_speedMedium = new System.Windows.Forms.RadioButton();
            this.radioBtn_speedHigh = new System.Windows.Forms.RadioButton();
            this.gbxGraph = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxFanControl = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDegreeSign = new System.Windows.Forms.Label();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtn_speedOff = new System.Windows.Forms.RadioButton();
            this.lblFSpeed = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblRPMCount = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.lblStts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempReading = new System.Windows.Forms.Label();
            this.gbxManual.SuspendLayout();
            this.gbxAuto.SuspendLayout();
            this.gbxConfig.SuspendLayout();
            this.panelSpeedControlChooser.SuspendLayout();
            this.gbxGraph.SuspendLayout();
            this.gbxFanControl.SuspendLayout();
            this.gbxTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxManual
            // 
            this.gbxManual.Controls.Add(this.radioBtn_speedOff);
            this.gbxManual.Controls.Add(this.radioBtn_speedHigh);
            this.gbxManual.Controls.Add(this.radioBtn_speedMedium);
            this.gbxManual.Controls.Add(this.radioBtn_speedLow);
            this.gbxManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxManual.Location = new System.Drawing.Point(6, 52);
            this.gbxManual.Name = "gbxManual";
            this.gbxManual.Size = new System.Drawing.Size(100, 135);
            this.gbxManual.TabIndex = 0;
            this.gbxManual.TabStop = false;
            this.gbxManual.Text = "Fan Speed";
            // 
            // gbxAuto
            // 
            this.gbxAuto.Controls.Add(this.lblRPMCount);
            this.gbxAuto.Controls.Add(this.lblRPM);
            this.gbxAuto.Controls.Add(this.lblFSpeed);
            this.gbxAuto.Controls.Add(this.lblDegreeSign);
            this.gbxAuto.Controls.Add(this.button1);
            this.gbxAuto.Controls.Add(this.tbxTemp);
            this.gbxAuto.Enabled = false;
            this.gbxAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAuto.Location = new System.Drawing.Point(114, 107);
            this.gbxAuto.Name = "gbxAuto";
            this.gbxAuto.Size = new System.Drawing.Size(180, 80);
            this.gbxAuto.TabIndex = 1;
            this.gbxAuto.TabStop = false;
            this.gbxAuto.Text = "Temperature Control";
            // 
            // gbxConfig
            // 
            this.gbxConfig.Controls.Add(this.btnSerialConnect);
            this.gbxConfig.Controls.Add(this.lblBaudRate);
            this.gbxConfig.Controls.Add(this.cBoxBaudRate);
            this.gbxConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxConfig.Location = new System.Drawing.Point(12, 34);
            this.gbxConfig.Name = "gbxConfig";
            this.gbxConfig.Size = new System.Drawing.Size(300, 55);
            this.gbxConfig.TabIndex = 2;
            this.gbxConfig.TabStop = false;
            this.gbxConfig.Text = "Configuration";
            // 
            // radioBtn_Manual
            // 
            this.radioBtn_Manual.AutoSize = true;
            this.radioBtn_Manual.Checked = true;
            this.radioBtn_Manual.Location = new System.Drawing.Point(20, 3);
            this.radioBtn_Manual.Name = "radioBtn_Manual";
            this.radioBtn_Manual.Size = new System.Drawing.Size(60, 17);
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
            this.radioBtn_Auto.Size = new System.Drawing.Size(47, 17);
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
            // tbxTemp
            // 
            this.tbxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTemp.Location = new System.Drawing.Point(8, 26);
            this.tbxTemp.MaxLength = 10;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.Size = new System.Drawing.Size(74, 20);
            this.tbxTemp.TabIndex = 0;
            this.tbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioBtn_speedLow
            // 
            this.radioBtn_speedLow.AutoSize = true;
            this.radioBtn_speedLow.Location = new System.Drawing.Point(23, 52);
            this.radioBtn_speedLow.Name = "radioBtn_speedLow";
            this.radioBtn_speedLow.Size = new System.Drawing.Size(45, 17);
            this.radioBtn_speedLow.TabIndex = 1;
            this.radioBtn_speedLow.Text = "Low";
            this.radioBtn_speedLow.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedMedium
            // 
            this.radioBtn_speedMedium.AutoSize = true;
            this.radioBtn_speedMedium.Location = new System.Drawing.Point(23, 75);
            this.radioBtn_speedMedium.Name = "radioBtn_speedMedium";
            this.radioBtn_speedMedium.Size = new System.Drawing.Size(62, 17);
            this.radioBtn_speedMedium.TabIndex = 2;
            this.radioBtn_speedMedium.Text = "Medium";
            this.radioBtn_speedMedium.UseVisualStyleBackColor = true;
            // 
            // radioBtn_speedHigh
            // 
            this.radioBtn_speedHigh.AutoSize = true;
            this.radioBtn_speedHigh.Location = new System.Drawing.Point(23, 98);
            this.radioBtn_speedHigh.Name = "radioBtn_speedHigh";
            this.radioBtn_speedHigh.Size = new System.Drawing.Size(47, 17);
            this.radioBtn_speedHigh.TabIndex = 3;
            this.radioBtn_speedHigh.Text = "High";
            this.radioBtn_speedHigh.UseVisualStyleBackColor = true;
            // 
            // gbxGraph
            // 
            this.gbxGraph.Controls.Add(this.label5);
            this.gbxGraph.Controls.Add(this.label4);
            this.gbxGraph.Controls.Add(this.panel1);
            this.gbxGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxGraph.Location = new System.Drawing.Point(12, 95);
            this.gbxGraph.Name = "gbxGraph";
            this.gbxGraph.Size = new System.Drawing.Size(300, 150);
            this.gbxGraph.TabIndex = 7;
            this.gbxGraph.TabStop = false;
            this.gbxGraph.Text = "Temperature Graph";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(48, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 125);
            this.panel1.TabIndex = 0;
            // 
            // gbxFanControl
            // 
            this.gbxFanControl.Controls.Add(this.gbxTemp);
            this.gbxFanControl.Controls.Add(this.panelSpeedControlChooser);
            this.gbxFanControl.Controls.Add(this.gbxManual);
            this.gbxFanControl.Controls.Add(this.gbxAuto);
            this.gbxFanControl.Location = new System.Drawing.Point(12, 251);
            this.gbxFanControl.Name = "gbxFanControl";
            this.gbxFanControl.Size = new System.Drawing.Size(300, 193);
            this.gbxFanControl.TabIndex = 8;
            this.gbxFanControl.TabStop = false;
            this.gbxFanControl.Text = "Fan Control";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(112, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblDegreeSign
            // 
            this.lblDegreeSign.AutoSize = true;
            this.lblDegreeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeSign.Location = new System.Drawing.Point(86, 28);
            this.lblDegreeSign.Name = "lblDegreeSign";
            this.lblDegreeSign.Size = new System.Drawing.Size(20, 15);
            this.lblDegreeSign.TabIndex = 3;
            this.lblDegreeSign.Text = "°C";
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.tempReading);
            this.gbxTemp.Controls.Add(this.label2);
            this.gbxTemp.Controls.Add(this.label1);
            this.gbxTemp.Location = new System.Drawing.Point(114, 52);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(180, 49);
            this.gbxTemp.TabIndex = 7;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Reading:";
            // 
            // radioBtn_speedOff
            // 
            this.radioBtn_speedOff.AutoSize = true;
            this.radioBtn_speedOff.Checked = true;
            this.radioBtn_speedOff.Location = new System.Drawing.Point(23, 29);
            this.radioBtn_speedOff.Name = "radioBtn_speedOff";
            this.radioBtn_speedOff.Size = new System.Drawing.Size(45, 17);
            this.radioBtn_speedOff.TabIndex = 4;
            this.radioBtn_speedOff.TabStop = true;
            this.radioBtn_speedOff.Text = "OFF";
            this.radioBtn_speedOff.UseVisualStyleBackColor = true;
            // 
            // lblFSpeed
            // 
            this.lblFSpeed.AutoSize = true;
            this.lblFSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFSpeed.Location = new System.Drawing.Point(43, 56);
            this.lblFSpeed.Name = "lblFSpeed";
            this.lblFSpeed.Size = new System.Drawing.Size(62, 13);
            this.lblFSpeed.TabIndex = 4;
            this.lblFSpeed.Text = "Fan Speed:";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPM.Location = new System.Drawing.Point(138, 56);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(31, 13);
            this.lblRPM.TabIndex = 5;
            this.lblRPM.Text = "RPM";
            this.lblRPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRPMCount
            // 
            this.lblRPMCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPMCount.Location = new System.Drawing.Point(101, 56);
            this.lblRPMCount.Name = "lblRPMCount";
            this.lblRPMCount.Size = new System.Drawing.Size(40, 13);
            this.lblRPMCount.TabIndex = 6;
            this.lblRPMCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Location = new System.Drawing.Point(148, 22);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(75, 21);
            this.cBoxBaudRate.TabIndex = 0;
            // 
            // lblStts
            // 
            this.lblStts.AutoSize = true;
            this.lblStts.Location = new System.Drawing.Point(154, 9);
            this.lblStts.Name = "lblStts";
            this.lblStts.Size = new System.Drawing.Size(40, 13);
            this.lblStts.TabIndex = 1;
            this.lblStts.Text = "Status:";
            this.lblStts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connected, via COM3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(84, 25);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "Baud Rate";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSerialConnect.Location = new System.Drawing.Point(229, 20);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(65, 23);
            this.btnSerialConnect.TabIndex = 7;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "0 °C";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "150 °C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempReading
            // 
            this.tempReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempReading.Location = new System.Drawing.Point(112, 23);
            this.tempReading.Name = "tempReading";
            this.tempReading.Size = new System.Drawing.Size(40, 13);
            this.tempReading.TabIndex = 7;
            this.tempReading.Text = "150";
            this.tempReading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 456);
            this.Controls.Add(this.gbxFanControl);
            this.Controls.Add(this.gbxGraph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxConfig);
            this.Controls.Add(this.lblStts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fan Control";
            this.gbxManual.ResumeLayout(false);
            this.gbxManual.PerformLayout();
            this.gbxAuto.ResumeLayout(false);
            this.gbxAuto.PerformLayout();
            this.gbxConfig.ResumeLayout(false);
            this.gbxConfig.PerformLayout();
            this.panelSpeedControlChooser.ResumeLayout(false);
            this.panelSpeedControlChooser.PerformLayout();
            this.gbxGraph.ResumeLayout(false);
            this.gbxGraph.PerformLayout();
            this.gbxFanControl.ResumeLayout(false);
            this.gbxTemp.ResumeLayout(false);
            this.gbxTemp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gbxManual;
        private System.Windows.Forms.GroupBox gbxAuto;
        private System.Windows.Forms.GroupBox gbxConfig;
        private System.Windows.Forms.RadioButton radioBtn_Manual;
        private System.Windows.Forms.RadioButton radioBtn_Auto;
        private System.Windows.Forms.Panel panelSpeedControlChooser;
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.RadioButton radioBtn_speedHigh;
        private System.Windows.Forms.RadioButton radioBtn_speedMedium;
        private System.Windows.Forms.RadioButton radioBtn_speedLow;
        private System.Windows.Forms.GroupBox gbxGraph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxFanControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDegreeSign;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtn_speedOff;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblFSpeed;
        private System.Windows.Forms.Label lblRPMCount;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStts;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempReading;
    }
}

