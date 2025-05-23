namespace Electric_Measure
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.typedbox = new System.Windows.Forms.ComboBox();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbunit = new System.Windows.Forms.Label();
            this.txbunit = new System.Windows.Forms.TextBox();
            this.lbsubtype = new System.Windows.Forms.Label();
            this.subdbox = new System.Windows.Forms.ComboBox();
            this.lboffpeak = new System.Windows.Forms.Label();
            this.txboffpeak = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.rd24V = new System.Windows.Forms.RadioButton();
            this.rd12V = new System.Windows.Forms.RadioButton();
            this.lbvoltage = new System.Windows.Forms.Label();
            this.rd69V = new System.Windows.Forms.RadioButton();
            this.lbchargetitle = new System.Windows.Forms.Label();
            this.lbtypetitle = new System.Windows.Forms.Label();
            this.lbdemandtitle = new System.Windows.Forms.Label();
            this.txbdmoffpeak = new System.Windows.Forms.TextBox();
            this.lbdmoffpeak = new System.Windows.Forms.Label();
            this.txbdmunit = new System.Windows.Forms.TextBox();
            this.lbdmunit = new System.Windows.Forms.Label();
            this.txbdmpp = new System.Windows.Forms.TextBox();
            this.lbdmpp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // typedbox
            // 
            this.typedbox.FormattingEnabled = true;
            this.typedbox.Items.AddRange(new object[] {
            "Type 1 Residential Service",
            "Type 2 Small General Service",
            "Type 3 Medium General Service",
            "Type 4 Large General Service",
            "Type 5 Specific Business Service",
            "Type 6 Non-Profit Organizations",
            "Type 7 Water Pumping for Agricultural Purposes",
            "Type 8 Temporary Tariff"});
            this.typedbox.Location = new System.Drawing.Point(123, 96);
            this.typedbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typedbox.Name = "typedbox";
            this.typedbox.Size = new System.Drawing.Size(245, 26);
            this.typedbox.TabIndex = 0;
            this.typedbox.SelectedIndexChanged += new System.EventHandler(this.typedbox_SelectedIndexChanged);
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(17, 99);
            this.lbtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(64, 18);
            this.lbtype.TabIndex = 4;
            this.lbtype.Text = "Types: ";
            // 
            // lbunit
            // 
            this.lbunit.AutoSize = true;
            this.lbunit.Location = new System.Drawing.Point(17, 189);
            this.lbunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunit.Name = "lbunit";
            this.lbunit.Size = new System.Drawing.Size(72, 18);
            this.lbunit.TabIndex = 5;
            this.lbunit.Text = "On Peak:";
            // 
            // txbunit
            // 
            this.txbunit.Location = new System.Drawing.Point(123, 186);
            this.txbunit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbunit.Name = "txbunit";
            this.txbunit.Size = new System.Drawing.Size(245, 25);
            this.txbunit.TabIndex = 2;
            // 
            // lbsubtype
            // 
            this.lbsubtype.AutoSize = true;
            this.lbsubtype.Location = new System.Drawing.Point(408, 99);
            this.lbsubtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsubtype.Name = "lbsubtype";
            this.lbsubtype.Size = new System.Drawing.Size(80, 18);
            this.lbsubtype.TabIndex = 7;
            this.lbsubtype.Text = "Subtypes:";
            // 
            // subdbox
            // 
            this.subdbox.FormattingEnabled = true;
            this.subdbox.Items.AddRange(new object[] {
            "Type 1 Residential Service",
            "Type 2 Small General Service",
            "Type 3 Medium General Service",
            "Type 4 Large General ServiceType",
            "Type 5 Specific Business Service",
            "Type 6 Non-Profit Organizations",
            "Type 7 Water Pumping for Agricultural Purposes",
            "Type 8 Temporary Tariff"});
            this.subdbox.Location = new System.Drawing.Point(496, 99);
            this.subdbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subdbox.Name = "subdbox";
            this.subdbox.Size = new System.Drawing.Size(245, 26);
            this.subdbox.TabIndex = 1;
            this.subdbox.SelectedIndexChanged += new System.EventHandler(this.subdbox_SelectedIndexChanged);
            // 
            // lboffpeak
            // 
            this.lboffpeak.AutoSize = true;
            this.lboffpeak.Location = new System.Drawing.Point(405, 190);
            this.lboffpeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lboffpeak.Name = "lboffpeak";
            this.lboffpeak.Size = new System.Drawing.Size(88, 18);
            this.lboffpeak.TabIndex = 9;
            this.lboffpeak.Text = "Off Peak: ";
            // 
            // txboffpeak
            // 
            this.txboffpeak.Location = new System.Drawing.Point(496, 186);
            this.txboffpeak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txboffpeak.Name = "txboffpeak";
            this.txboffpeak.Size = new System.Drawing.Size(245, 25);
            this.txboffpeak.TabIndex = 3;
            // 
            // btnstart
            // 
            this.btnstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstart.Location = new System.Drawing.Point(659, 450);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(95, 42);
            this.btnstart.TabIndex = 10;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(552, 450);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 42);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // rd24V
            // 
            this.rd24V.AutoSize = true;
            this.rd24V.Location = new System.Drawing.Point(142, 416);
            this.rd24V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd24V.Name = "rd24V";
            this.rd24V.Size = new System.Drawing.Size(109, 22);
            this.rd24V.TabIndex = 7;
            this.rd24V.TabStop = true;
            this.rd24V.Text = "12 - 24 kV";
            this.rd24V.UseVisualStyleBackColor = true;
            this.rd24V.Visible = false;
            // 
            // rd12V
            // 
            this.rd12V.AutoSize = true;
            this.rd12V.Location = new System.Drawing.Point(19, 415);
            this.rd12V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd12V.Name = "rd12V";
            this.rd12V.Size = new System.Drawing.Size(117, 22);
            this.rd12V.TabIndex = 6;
            this.rd12V.TabStop = true;
            this.rd12V.Text = "Below 12 kV";
            this.rd12V.UseVisualStyleBackColor = true;
            this.rd12V.Visible = false;
            // 
            // lbvoltage
            // 
            this.lbvoltage.AutoSize = true;
            this.lbvoltage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvoltage.Location = new System.Drawing.Point(15, 384);
            this.lbvoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbvoltage.Name = "lbvoltage";
            this.lbvoltage.Size = new System.Drawing.Size(64, 18);
            this.lbvoltage.TabIndex = 22;
            this.lbvoltage.Text = "Voltage";
            this.lbvoltage.Visible = false;
            // 
            // rd69V
            // 
            this.rd69V.AutoSize = true;
            this.rd69V.Location = new System.Drawing.Point(251, 416);
            this.rd69V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd69V.Name = "rd69V";
            this.rd69V.Size = new System.Drawing.Size(141, 22);
            this.rd69V.TabIndex = 8;
            this.rd69V.TabStop = true;
            this.rd69V.Text = "69 kV and over";
            this.rd69V.UseVisualStyleBackColor = true;
            this.rd69V.Visible = false;
            // 
            // lbchargetitle
            // 
            this.lbchargetitle.AutoSize = true;
            this.lbchargetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbchargetitle.Location = new System.Drawing.Point(286, 146);
            this.lbchargetitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbchargetitle.Name = "lbchargetitle";
            this.lbchargetitle.Size = new System.Drawing.Size(170, 17);
            this.lbchargetitle.TabIndex = 24;
            this.lbchargetitle.Text = "Energy Charge in kWh";
            // 
            // lbtypetitle
            // 
            this.lbtypetitle.AutoSize = true;
            this.lbtypetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbtypetitle.Location = new System.Drawing.Point(352, 63);
            this.lbtypetitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtypetitle.Name = "lbtypetitle";
            this.lbtypetitle.Size = new System.Drawing.Size(44, 17);
            this.lbtypetitle.TabIndex = 25;
            this.lbtypetitle.Text = "Type";
            // 
            // lbdemandtitle
            // 
            this.lbdemandtitle.AutoSize = true;
            this.lbdemandtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbdemandtitle.Location = new System.Drawing.Point(287, 233);
            this.lbdemandtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdemandtitle.Name = "lbdemandtitle";
            this.lbdemandtitle.Size = new System.Drawing.Size(168, 17);
            this.lbdemandtitle.TabIndex = 26;
            this.lbdemandtitle.Text = "Energy Demand in kW";
            // 
            // txbdmoffpeak
            // 
            this.txbdmoffpeak.Location = new System.Drawing.Point(496, 272);
            this.txbdmoffpeak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbdmoffpeak.Name = "txbdmoffpeak";
            this.txbdmoffpeak.Size = new System.Drawing.Size(245, 25);
            this.txbdmoffpeak.TabIndex = 5;
            // 
            // lbdmoffpeak
            // 
            this.lbdmoffpeak.AutoSize = true;
            this.lbdmoffpeak.Location = new System.Drawing.Point(405, 275);
            this.lbdmoffpeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdmoffpeak.Name = "lbdmoffpeak";
            this.lbdmoffpeak.Size = new System.Drawing.Size(88, 18);
            this.lbdmoffpeak.TabIndex = 29;
            this.lbdmoffpeak.Text = "Off Peak: ";
            // 
            // txbdmunit
            // 
            this.txbdmunit.Location = new System.Drawing.Point(123, 276);
            this.txbdmunit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbdmunit.Name = "txbdmunit";
            this.txbdmunit.Size = new System.Drawing.Size(245, 25);
            this.txbdmunit.TabIndex = 4;
            // 
            // lbdmunit
            // 
            this.lbdmunit.AutoSize = true;
            this.lbdmunit.Location = new System.Drawing.Point(14, 275);
            this.lbdmunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdmunit.Name = "lbdmunit";
            this.lbdmunit.Size = new System.Drawing.Size(72, 18);
            this.lbdmunit.TabIndex = 27;
            this.lbdmunit.Text = "On Peak:";
            // 
            // txbdmpp
            // 
            this.txbdmpp.Location = new System.Drawing.Point(123, 324);
            this.txbdmpp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbdmpp.Name = "txbdmpp";
            this.txbdmpp.Size = new System.Drawing.Size(245, 25);
            this.txbdmpp.TabIndex = 30;
            // 
            // lbdmpp
            // 
            this.lbdmpp.AutoSize = true;
            this.lbdmpp.Location = new System.Drawing.Point(11, 329);
            this.lbdmpp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdmpp.Name = "lbdmpp";
            this.lbdmpp.Size = new System.Drawing.Size(120, 18);
            this.lbdmpp.TabIndex = 31;
            this.lbdmpp.Text = "Partial Peak: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Electric Measure";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(791, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbdmpp);
            this.Controls.Add(this.lbdmpp);
            this.Controls.Add(this.txbdmoffpeak);
            this.Controls.Add(this.lbdmoffpeak);
            this.Controls.Add(this.txbdmunit);
            this.Controls.Add(this.lbdmunit);
            this.Controls.Add(this.lbdemandtitle);
            this.Controls.Add(this.lbtypetitle);
            this.Controls.Add(this.lbchargetitle);
            this.Controls.Add(this.rd69V);
            this.Controls.Add(this.lbvoltage);
            this.Controls.Add(this.rd12V);
            this.Controls.Add(this.rd24V);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txboffpeak);
            this.Controls.Add(this.lboffpeak);
            this.Controls.Add(this.subdbox);
            this.Controls.Add(this.lbsubtype);
            this.Controls.Add(this.txbunit);
            this.Controls.Add(this.lbunit);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.typedbox);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Electric Measure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typedbox;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbunit;
        private System.Windows.Forms.TextBox txbunit;
        private System.Windows.Forms.Label lbsubtype;
        private System.Windows.Forms.ComboBox subdbox;
        private System.Windows.Forms.Label lboffpeak;
        private System.Windows.Forms.TextBox txboffpeak;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.RadioButton rd24V;
        private System.Windows.Forms.RadioButton rd12V;
        private System.Windows.Forms.Label lbvoltage;
        private System.Windows.Forms.RadioButton rd69V;
        private System.Windows.Forms.Label lbchargetitle;
        private System.Windows.Forms.Label lbtypetitle;
        private System.Windows.Forms.Label lbdemandtitle;
        private System.Windows.Forms.TextBox txbdmoffpeak;
        private System.Windows.Forms.Label lbdmoffpeak;
        private System.Windows.Forms.TextBox txbdmunit;
        private System.Windows.Forms.Label lbdmunit;
        private System.Windows.Forms.TextBox txbdmpp;
        private System.Windows.Forms.Label lbdmpp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}