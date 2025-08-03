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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            UserLoginField.Text = "Введите имя";
            UserPasswordField.Text = "Введите пароль";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.White;
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
                UserPasswordField.ForeColor = Color.White;
            }
        }

        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Введите имя";
                UserLoginField.ForeColor = Color.PowderBlue;
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.PowderBlue;
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "Введите имя" || UserLoginField.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните имя!");
                return;
            }

            if (UserPasswordField.Text.Trim() == "Введите пароль" || UserPasswordField.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните пароль!");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("" +
                "SELECT COUNT(id) FROM users WHERE login = @login AND password = @password",
                db.GetConnection()
                );
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));

            db.OpenConnection();

            int countUser = Convert.ToInt32(command.ExecuteScalar());
            if (countUser > 0) 
            {
                this.Hide();
                PingPong pingPong = new PingPong();
                pingPong.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Пользователь не найден");

            db.CloseConnection();
        }

        private string Hash(string input)// Method to hash the input string using SHA1
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);// Convert the input string to a byte array
            using (SHA1Managed sha1 = new SHA1Managed())// Create a new instance of SHA1Managed
            {
                var hash = sha1.ComputeHash(temp);// Compute the hash
                return Convert.ToBase64String(hash);// Convert byte array to Base64 string
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;// Set the focus to the label when the form loads
        }

        private void LinkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current form
            RegisterForm registerForm = new RegisterForm(); // Create a new instance of the RegisterForm
            registerForm.ShowDialog(); // Show the RegisterForm as a dialog
            this.Close(); // Close the current form after the RegisterForm is closed
        }
    }
}
