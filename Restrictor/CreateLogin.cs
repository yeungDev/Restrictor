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
    public partial class CreateLogin : Form
    {
        public CreateLogin()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtPw.Text == txtConfirmPW.Text) //checking to see if passwords match
            {
                StreamWriter sw = new StreamWriter("config.txt");
                sw.Write(Convert.ToBase64String(Encoding.Unicode.GetBytes(txtPw.Text.Trim())));
                sw.Close();
                MessageBox.Show("Congratulations, your login password has been set!", "User Password");
                this.Close();
                lblError.Text = "";
            }
            else
                //MessageBox.Show("Passwords do not match");
                lblError.Text = "Passwords do not match!";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateLogin_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
