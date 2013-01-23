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
            try
            {
                StreamReader sr = new StreamReader("config.txt");
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Seems like this is the first time you've used this program, let's get you set up");
                CreateLogin dataCreation = new CreateLogin();
                dataCreation.ShowDialog();
                dataCreation.Focus();
            }            
        }
        //public void LoadData(StreamReader sw)
        //{
        //    string _data = sw.ReadToEnd();
        //    string[] contents = _data.Split('~'); // userName ~ pw
        //    _userPW = contents[0].ToString();
        //    sw.Close();
        //}

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
                MessageBox.Show("Welcome :)");
                ControlForm ctrl = new ControlForm();
                ctrl.Show();
            }
            else
                MessageBox.Show("Sorry, login info was incorrect. Good Try ;)");
            txtPassword.Clear();            
        }
        static void Encrypt()
        {
            string strName = "JOHN YEUNGs123"; 
            string strEncrypt = Convert.ToBase64String(Encoding.Unicode.GetBytes(strName)); 
            string decrypt = Encoding.Unicode.GetString(Convert.FromBase64String(strEncrypt)); 
            Console.WriteLine("{0}\n\n{1}\n\n{2}", strName, strEncrypt, decrypt);
        }
    }
}
