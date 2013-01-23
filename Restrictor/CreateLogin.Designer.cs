namespace Restrictor
{
    partial class CreateLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPW = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password: ";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(106, 48);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(260, 20);
            this.txtPw.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password: ";
            // 
            // txtConfirmPW
            // 
            this.txtConfirmPW.Location = new System.Drawing.Point(106, 73);
            this.txtConfirmPW.Name = "txtConfirmPW";
            this.txtConfirmPW.Size = new System.Drawing.Size(260, 20);
            this.txtConfirmPW.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(54, 99);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(133, 47);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(193, 99);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(133, 47);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please create a password.  The only rule is no spaces allowed.";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(103, 32);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = ".";
            // 
            // CreateLogin
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 157);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtConfirmPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label1);
            this.Name = "CreateLogin";
            this.Text = "Restrictor~~~ Password";
            this.Load += new System.EventHandler(this.CreateLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPW;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
    }
}