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

        private void radioBtn_Manual_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (radioBtn_Manual.Checked)
            {
                gbxAuto.Enabled = false;
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
                lblRPMCount.Text = rnd.Next(0, 12500).ToString();
            }
            else
            {
                gbxManual.Enabled = true;
                lblRPMCount.Text = rnd.Next(0, 12500).ToString();
            }
        }

        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            if ("Disconnect" == btnSerialConnect.Text)
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                btnSerialConnect.Text = "Connect";
                lblStatusText.Text = "Disconnected";
                lblStatusText.ForeColor = Color.Firebrick;
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
                    cboxComport.Enabled = false;
                    cboxBaudrate.Enabled = false;

                    //Add callback handler for receiving
                    //Serial.DataReceived += SerialOnReceivedHandler;
                }
            }
        }

        private void cboxComport_Click(object sender, EventArgs e)
        {
            updateComportList();
        }
    }
}
