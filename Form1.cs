using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ass04_Macapobre
{
    public partial class fanControl : Form
    {
        private int[] _tempPoints;      //vertical points of the Graph
        private int _tempId = 0;        //Binary value of temperature from LM35
        private int _tempHolder;        //temporary temperature ID storage
        private int _fanSpeed = 0;      //PWM value of the fan speed
        private bool _isManual = true;  //Checks if fan is in manual mode

        #region Local Handlers
        private void UpdateComportList()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            cboxComport.Items.Clear();

            foreach (var item in ports)
            {
                cboxComport.Items.Add(item);
            }
        }
        #endregion

        //Initializes the Application
        public fanControl()
        {
            InitializeComponent();
            InitializePoints();
        }

        //Updates COM Ports once click event is triggered
        private void cboxComport_Click(object sender, EventArgs e)
        {
            UpdateComportList();
        }

        //Attempts to connect to serial once clicked
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            if ("Disconnect" == btnSerialConnect.Text)
            {
                if (true == Serial.IsOpen)
                {
                    tempReading.Text = "NaN";
                    Serial.WriteLine(0.ToString());

                    drawTimer.Stop();
                    Serial.Close();
                }

                btnSerialConnect.Text = "Connect";
                lblStatusText.Text = "Disconnected";
                lblStatusText.ForeColor = Color.Firebrick;
                gbxFanControl.Enabled = false;
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
                MessageBox.Show("COM Port must not be empty.", "No COM Port Selected");
                return;
            }

            try
            {
                Serial.BaudRate = int.Parse(cboxBaudrate.Text);
            }
            catch
            {
                MessageBox.Show("Baud Rate must not be empty.", "No Baudrate selected");
                return;
            }

            if (false == Serial.IsOpen)
            {
                try
                {   
                    
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("COM Port not accessible", "Error");
                    return;
                }

                if (Serial.IsOpen)
                {
                    Serial.DtrEnable = true;

                    drawTimer.Start();

                    btnSerialConnect.Text = "Disconnect";
                    lblStatusText.Text = "Connected, via " + cboxComport.Text;
                    lblStatusText.ForeColor = Color.MediumSeaGreen;
                    gbxFanControl.Enabled = true;
                    cboxComport.Enabled = false;
                    cboxBaudrate.Enabled = false;
                }
            }
        }

        private void radioBtn_Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Manual.Checked)
            {
                gbxAuto.Enabled = false;
                _isManual = true;
                minPWM.Enabled = label10.Enabled = lblMinPWM.Enabled = false;

                FanControl(_isManual);
            }
            else
            {
                gbxAuto.Enabled = true;
                _isManual = false;
                minPWM.Enabled = label10.Enabled = lblMinPWM.Enabled = true;

                FanControl(_isManual);
            }
        }

        private void radioBtn_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Auto.Checked)
            {
                gbxManual.Enabled = false;
                _isManual = false;
                minPWM.Enabled = label10.Enabled = lblMinPWM.Enabled = true;

                FanControl(_isManual);
            }
            else
            {
                gbxManual.Enabled = true;
                _isManual = true;
                minPWM.Enabled = label10.Enabled = lblMinPWM.Enabled = false;

                FanControl(_isManual);
            }
        }

        private void Serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (Serial.IsOpen)
            {
                string stringTemperature = Serial.ReadLine();
                string strTempTrim = stringTemperature.Trim();

                this.BeginInvoke(new EventHandler(((object o, EventArgs a) =>
                {
                    if (int.TryParse(strTempTrim, out _tempId))
                    {
                        if (!(_tempId > 255))
                        {
                            _tempHolder = _tempId;
                            tempReading.Text = Convert_toTemp(_tempId);

                            FanControl(_isManual);
                            transLateToY(int.Parse(tempReading.Text));

                            // refresh here
                        }
                        else
                        {
                            tempReading.Text = "NaN";

                            FanControl(_isManual);
                            transLateToY(0);
                        }
                    }
                    else
                    {
                        tempReading.Text = Convert_toTemp(_tempHolder);
                        transLateToY(int.Parse(tempReading.Text));
                    }
                })));
            }
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            //pbGraph.Refresh();
        }

        private void fanControl_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tempControl_ValueChanged(object sender, EventArgs e)
        {
            FanControl(_isManual);
        }

        private void minPWM_ValueChanged(object sender, EventArgs e)
        {
            lblMinPWM.Text = minPWM.Value.ToString();
        }

        private void fanControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (true == Serial.IsOpen)
            {
                Serial.WriteLine(0.ToString());
                Serial.Close();
            }
        }

        

        private string Convert_toTemp(int temp_inBin)
        {
            return Math.Round(((temp_inBin * 0.0043) * 100.0)).ToString();
        }

        private void InitializePoints()
        {
            int pointsCount = 10;

            _tempPoints = new Int32[pointsCount];
        }

        private void transLateToY(int pointId)
        {
            Double tempYCoord = Math.Round((pointId / 110.0) * 120);

            for (int i = 9; i > 0; i--)
            {
                _tempPoints[i] = _tempPoints[i-1];
            }

            _tempPoints[0] = (int)tempYCoord;
        }

        private void FanControl(bool fanControlMode)
        {
            if (_isManual)
            {   

                if (radioBtn_speedOff.Checked)
                {
                    _fanSpeed = 0;
                }
                else if (radioBtn_speedLow.Checked)
                {
                    _fanSpeed = 130;
                }
                else if (radioBtn_speedMedium.Checked)
                {
                    _fanSpeed = 204;
                }
                else if (radioBtn_speedHigh.Checked)
                {
                    _fanSpeed = 255;
                }
                else
                {
                    _fanSpeed = 0;
                }

                if (Serial.IsOpen)
                {
                    Serial.WriteLine(_fanSpeed.ToString());

                    pwmSpeedAmt.Text = _fanSpeed.ToString();
                }
            }
            else
            {  

                double tempDifference = ((_tempId * 0.0043) * 100.0) - (double)tempControl.Value;

                if (tempDifference >= 5.0)  
                {
                    //triggers if temperature differential is above 5 degrees

                    _fanSpeed = 255;
                }
                else if (tempDifference < 5.0 && tempDifference > 0)
                {
                    //triggers if temperature differential is between 0 and 5 degrees

                    double speedDouble = Math.Round((tempDifference / 5.0) * 255);

                    if ((speedDouble - ((minPWM.Value / 100.0) * 255.0)) > 0)
                    {
                        _fanSpeed = (int)Math.Round(((minPWM.Value / 100.0) * 255) + ((1.0 + (minPWM.Value / 100.0)) * Math.Abs(speedDouble - ((minPWM.Value / 100.0) * 255.0))));
                    }
                    else
                    {
                        _fanSpeed = (int)Math.Round(((minPWM.Value / 100.0) * 255) + ((1.0 + (minPWM.Value / 100.0)) * 1));
                    }
                    
                    if (_fanSpeed > 255)
                    {
                        _fanSpeed = 255;
                    }
                }
                else                        
                {
                    //triggers when temperature differential is 0 degrees below;
                    
                    _fanSpeed = 0;
                }

                if (Serial.IsOpen)
                {
                        Serial.WriteLine(_fanSpeed.ToString());
                        pwmSpeedAmt.Text = _fanSpeed.ToString();

                }
            }
        }
    }
}