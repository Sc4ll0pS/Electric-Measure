namespace Electric_Measure
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbFt = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Print_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Electric Measure";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(54, 84);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 18);
            this.lbTotal.TabIndex = 36;
            this.lbTotal.Text = "label2";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase.Location = new System.Drawing.Point(53, 115);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(56, 18);
            this.lbBase.TabIndex = 37;
            this.lbBase.Text = "label2";
            // 
            // lbFt
            // 
            this.lbFt.AutoSize = true;
            this.lbFt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFt.Location = new System.Drawing.Point(54, 144);
            this.lbFt.Name = "lbFt";
            this.lbFt.Size = new System.Drawing.Size(56, 18);
            this.lbFt.TabIndex = 38;
            this.lbFt.Text = "label2";
            // 
            // lbVat
            // 
            this.lbVat.AutoSize = true;
            this.lbVat.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVat.Location = new System.Drawing.Point(54, 174);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(56, 18);
            this.lbVat.TabIndex = 39;
            this.lbVat.Text = "label2";
            // 
            // Print_btn
            // 
            this.Print_btn.Location = new System.Drawing.Point(310, 221);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(75, 23);
            this.Print_btn.TabIndex = 40;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = true;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(430, 274);
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.lbVat);
            this.Controls.Add(this.lbFt);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbFt;
        private System.Windows.Forms.Label lbVat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Print_btn;
    }
}