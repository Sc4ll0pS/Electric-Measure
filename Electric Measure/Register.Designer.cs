﻿namespace Electric_Measure
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnewuser = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnregis = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtnewuser
            // 
            this.txtnewuser.Location = new System.Drawing.Point(112, 24);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(229, 20);
            this.txtnewuser.TabIndex = 6;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(112, 59);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(229, 20);
            this.txtnewpass.TabIndex = 7;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(260, 133);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(75, 23);
            this.Register_btn.TabIndex = 8;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(112, 91);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(229, 20);
            this.txtconfirmpassword.TabIndex = 9;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm Password: ";
            // 
            // lnregis
            // 
            this.lnregis.AutoSize = true;
            this.lnregis.Location = new System.Drawing.Point(12, 138);
            this.lnregis.Name = "lnregis";
            this.lnregis.Size = new System.Drawing.Size(132, 13);
            this.lnregis.TabIndex = 11;
            this.lnregis.TabStop = true;
            this.lnregis.Text = "Already have an account?";
            this.lnregis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnregis_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 168);
            this.Controls.Add(this.lnregis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtnewuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnewuser;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnregis;
    }
}