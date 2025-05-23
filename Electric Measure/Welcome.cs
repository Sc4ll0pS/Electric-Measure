using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_Measure
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.FlatAppearance.BorderSize = 2;
            Login_btn.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            Login_btn.ForeColor = Color.Black;
            Login_btn.TabStop = false;

            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.FlatAppearance.BorderSize = 2;
            Register_btn.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            Register_btn.ForeColor = Color.Black;
            Register_btn.TabStop = false;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.FormClosed += (s, args) => this.Close();
            register.Show();
        }
    }
}
