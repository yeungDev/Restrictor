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
        //StreamReader sr = new StreamReader("ControlFormSetting.txt");
        //StreamWriter sw = new StreamWriter("ControlFormSetting.txt");
        private const string CONTROL_FILE = "ControlFormSetting.txt";
        public ControlForm()
        {
            InitializeComponent();
        }
        public string LoadData()
        {
            string temp = "";
            StreamReader _load = new StreamReader(CONTROL_FILE);
            temp = _load.ReadToEnd();
            _load.Close();
            return temp;
        }
        public void SaveData(string s)
        {
            StreamWriter _save = new StreamWriter(CONTROL_FILE);
            _save.Write(s);
            _save.Close();
        }
        private void ControlForm_Load(object sender, EventArgs e)
        {
            lblDescription.Text = "Enter times in a HH:MM format. If the hour is less than 10, please use a zero before the digit, for instance, 9 => 09. Also specify whether it is AM or PM. Here's an ideal entry: 09:45AM.";
            #region Load Time
            //load a ControlFormSettings file to get the time settings
            //max 3 restriction zones
            try
            {
                //need to encode time
                //separate each restriction by & and separate times by ~
                string strSR = LoadData();
                //string[] restrictions = strSR.Split('&');
                string temp = "";

                int i = 0; //count of & signs
                for (int j = 0; j < strSR.Length; j++)
                {
                    if (strSR[j] == '&')
                        i++;
                }
                string[] restrictions = new string[i];
                

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
                    txt1Start.Text = times[0];  //0
                    txt1End.Text = times[1];    //1&2
                    txt2Start.Text = times[2];  //3&4
                    txt2End.Text = times[3];    //5
                    txt3Start.Text = times[4];
                    txt3End.Text = times[5];
                }
            }
            catch
            {
               // MessageBox.Show("ControlForm - \n* unable to load streamreader for ControlFormsSetting.txt\n* or there are currently no time ranges set.");
            }
#endregion


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strTimeToStream = "";
            //check to make sure all times are valid
            if (ValidateTimeEntry(txt1Start.Text,txt1End.Text)) //if both the txt 1 and txt 2 are valid
            {
                strTimeToStream += txt1Start.Text + "~" + txt1End.Text;
            }
            if (ValidateTimeEntry(txt2Start.Text, txt2End.Text))
            {
                if (strTimeToStream != string.Empty)
                {
                    strTimeToStream += "&";
                }
                strTimeToStream += txt2Start.Text + "~" + txt2End.Text;
            }
            if (ValidateTimeEntry(txt3Start.Text, txt3End.Text))
            {
                if (strTimeToStream != string.Empty)
                {
                    strTimeToStream += "&";
                }
                strTimeToStream += txt3Start.Text + "~" + txt3End.Text;

            }
            SaveData(strTimeToStream);
        }

        private void lnkChangePW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateLogin newPW = new CreateLogin();
            newPW.ShowDialog();
            //need to load streamreader/writer on button click event, instead of on load.
        }
        public bool ValidateTimeEntry(params string[] tb)
        {//validate each textbox for a correctly formatted time
            foreach (string txt in tb)
            {
                string strHH, strMM;
                int iHH, iMM;
                if (txt != string.Empty && !string.IsNullOrWhiteSpace(txt)) //only process if it's not empty
                {
                    if (txt.Substring(txt.Length - 2, 2).ToUpper() == "AM" || txt.Substring(txt.Length - 2, 2).ToUpper() == "PM")
                    {
                        strHH = txt.Substring(0, 2);
                        strMM = txt.Substring(3, 2);
                        if (!Int32.TryParse(strHH, out iHH) || !Int32.TryParse(strMM, out iMM))
                        {
                            lblError.Text = "Couldn't convert time";
                            return false;
                        }
                        else //they are integers
                        {
                            if ((iHH >= 1 && iHH <= 12) && (iMM >= 0 && iMM <= 59))
                            {
                                return true;
                            }
                            else
                            {
                                lblError.Text = "You entered an invalid time";
                                return false;
                            }
                        }
                    }
                    else
                    {
                        lblError.Text = "One of the inputs were invalid. Please fix!";
                        return false;
                    }

                }
                else//maybe change this to accept blank (string.empty) value
                {
                    return false;
                }
            }
            return false;
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //sw.Close(); //may not need this
            //CloseStreamWriterOnClosing();
        }
    }
}