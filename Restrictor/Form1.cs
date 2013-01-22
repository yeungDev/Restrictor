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
    public partial class LoginForm : Form
    {
        private string _userPW;

        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
            //try to get data from config.txt
            try
            {
                StreamReader sr = new StreamReader("config.txt");
                string[] fileContents = sr.ReadToEnd().Split('~');
                _userPW = fileContents[0];
            }
            catch (FileNotFoundException ex)
            {
                //StreamWriter sw = new StreamWriter("config.txt");
                //MessageBox.Show("Seems like this is the first time you've used this program, let's get you set up");
                CreateLogin dataCreation = new CreateLogin();
                dataCreation.ShowDialog();
                dataCreation.Focus();
            }
        }
        public void LoadData(StreamReader sw)
        {
            string _data = sw.ReadToEnd();
            string[] contents = _data.Split('~'); // userName ~ pw
            _userPW = contents[0].ToString();
            sw.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (txtPassword.Text == _userPW)
            {
                MessageBox.Show("Welcome :)");
                ControlForm ctrl = new ControlForm();
                ctrl.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sorry, login info was incorrect. Good Try ;)");
            txtPassword.Clear();
            
        }
    }
}
