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

    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string user = txbuser.Text;
            string pwd = txbpass.Text;
            if (txbuser.Text.Trim() == "" || txbpass.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbuser.Focus();
            }
            else
            {
                if (user != "admin" || pwd != "admin")
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผิด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbpass.Clear();
                    txbuser.Focus();
                }
                else if (user == "admin" && pwd == "admin")
                {
                    MessageBox.Show($"Welcome {user}!!", "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    this.Hide();
                    menu.FormClosed += (s, args) => this.Close();
                    menu.Show();
                }
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            txbuser.Clear();
            txbpass.Clear();
            txbuser.Focus();
        }

        private void lnregis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.FormClosed += (s, args) => this.Close();
            register.Show();
        }
    }
}
