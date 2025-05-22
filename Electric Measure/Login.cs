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

    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text.Trim();
            string pwd = txtpass.Text;

            if (user == "" || pwd == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Focus();
                return;
            }

            if (!UserExists(user))
            {
                MessageBox.Show("ชื่อผู้ใช้ไม่พบในระบบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Focus();
                return;
            }

            string hashedInputPwd = ComputeSha256Hash(pwd);
            string storedHashedPwd = GetHashedPassword(user);

            if (storedHashedPwd == hashedInputPwd)
            {
                MessageBox.Show($"Welcome {user}!!", "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                this.Hide();
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Clear();
                txtpass.Focus();
            }
        }


        private void Reset_btn_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
        }

        private void lnregis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.FormClosed += (s, args) => this.Close();
            register.Show();
        }

        private string dbFile = "users.db";

        // Initialize the database and table (call this in the constructor)
        private void InitializeDatabase()
        {
            if (!System.IO.File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS users (
                        username TEXT PRIMARY KEY,
                        password TEXT NOT NULL
                      );";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
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

        private string GetHashedPassword(string username)
        {
            using (var conn = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conn.Open();
                string sql = "SELECT password FROM users WHERE username=@username";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

    }
}
