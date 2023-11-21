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
    }
}
