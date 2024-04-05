using Diplon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (boxShowPassword.Checked)
                passwordTextBoxA.UseSystemPasswordChar = false;
            else
                passwordTextBoxA.UseSystemPasswordChar = true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var login = loginTextBoxA.Text;
            var password = passwordTextBoxA.Text;
            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (AuthorizeUser(login, password))
            {
                Climate mainForm = new Climate();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка");
            }
        }
        private bool AuthorizeUser(string login, string password)
        {
            bool isAuthorized = false;

            var dbQeury = new DBquery();
            var getHash = new Hashing();

            using (SqlConnection con = new SqlConnection(dbQeury.StringCon()))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand($"SELECT * FROM users WHERE login ='{login}' and password = '{getHash.Hash(password)}'", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["password"].ToString() == getHash.Hash(password) && reader["login"].ToString() == login)
                            {
                                isAuthorized = true;
                                MessageBox.Show("Вход успешно выполнен!", "Успех");
                            }
                        }
                    }
                }
            }
            return isAuthorized;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Registration Reg = new Registration();
            Reg.Show();
            this.Hide();
        }

    }
}
