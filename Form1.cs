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


    public partial class Form1 : Form
    {
        private int speedMode = 0;

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

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            if ("Disconnect" == btnSerialConnect.Text)
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                changeSpeed_Manual(0); //speed change

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

                    changeSpeed_Manual(speedMode);

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
                changeSpeed_Manual(speedMode);
                lblRPMCount.Text = rnd.Next(0, 12500).ToString();
            }
            else
            {
                gbxAuto.Enabled = true;
                lblRPMCount.Text = rnd.Next(0, 12500).ToString();
            }
        }
        private void radioBtn_Auto_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (radioBtn_Auto.Checked)
            {
                gbxManual.Enabled = false;
                changeSpeed_Manual(-1);
                lblRPMCount.Text = rnd.Next(0, 12500).ToString();
            }
            else
            {
                gbxManual.Enabled = true;
                btnConfirm.Enabled = false;
                lblRPMCount.Text = rnd.Next(0, 12500).ToString();
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
                speedMode = 0;
            }
            if (radioBtn_speedLow.Checked)
            {
                speedMode = 1;
            }
            if (radioBtn_speedMedium.Checked)
            {
                speedMode = 2;
            }
            if (radioBtn_speedHigh.Checked)
            {
                speedMode = 3;
            }

            changeSpeed_Manual(speedMode);
        }

        //Functions necessary for the speed changing

        private void changeSpeed_Manual(int speed)
        {
            switch (speed)
            {
                case 0:
                    testSpeed.Text = "Speed: Off";
                    break;
                case 1:
                    testSpeed.Text = "Speed: Low";
                    break;
                case 2:
                    testSpeed.Text = "Speed: Medium";
                    break;
                case 3:
                    testSpeed.Text = "Speed: High";
                    break;
                default:
                    testSpeed.Text = "Speed: Auto";
                    break;
            }
        }

    }

}
