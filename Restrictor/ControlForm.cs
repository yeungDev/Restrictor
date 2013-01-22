using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Restrictor
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            //load a ControlFormSettings file to get the time settings
            //max 3 restriction zones
            try
            {
                StreamReader sr = new StreamReader("ControlFormSetting.txt");
                //separate each restriction by & and separate times by ~
                string strSR = sr.ReadToEnd();
                sr.Close();
                string[] restrictions = strSR.Split('&');
                if (restrictions.Length == 1) //only one alarm
                {
                    string[] times = strSR.Split('~');
                    txt1Start.Text = times[0];
                    txt1End.Text = times[1];
                }
                else if (restrictions.Length == 2)
                {
                    string[] times = strSR.Split('~');
                    txt1Start.Text = times[0];
                    txt1End.Text = times[1];
                    txt2Start.Text = times[2];
                    txt2End.Text = times[3];
                }
                else if (restrictions.Length == 3)
                {
                    string[] times = strSR.Split('~');
                    txt1Start.Text = times[0];
                    txt1End.Text = times[1];
                    txt2Start.Text = times[2];
                    txt2End.Text = times[3];
                    txt3Start.Text = times[4];
                    txt3End.Text = times[5];
                }
            }
            catch
            {
                MessageBox.Show("ControlForm - \n* unable to load streamreader for ControlFormsSetting.txt\n* or there are currently no time ranges set.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check to make sure all times are valid
        }
    }
}
