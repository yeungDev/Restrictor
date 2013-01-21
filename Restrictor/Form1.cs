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
    public partial class Form1 : Form
    {
        private string _userPW;
        private string _userName;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //try to get data from config.txt
            try
            {
                StreamReader sr = new StreamReader("config.txt");
            }
            catch
            {
                //StreamWriter sw = new StreamWriter("config.txt");
                CreateData();
            }
        }
        public void LoadData(StreamReader sw)
        {
            string _data = sw.ReadToEnd();
            string[] contents = _data.Split('~'); // userName ~ pw
            _userName = contents[0].ToString();
            _userPW = contents[1].ToString();
            sw.Close();
        }
        public void CreateData()
        {
            Form2 dataCreation = new Form2();
            dataCreation.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == _userPW && txtUser.Text == _userName)
            {
                ControlForm ctrl = new ControlForm();
                ctrl.Show();
            }
            else
                MessageBox.Show("Sorry, login info was incorrect. Good Try ;)");
        }
    }
}
