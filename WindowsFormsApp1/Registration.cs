using Diplon;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using Org.BouncyCastle.Asn1.IsisMtt.Ocsp;
using Project_Curs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
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
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9ITJ4U4\SQLEXPRESS;Initial Catalog=Climate;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
            {
                con.Open();
                Hashing GH = new Hashing();
                object objLastUser = new object();
                int userID = 0;

                string addUser = $"INSERT INTO users (login, password) VALUES ('{login}', '{GH.Hash(password)}')";
                SqlDataAdapter sdaUser = new SqlDataAdapter(addUser, con);
                sdaUser.SelectCommand.ExecuteNonQuery();

                string lastUser = "SELECT SCOPE_IDENTITY()";
                SqlCommand com = new SqlCommand(lastUser, con);
                objLastUser = com.ExecuteScalar();

                userID = Convert.ToInt32(objLastUser);
                string addUserInfo = $"INSERT INTO usersInfo (userID) VALUES ('{userID}')";
                SqlDataAdapter sdaInfo = new SqlDataAdapter(addUserInfo, con);
                sdaInfo.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Действие успешно выполнено!", "Успех");
            }
        }
        private void enter_Click(object sender, EventArgs e)
        {
            Login LF = new Login();
            LF.Show();
            this.Hide();
        }
    }
}
