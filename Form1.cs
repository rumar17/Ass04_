using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass04_TampusTicod
{


    public partial class fanControl : Form
    {
        private int[] _tempPoints;  //vertical points of the Graph
        private int _speedId = 0;   //changes speed mode
        private int _tempId = 0;    //Binary value of temperature from LM35
        private int _tempHolder;    //temporary temperature ID storage
        private double _tempDouble; //temperature value in double
        int speedReturn;

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

        public fanControl()
        {
            InitializeComponent();
            InitializePoints();
        }
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            if ("Disconnect" == btnSerialConnect.Text)
            {

                if (true == Serial.IsOpen)
                {
                    lblRPM.Text = "OFF";
                    tempReading.Text = "NaN";
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
                    drawTimer.Start();
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

                    ChangeSpeed(_speedId);

                    //Add callback handler for receiving
                    //Serial.DataReceived += SerialOnReceivedHandler;
                }
            }
        }
        private void radioBtn_Manual_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtn_Manual.Checked)
            {
                radioBtn_speedOff.Checked = true;
                gbxAuto.Enabled = false;
                ChangeSpeed(_speedId);
            }
            else
            {
                gbxAuto.Enabled = true;
                ChangeSpeed(-1);
            }
        }
        private void radioBtn_Auto_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtn_Auto.Checked)
            {
                gbxManual.Enabled = false;
                ChangeSpeed(-1);
            }
            else
            {
                gbxManual.Enabled = true;
                radioBtn_speedOff.Checked = true;
            }
        }
        private void cboxComport_Click(object sender, EventArgs e)
        {
            UpdateComportList();
        }
        private void radioBtn_speedOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_speedOff.Checked)
            {
                _speedId = 0;
            }
            if (radioBtn_speedLow.Checked)
            {
                _speedId = 1;
            }
            if (radioBtn_speedMedium.Checked)
            {
                _speedId = 2;
            }
            if (radioBtn_speedHigh.Checked)
            {
                _speedId = 3;
            }

            ChangeSpeed(_speedId);
        }


        //Functions necessary for the speed changing

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
                            transLateToY((int)_tempDouble);
                        }
                        else
                        {
                            tempReading.Text = "NaN";
                            transLateToY(0);
                        }
                    }
                    else
                    {
                        tempReading.Text = Convert_toTemp(_tempHolder);
                        transLateToY((int)_tempDouble);
                    }
                })));
            }
        }
        private void pbGraph_Paint(object sender, PaintEventArgs e)
        {
            Bitmap graphBm = new Bitmap(240, 125);
            Graphics graph = Graphics.FromImage(graphBm);
            graph.SmoothingMode = SmoothingMode.AntiAlias;


            Brush lineBrush = new SolidBrush(Color.DimGray);
            Brush pointBrush = new SolidBrush(Color.SlateGray);
            Brush graphBrush = new SolidBrush(Color.FromArgb(50, Color.SlateGray));
            Pen graphPen = new Pen(graphBrush, 1);
            Pen linePen = new Pen(lineBrush, 1);
            Pen pointPen = new Pen(pointBrush, 3);

            for (int i = 0; i < 9; i++)
            {

                graph.DrawLine(graphPen, new Point(240 - (27 * i), 0), new Point(240 - (27 * i), 125));
                graph.DrawLine(linePen, new Point(240 - (27 * i), (125 - _tempPoints[i])), new Point(240 - (27 * (i + 1)), (125 - _tempPoints[i + 1])));
                graph.DrawEllipse(pointPen, (240 - (27 * i)) - 1, (125 - _tempPoints[i]) - 1, 2, 2);
            }

            for (int i = 0; i < 4; i++)
            {
                graph.DrawLine(graphPen, new Point(0, (125 - (27 * i))), new Point(240, (125 - (27 * i))));
            }

            pbGraph.Image = graphBm;
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

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            if (radioBtn_Auto.Checked)
            {
                AutoSpeed(int.Parse(tbxTemp.Text));
            }

            this.Invalidate();
        }

        private void ChangeSpeed(int speed)
        {
            switch (_speedId)
            {
                case 0:

                    if (Serial.IsOpen)
                    {
                        lblRPM.Text = "OFF";
                        Serial.WriteLine(0.ToString());
                    }

                    break;
                case 1:

                    if (Serial.IsOpen)
                    {
                        RpmDisp(102);
                        Serial.WriteLine(102.ToString());
                    }

                    break;
                case 2:

                    if (Serial.IsOpen)
                    {
                        RpmDisp(179);
                        Serial.WriteLine(179.ToString());
                    }

                    break;
                case 3:
                    if (null != Serial)
                    {
                        if (Serial.IsOpen)
                        {
                            RpmDisp(255);
                            Serial.WriteLine(255.ToString());
                        }
                    }

                    break;
                case -1:
                    AutoSpeed((int)_tempDouble);
                    break;
            }
        }

        private void RpmDisp(float pwmSpeed)
        {
            int rpm;

            rpm = (int)(2720 * pwmSpeed / 255);
            lblRPM.Text = rpm.ToString();
        }

        private string Convert_toTemp(int temp_inBin)
        {
            _tempDouble = Math.Round(((temp_inBin * 0.0043) * 100.0));

            return _tempDouble.ToString();
        }

        private void InitializePoints()
        {
            int pointsCount = 10;

            _tempPoints = new Int32[pointsCount];

        }

        private void transLateToY(int pointId)
        {
            Double tempYCoord = Math.Round((pointId / 110.0) * 120);

            //Point[] temp = tempPoints;

            for (int i = 9; i > 0; i--)
            {
                _tempPoints[i] = _tempPoints[i-1];
            }

            _tempPoints[0] = (int)tempYCoord;

            /*label9.Text = _tempPoints[0].ToString();
            label10.Text = _tempPoints[1].ToString();
            label11.Text = _tempPoints[2].ToString();
            label12.Text = _tempPoints[3].ToString();
            label13.Text = _tempPoints[4].ToString();
            label14.Text = _tempPoints[5].ToString();
            label15.Text = _tempPoints[6].ToString();
            label16.Text = _tempPoints[7].ToString();
            label17.Text = _tempPoints[8].ToString();
            label18.Text = _tempPoints[9].ToString();*/
        }

        //AUTOSPEED - TO BE FINISHED NEXT; add numericUpDown component, modify contents (pushed)

        private void AutoSpeed(int temp)
        {
            int intDifferential = int.Parse(tempReading.Text) - temp;
            
            intDiff.Text = intDifferential.ToString();

            if (intDifferential > 5)
            {
                speedReturn = 255;
            }
            else if (intDifferential <= 5 && intDifferential >=0)
            {
                speedReturn = (int)((intDifferential / 5.0) * 255);
            }
            else
            {
                speedReturn = 0;
            }

            testSpeed.Text = speedReturn.ToString();

            Serial.Write(speedReturn.ToString());
        }

    }

}
