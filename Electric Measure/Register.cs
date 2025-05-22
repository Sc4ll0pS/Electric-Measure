using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Electric_Measure
{
    public partial class Register : Form
    {
        private string dbFile = "users.db";

        public Register()
        {
            InitializeComponent();
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private bool UserExists(string username)
        {
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM users WHERE username=@username";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void AddUser(string username, string hashedPassword)
        {
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string sql = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string username = txtnewuser.Text.Trim();
            string password = txtnewpass.Text;
            string confirmPassword = txtconfirmpassword.Text;

            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnewpass.Clear();
                txtconfirmpassword.Clear();
                txtnewpass.Focus();
                return;
            }

            if (UserExists(username))
            {
                MessageBox.Show("ชื่อผู้ใช้นี้มีในระบบแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnewuser.Focus();
                return;
            }

            string hashedPassword = ComputeSha256Hash(password);
            AddUser(username, hashedPassword);

            MessageBox.Show("สมัครสมาชิกสำเร็จ!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs and optionally redirect to Login form
            txtnewuser.Clear();
            txtnewpass.Clear();
            txtconfirmpassword.Clear();
            txtnewuser.Focus();

            // Example: open Login form and close Register form
            Login login = new Login();
            this.Hide();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void lnregis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}

