using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class SignIn : Form
    {
        private string loginUser = null;
        private string passwordUser = null;
        private string phoneNumber = null;
        private string mailUser = null;

        public SignIn()
        {
            InitializeComponent();
        }
        
        private void loginField_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Логін")
            {
                loginField.Clear();
            }
            loginField.ForeColor = Color.Black;
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логін";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passwordField_Click(object sender, EventArgs e)
        {
            if (showPassword.Checked == false)
            {
                passwordField.UseSystemPasswordChar = true;
            }
            if (passwordField.Text == "Пароль")
            {
                passwordField.Clear();
            }
            passwordField.ForeColor = Color.Black;
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.UseSystemPasswordChar = false;
                passwordField.Text = "Пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordField.UseSystemPasswordChar = false;
            }
            else
            {
                passwordField.UseSystemPasswordChar = true;
            }
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void cap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void cap_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;

            if (!isUserExist())
            {
                return;
            }

            getUserInfo(ref loginUser, ref passwordUser, ref phoneNumber, ref mailUser);

            loginField.Text = "Логін";
            loginField.ForeColor = Color.Gray;
            passwordField.Text = "Пароль";
            passwordField.ForeColor = Color.Gray;
            this.Hide();
            Main menu = new Main(loginUser, passwordUser, phoneNumber, mailUser);
            menu.Show();
        }

        public Boolean isUserExist()
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;
            ConnectionDB database = new ConnectionDB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM `users`" +
                "WHERE `login` = @login",
                database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                table.Clear();

                command = new MySqlCommand(
                "SELECT * FROM `users`" +
                "WHERE `login` = @login " +
                "AND `password` = @password",
                database.GetConnection());
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordUser;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Авторизація пройшла успішно!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Невірний пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return false;
                }
            }
            else
            {
                MessageBox.Show("Такого акаунту не існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            loginField.Clear();
            passwordField.Clear();
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void getUserInfo(ref string login, ref string password, ref string phoneNumber, ref string mail)
        {
            ConnectionDB database = new ConnectionDB();
            MySqlDataReader reader = null;

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @login", database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            try
            {
                database.openConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    login = reader["login"].ToString();
                    password = reader["password"].ToString();
                    phoneNumber = reader["phoneNumber"].ToString();
                    mail = reader["mail"].ToString();
                }
                reader.Close();
                database.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
