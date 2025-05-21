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
            this.typedbox.Location = new System.Drawing.Point(77, 43);
            this.typedbox.Name = "typedbox";
            this.typedbox.Size = new System.Drawing.Size(185, 21);
            this.typedbox.TabIndex = 0;
            this.typedbox.SelectedIndexChanged += new System.EventHandler(this.typedbox_SelectedIndexChanged);
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(13, 46);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(42, 13);
            this.lbtype.TabIndex = 4;
            this.lbtype.Text = "Types: ";
            // 
            // lbunit
            // 
            this.lbunit.AutoSize = true;
            this.lbunit.Location = new System.Drawing.Point(13, 111);
            this.lbunit.Name = "lbunit";
            this.lbunit.Size = new System.Drawing.Size(52, 13);
            this.lbunit.TabIndex = 5;
            this.lbunit.Text = "On Peak:";
            // 
            // txbunit
            // 
            this.txbunit.Location = new System.Drawing.Point(77, 108);
            this.txbunit.Name = "txbunit";
            this.txbunit.Size = new System.Drawing.Size(185, 20);
            this.txbunit.TabIndex = 2;
            // 
            // lbsubtype
            // 
            this.lbsubtype.AutoSize = true;
            this.lbsubtype.Location = new System.Drawing.Point(278, 46);
            this.lbsubtype.Name = "lbsubtype";
            this.lbsubtype.Size = new System.Drawing.Size(54, 13);
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
            this.subdbox.Location = new System.Drawing.Point(340, 46);
            this.subdbox.Name = "subdbox";
            this.subdbox.Size = new System.Drawing.Size(185, 21);
            this.subdbox.TabIndex = 1;
            this.subdbox.SelectedIndexChanged += new System.EventHandler(this.subdbox_SelectedIndexChanged);
            // 
            // lboffpeak
            // 
            this.lboffpeak.AutoSize = true;
            this.lboffpeak.Location = new System.Drawing.Point(277, 112);
            this.lboffpeak.Name = "lboffpeak";
            this.lboffpeak.Size = new System.Drawing.Size(55, 13);
            this.lboffpeak.TabIndex = 9;
            this.lboffpeak.Text = "Off Peak: ";
            // 
            // txboffpeak
            // 
            this.txboffpeak.Location = new System.Drawing.Point(340, 108);
            this.txboffpeak.Name = "txboffpeak";
            this.txboffpeak.Size = new System.Drawing.Size(185, 20);
            this.txboffpeak.TabIndex = 3;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(448, 319);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(71, 30);
            this.btnstart.TabIndex = 10;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(367, 319);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(71, 30);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // rd24V
            // 
            this.rd24V.AutoSize = true;
            this.rd24V.Location = new System.Drawing.Point(152, 278);
            this.rd24V.Name = "rd24V";
            this.rd24V.Size = new System.Drawing.Size(74, 17);
            this.rd24V.TabIndex = 7;
            this.rd24V.TabStop = true;
            this.rd24V.Text = "12 - 24 kV";
            this.rd24V.UseVisualStyleBackColor = true;
            this.rd24V.Visible = false;
            // 
            // rd12V
            // 
            this.rd12V.AutoSize = true;
            this.rd12V.Location = new System.Drawing.Point(61, 277);
            this.rd12V.Name = "rd12V";
            this.rd12V.Size = new System.Drawing.Size(85, 17);
            this.rd12V.TabIndex = 6;
            this.rd12V.TabStop = true;
            this.rd12V.Text = "Below 12 kV";
            this.rd12V.UseVisualStyleBackColor = true;
            this.rd12V.Visible = false;
            // 
            // lbvoltage
            // 
            this.lbvoltage.AutoSize = true;
            this.lbvoltage.Location = new System.Drawing.Point(11, 277);
            this.lbvoltage.Name = "lbvoltage";
            this.lbvoltage.Size = new System.Drawing.Size(43, 13);
            this.lbvoltage.TabIndex = 22;
            this.lbvoltage.Text = "Voltage";
            this.lbvoltage.Visible = false;
            // 
            // rd69V
            // 
            this.rd69V.AutoSize = true;
            this.rd69V.Location = new System.Drawing.Point(235, 278);
            this.rd69V.Name = "rd69V";
            this.rd69V.Size = new System.Drawing.Size(98, 17);
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
            this.lbchargetitle.Location = new System.Drawing.Point(199, 80);
            this.lbchargetitle.Name = "lbchargetitle";
            this.lbchargetitle.Size = new System.Drawing.Size(134, 13);
            this.lbchargetitle.TabIndex = 24;
            this.lbchargetitle.Text = "Energy Charge in kWh";
            // 
            // lbtypetitle
            // 
            this.lbtypetitle.AutoSize = true;
            this.lbtypetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbtypetitle.Location = new System.Drawing.Point(250, 18);
            this.lbtypetitle.Name = "lbtypetitle";
            this.lbtypetitle.Size = new System.Drawing.Size(35, 13);
            this.lbtypetitle.TabIndex = 25;
            this.lbtypetitle.Text = "Type";
            // 
            // lbdemandtitle
            // 
            this.lbdemandtitle.AutoSize = true;
            this.lbdemandtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbdemandtitle.Location = new System.Drawing.Point(199, 141);
            this.lbdemandtitle.Name = "lbdemandtitle";
            this.lbdemandtitle.Size = new System.Drawing.Size(133, 13);
            this.lbdemandtitle.TabIndex = 26;
            this.lbdemandtitle.Text = "Energy Demand in kW";
            // 
            // txbdmoffpeak
            // 
            this.txbdmoffpeak.Location = new System.Drawing.Point(340, 171);
            this.txbdmoffpeak.Name = "txbdmoffpeak";
            this.txbdmoffpeak.Size = new System.Drawing.Size(185, 20);
            this.txbdmoffpeak.TabIndex = 5;
            // 
            // lbdmoffpeak
            // 
            this.lbdmoffpeak.AutoSize = true;
            this.lbdmoffpeak.Location = new System.Drawing.Point(277, 174);
            this.lbdmoffpeak.Name = "lbdmoffpeak";
            this.lbdmoffpeak.Size = new System.Drawing.Size(55, 13);
            this.lbdmoffpeak.TabIndex = 29;
            this.lbdmoffpeak.Text = "Off Peak: ";
            // 
            // txbdmunit
            // 
            this.txbdmunit.Location = new System.Drawing.Point(77, 170);
            this.txbdmunit.Name = "txbdmunit";
            this.txbdmunit.Size = new System.Drawing.Size(185, 20);
            this.txbdmunit.TabIndex = 4;
            // 
            // lbdmunit
            // 
            this.lbdmunit.AutoSize = true;
            this.lbdmunit.Location = new System.Drawing.Point(13, 173);
            this.lbdmunit.Name = "lbdmunit";
            this.lbdmunit.Size = new System.Drawing.Size(52, 13);
            this.lbdmunit.TabIndex = 27;
            this.lbdmunit.Text = "On Peak:";
            // 
            // txbdmpp
            // 
            this.txbdmpp.Location = new System.Drawing.Point(77, 209);
            this.txbdmpp.Name = "txbdmpp";
            this.txbdmpp.Size = new System.Drawing.Size(185, 20);
            this.txbdmpp.TabIndex = 30;
            // 
            // lbdmpp
            // 
            this.lbdmpp.AutoSize = true;
            this.lbdmpp.Location = new System.Drawing.Point(11, 212);
            this.lbdmpp.Name = "lbdmpp";
            this.lbdmpp.Size = new System.Drawing.Size(70, 13);
            this.lbdmpp.TabIndex = 31;
            this.lbdmpp.Text = "Partial Peak: ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 365);
            this.Controls.Add(this.lbdmpp);
            this.Controls.Add(this.txbdmpp);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Electric Measure";
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
    }
}