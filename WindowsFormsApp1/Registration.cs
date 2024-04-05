using Diplon;
using Project_Curs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (boxShowPassword.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
                guna2TextBox3.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
                guna2TextBox3.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != guna2TextBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка");
                return;
            }

            PassValidation PassV = new PassValidation();
            if (PassV.Validation(guna2TextBox2.Text) == false)
            {
                return;
            }

            if (guna2TextBox2.Text == guna2TextBox1.Text)
            {
                MessageBox.Show("Пароль и логин не должны совпадать.", "Ошибка");
                return;
            }

            ValidationLogin LV = new ValidationLogin();
            if (LV.Validation(guna2TextBox1.Text) == false)
            {
                return;
            }
            else
            {
                Register(guna2TextBox1.Text, guna2TextBox2.Text);

                Login LF = new Login();
                LF.Show();
                this.Hide();
            }
        }
        private void Register(string login, string password)
        {
            Hashing GH = new Hashing();
            string query = $"Insert into  users (login, password) values('{login}', '{GH.Hash(password)}')";

            var dbquery = new DBquery();
            dbquery.queryExecute(query);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login LF = new Login();
            LF.Show();
            this.Hide();
        }

    }
}
