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
using MySql.Data.MySqlClient;

namespace App
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserLoginField.Text = "Введите имя";
            UserEmailField.Text = "Введите email";
            UserPasswordField.Text = "Введите пароль";
            this.Text= "Регистрация";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if(((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.White;
            }
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите email")
            {
                UserEmailField.Text = "";
                UserEmailField.ForeColor = Color.White;
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
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите email";
                UserEmailField.ForeColor = Color.PowderBlue;
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.PowderBlue;
            }
        }

        private void RecButton_Click(object sender, EventArgs e)
        {
            if(UserLoginField.Text.Trim() == "Введите имя" || UserLoginField.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните имя!");
                return;
            }

            if (UserEmailField.Text.Trim() == "Введите email" || UserEmailField.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните email!");
                return;
            }

            if (UserPasswordField.Text.Trim() == "Введите пароль" || UserPasswordField.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста, заполните пароль!");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("" +
                "INSERT INTO users (login, password, email) VALUES(@login, @password, @email)",
                db.GetConnection()
                );
            command.Parameters.AddWithValue("login", UserLoginField.Text); 
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text)); 
            command.Parameters.AddWithValue("email", UserEmailField.Text);

            db.OpenConnection();

            try// Attempt to execute the command
            {
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Вы успешно зарегистрированы!"); // If the command affects one row, registration is successful
                else MessageBox.Show("Ошибка регистрации!");
            } catch (MySqlException ex)// Catch any MySQL exceptions that occur during execution
            {
                if(ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("Пользователь с таким именем или email уже существует!");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при регистрации: " + ex.Message);// Display the error message
                }
            }

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
        private void RegisterForm_Load(object sender, EventArgs e)// Event handler for form load
        {
            this.ActiveControl = label1;// Set the focus to the label when the form loads
        }

        private void LinkToAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current form
            AuthForm authForm = new AuthForm(); // Create a new instance of AuthForm    
            authForm.ShowDialog(); // Show the AuthForm as a dialog
            this.Close(); // Close the RegisterForm after the AuthForm is closed
        }
    }
    
}
