using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Restrictor
{
    public partial class LoginForm : Form
    {
        private const string CMD_CANCEL = "/C shutdown -a"; //aborts the shutdown process
        private string _userPW;

        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            { //delete when done
                int hour = DateTime.Now.Hour;
                int min = DateTime.Now.Minute;
                const int SEC = 0;
                TimeSpan NOW = new TimeSpan(hour, min, SEC);
                TimeSpan n = new TimeSpan(12, 40, 0);
                if (NOW >= n)
                {
                    ShutDown();
                }
            }



            lblError.Text = "";
            txtPassword.Focus();
            try
            {
                StreamReader sr = new StreamReader("config.txt");
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Seems like this is the first time you've used this program, let's get you set up", "Restrictor~~~");
                CreateLogin dataCreation = new CreateLogin();
                dataCreation.ShowDialog();
                dataCreation.Focus();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region load password
            try
            {
                StreamReader sr = new StreamReader("config.txt");
                string textToEncrypt = sr.ReadToEnd();
                textToEncrypt = Encoding.Unicode.GetString(Convert.FromBase64String( textToEncrypt));
                string[] fileContents = textToEncrypt.Split('~');

                _userPW = fileContents[0];
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                CreateLogin dataCreation = new CreateLogin();
                dataCreation.ShowDialog();
                dataCreation.Focus();
            }
            #endregion

            if (txtPassword.Text == _userPW)
            {
                System.Diagnostics.Process.Start("CMD.exe", CMD_CANCEL);
                MessageBox.Show("Welcome to Restrictor~~~", "Welcome");
                ControlForm ctrl = new ControlForm();
                lblError.Text = "";
                ctrl.ShowDialog();
            }
            else
            {
                lblError.Text = "Wrong password, good try";
                txtPassword.Focus();
            } 
            txtPassword.Clear();            
        }
        public void LoadTime()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            const int SEC = 0;
            TimeSpan NOW = new TimeSpan(hour, min, SEC);

            StreamReader sr = new StreamReader("ControlFormSetting.txt");
            string[] restrictions = sr.ReadToEnd().Split('&');
            sr.Close();
            string[] times = new string[restrictions.Length * 2];
            int i = 0;
            foreach (string slots in restrictions) //loading time into string array
            {
                string[] tArr = slots.Split('~');
                times[i] = tArr[0];
                i++;
                times[i] = tArr[1];
                i++;
            } //by now times should be loaded
            switch (times.Length)
            {
                case 2:
                      //  ShutDown();
                    break;
                case 4:

                    break;
                case 6:

                    break;
                default:
                    TimeSpan n = new TimeSpan(12,40,0);
                    if (NOW >= n)
                    {
                        MessageBox.Show("After");
                        ShutDown();
                    }
                    break;
            }


        }

        #region Computer Commands
        public void ShutDown()
        {
            Process.Start("shutdown.exe", "-s -t 120"); //not working?
        }
        public void LockComp()
        {
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }
        #endregion
    }
}
