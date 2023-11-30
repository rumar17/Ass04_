using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass04_TampusTicod
{


    public partial class fanControl : Form
    {
        private int speedId = 0;

        #region Local Handlers
        private void updateComportList()
        {
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cboxComport.Items.Clear();

            foreach (var item in Ports)
            {
                cboxComport.Items.Add(item);
            }
        }
        #endregion

        public fanControl()
        {
            InitializeComponent();
        }
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            if ("Disconnect" == btnSerialConnect.Text)
            {

                if (true == Serial.IsOpen)
                {
                    lblRPM.Text = "OFF";
                    Serial.WriteLine(0.ToString());
                    Serial.Close();
                }

                btnSerialConnect.Text = "Connect";
                lblStatusText.Text = "Disconnected";
                lblStatusText.ForeColor = Color.Firebrick;
                gbxFanControl.Enabled = false; //disables fan control
                radioBtn_speedOff.Checked = true;
                cboxComport.Enabled = true;
                cboxBaudrate.Enabled = true;

                return;
            }

            //Getting user COM Port from comboBox
            try
            {
                Serial.PortName = cboxComport.Text;
            }
            catch
            {
                MessageBox.Show("No COM Port Selected.");
                return;
            }

            //Getting user Baud Rate from comboBox
            try
            {
                Serial.BaudRate = int.Parse(cboxBaudrate.Text);
            }
            catch
            {
                MessageBox.Show("No Baudrate Selected.");
                return;
            }

            //Checking if COM Port is used by another application
            if (false == Serial.IsOpen)
            {
                try
                {
                    //COM Port available
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("COM Port not accessible", "Error");
                    return;
                }

                if (Serial.IsOpen)
                {
                    btnSerialConnect.Text = "Disconnect";
                    lblStatusText.Text = "Connected, via " + cboxComport.Text;
                    lblStatusText.ForeColor = Color.MediumSeaGreen;
                    gbxFanControl.Enabled = true; //enables fan control
                    cboxComport.Enabled = false;
                    cboxBaudrate.Enabled = false;

                    ChangeSpeed(speedId);

                    //Add callback handler for receiving
                    //Serial.DataReceived += SerialOnReceivedHandler;
                }
            }
        }
        private void radioBtn_Manual_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (radioBtn_Manual.Checked)
            {
                gbxAuto.Enabled = false;
                ChangeSpeed(speedId);
            }
            else
            {
                gbxAuto.Enabled = true;
            }
        }
        private void radioBtn_Auto_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (radioBtn_Auto.Checked)
            {
                gbxManual.Enabled = false;
            }
            else
            {
                gbxManual.Enabled = true;
            }
        }
        private void cboxComport_Click(object sender, EventArgs e)
        {
            updateComportList();
        }
        private void radioBtn_speedOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_speedOff.Checked)
            {
                speedId = 0;
            }
            if (radioBtn_speedLow.Checked)
            {
                speedId = 1;
            }
            if (radioBtn_speedMedium.Checked)
            {
                speedId = 2;
            }
            if (radioBtn_speedHigh.Checked)
            {
                speedId = 3;
            }

            ChangeSpeed(speedId);
        }

        //Functions necessary for the speed changing

        private void ChangeSpeed(int speed)
        {
            switch (speedId)
            {
                case 0:
                    testSpeed.Text = "Speed: Off";

                    if (Serial.IsOpen)
                    {
                        lblRPM.Text = "OFF";
                        Serial.WriteLine(0.ToString());
                    }

                    break;
                case 1:
                    testSpeed.Text = "Speed: Low";


                    if (Serial.IsOpen)
                    {
                        lblRPM.Text = RpmDisp(127);
                        Serial.WriteLine(127.ToString());
                    }

                    break;
                case 2:
                    testSpeed.Text = "Speed: Medium";

                    if (Serial.IsOpen)
                    {
                        lblRPM.Text = RpmDisp(191);
                        Serial.WriteLine(191.ToString());
                    }

                    break;
                case 3:
                    testSpeed.Text = "Speed: High";

                    if (null != Serial)
                    {
                        if (Serial.IsOpen)
                        {
                            lblRPM.Text = RpmDisp(255);
                            Serial.WriteLine(255.ToString());
                        }
                    }

                    break;
                case -1:
                    testSpeed.Text = "Speed: Auto";
                    break;
            }
        }

        private string RpmDisp(float pwmSpeed)
        {
            int rpm;

            rpm = (int)(2720 * pwmSpeed/255);
            return rpm.ToString();
        }

        private void Serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string speedMode = Serial.ReadLine();

            this.Invoke(new Action(() =>
            {
                speedId = int.Parse(speedMode);
            }));
        }

        private void fanControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (true == Serial.IsOpen)
            {
                lblRPM.Text = "OFF";
                Serial.WriteLine(0.ToString());
                Serial.Close();
            }
        }
    }

}
