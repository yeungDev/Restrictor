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
        private string _userPW;

        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            txtPassword.Focus();
            try
            {
                StreamReader sr = new StreamReader("config.txt");
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Seems like this is the first time you've used this program, let's get you set up","Restrictor~~~");
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
            catch (FileNotFoundException ex)
            {
                CreateLogin dataCreation = new CreateLogin();
                dataCreation.ShowDialog();
                dataCreation.Focus();
            }
            #endregion

            if (txtPassword.Text == _userPW)
            {
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
                    if (DateTime.Parse(times[0]) < DateTime.Now && DateTime.Now < DateTime.Parse(times[1]))
                        ShutDown();
                    break;
                case 4:

                    break;
                case 6:

                    break;
                default:
                    break;
            }


        }
        public void ShutDown()
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-l -t 180"); //not working?
        }
    }
}
