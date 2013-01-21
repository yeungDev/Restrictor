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
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Are you sure this is what you want your info to be? Please enter 'Y' or 'Yes', otherwise anything else will be no");
            string input = Console.ReadLine();
            if (input.ToLower() == "y" || input.ToLower() == "yes")
            {
                StreamWriter sw = new StreamWriter("config.txt");
                sw.Write(txtUserName + "~" + txtPW);
                sw.Close();
                MessageBox.Show("Please close the program and login with your new login credentials");
                btnAccept.Enabled = false;
                btnCancel.Enabled = false;
            }
            //else
               // goto askAgain;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
