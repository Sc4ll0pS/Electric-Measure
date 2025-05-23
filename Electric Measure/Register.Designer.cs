namespace Electric_Measure
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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "Password:";
            // 
            // txtnewuser
            // 
            this.txtnewuser.BackColor = System.Drawing.SystemColors.Window;
            this.txtnewuser.Location = new System.Drawing.Point(189, 67);
            this.txtnewuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(303, 22);
            this.txtnewuser.TabIndex = 0;
            // 
            // txtnewpass
            // 
            this.txtnewpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtnewpass.Location = new System.Drawing.Point(189, 110);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(303, 22);
            this.txtnewpass.TabIndex = 1;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // Register_btn
            // 
            this.Register_btn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Register_btn.Location = new System.Drawing.Point(386, 200);
            this.Register_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(99, 28);
            this.Register_btn.TabIndex = 3;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtconfirmpassword.Location = new System.Drawing.Point(189, 149);
            this.txtconfirmpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(303, 22);
            this.txtconfirmpassword.TabIndex = 2;
            this.txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "Confirm Password: ";
            // 
            // lnregis
            // 
            this.lnregis.AutoSize = true;
            this.lnregis.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnregis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lnregis.LinkColor = System.Drawing.Color.Blue;
            this.lnregis.Location = new System.Drawing.Point(16, 205);
            this.lnregis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnregis.Name = "lnregis";
            this.lnregis.Size = new System.Drawing.Size(185, 21);
            this.lnregis.TabIndex = 4;
            this.lnregis.TabStop = true;
            this.lnregis.Text = "Already have an account?";
            this.lnregis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnregis_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(14, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 33);
            this.label4.TabIndex = 100;
            this.label4.Text = "Create new user";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(520, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnregis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtnewuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label4;
    }
}