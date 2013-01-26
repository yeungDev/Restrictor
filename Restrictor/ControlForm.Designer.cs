namespace Restrictor
{
    partial class ControlForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1Start = new System.Windows.Forms.TextBox();
            this.txt1End = new System.Windows.Forms.TextBox();
            this.txt2Start = new System.Windows.Forms.TextBox();
            this.txt3Start = new System.Windows.Forms.TextBox();
            this.txt3End = new System.Windows.Forms.TextBox();
            this.txt2End = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkChangePW = new System.Windows.Forms.LinkLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restriction 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restriction 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restriction 3:";
            // 
            // txt1Start
            // 
            this.txt1Start.Location = new System.Drawing.Point(102, 34);
            this.txt1Start.Name = "txt1Start";
            this.txt1Start.Size = new System.Drawing.Size(100, 20);
            this.txt1Start.TabIndex = 0;
            // 
            // txt1End
            // 
            this.txt1End.Location = new System.Drawing.Point(212, 34);
            this.txt1End.Name = "txt1End";
            this.txt1End.Size = new System.Drawing.Size(100, 20);
            this.txt1End.TabIndex = 1;
            // 
            // txt2Start
            // 
            this.txt2Start.Location = new System.Drawing.Point(102, 72);
            this.txt2Start.Name = "txt2Start";
            this.txt2Start.Size = new System.Drawing.Size(100, 20);
            this.txt2Start.TabIndex = 2;
            // 
            // txt3Start
            // 
            this.txt3Start.Location = new System.Drawing.Point(102, 108);
            this.txt3Start.Name = "txt3Start";
            this.txt3Start.Size = new System.Drawing.Size(100, 20);
            this.txt3Start.TabIndex = 4;
            // 
            // txt3End
            // 
            this.txt3End.Location = new System.Drawing.Point(212, 108);
            this.txt3End.Name = "txt3End";
            this.txt3End.Size = new System.Drawing.Size(100, 20);
            this.txt3End.TabIndex = 5;
            // 
            // txt2End
            // 
            this.txt2End.Location = new System.Drawing.Point(212, 72);
            this.txt2End.Name = "txt2End";
            this.txt2End.Size = new System.Drawing.Size(100, 20);
            this.txt2End.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(282, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lnkChangePW
            // 
            this.lnkChangePW.AutoSize = true;
            this.lnkChangePW.Location = new System.Drawing.Point(358, 213);
            this.lnkChangePW.Name = "lnkChangePW";
            this.lnkChangePW.Size = new System.Drawing.Size(102, 13);
            this.lnkChangePW.TabIndex = 7;
            this.lnkChangePW.TabStop = true;
            this.lnkChangePW.Text = "Change Password...";
            this.lnkChangePW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePW_LinkClicked);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(332, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(128, 168);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = ".";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(76, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = ".";
            // 
            // ControlForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 235);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lnkChangePW);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt2End);
            this.Controls.Add(this.txt3End);
            this.Controls.Add(this.txt3Start);
            this.Controls.Add(this.txt2Start);
            this.Controls.Add(this.txt1End);
            this.Controls.Add(this.txt1Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1Start;
        private System.Windows.Forms.TextBox txt1End;
        private System.Windows.Forms.TextBox txt2Start;
        private System.Windows.Forms.TextBox txt3Start;
        private System.Windows.Forms.TextBox txt3End;
        private System.Windows.Forms.TextBox txt2End;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkChangePW;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblError;
    }
}