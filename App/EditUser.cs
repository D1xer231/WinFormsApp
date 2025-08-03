using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            EmailEdit.Text = "Введите email";
            PasswordEdit.Text = "Введите пароль";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "EmailEdit" && EmailEdit.Text.Trim() == "Введите email")
            {
                EmailEdit.Text = "";
                EmailEdit.ForeColor = Color.White;
            }
            if (((TextBox)sender).Name == "PasswordEdit" && PasswordEdit.Text.Trim() == "Введите пароль")
            {
                PasswordEdit.Text = "";
                PasswordEdit.UseSystemPasswordChar = true;
                PasswordEdit.ForeColor = Color.White;
            }
        }

        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "EmailEdit" && EmailEdit.Text.Trim() == "")
            {
                EmailEdit.Text = "Введите email";
                EmailEdit.ForeColor = Color.PowderBlue;
            }
            if (((TextBox)sender).Name == "PasswordEdit" && PasswordEdit.Text.Trim() == "")
            {
                PasswordEdit.Text = "Введите пароль";
                PasswordEdit.UseSystemPasswordChar = false;
                PasswordEdit.ForeColor = Color.PowderBlue;
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (EmailEdit.Text.Trim() == "Введите email" || EmailEdit.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните email!");
                return;
            }

            if (PasswordEdit.Text.Trim() == "Введите пароль" || PasswordEdit.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните пароль!");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("" +
                "UPDATE users SET password = @password, email = @email WHERE login = 'Admin';",
                db.GetConnection()
                );
            command.Parameters.AddWithValue("password", Hash(PasswordEdit.Text));
            command.Parameters.AddWithValue("email", EmailEdit.Text);

            db.OpenConnection();

            UpdateData.Text = "Готово";
            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Данные изменены");
            db.CloseConnection();
        }

        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

    }
}
