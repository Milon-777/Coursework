using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(out string loginUser, out string passwordUser, out string phoneNumber, out string mailUser)
        {
            InitializeComponent();
            if (registratingButton.Focused)
            {
                loginUser = loginField.Text;
                passwordUser = passwordField.Text;
                phoneNumber = phoneField.Text;
                mailUser = mailField.Text;
            }
            else
            {
                loginUser = null;
                passwordUser = null;
                phoneNumber = null;
                mailUser = null;
            }
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

        private void mailField_Click(object sender, EventArgs e)
        {
            if (mailField.Text == "Пошта")
            {
                mailField.Clear();
            }
            mailField.ForeColor = Color.Black;
        }

        private void mailField_Leave(object sender, EventArgs e)
        {
            if (mailField.Text == "")
            {
                mailField.Text = "Пошта";
                mailField.ForeColor = Color.Gray;
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

        private void phoneField_Click(object sender, EventArgs e)
        {
            if (phoneField.Text == "Номер")
            {
                phoneField.Clear();
            }
            phoneField.ForeColor = Color.Black;
        }

        private void phoneField_Leave(object sender, EventArgs e)
        {
            if (phoneField.Text == "")
            {
                phoneField.Text = "Номер";
                phoneField.ForeColor = Color.Gray;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        Point lastPoint;
        private void cap_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void cap_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;
            string phoneNumber = phoneField.Text;
            string mailUser = mailField.Text;
            if (loginUser == "Логін")
            {
                MessageBox.Show("Введіть будь ласка логін.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (passwordUser == "Пароль")
            {
                MessageBox.Show("Введіть будь ласка пароль.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (phoneNumber == "Номер")
            {
                MessageBox.Show("Введіть будь ласка номер телефону.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mailUser == "Пошта")
            {
                MessageBox.Show("Введіть будь ласка пошту.", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (isLoginExist())
            {
                return;
            }

            ConnectionDB database = new ConnectionDB();

            MySqlCommand command = new MySqlCommand("" +
                "INSERT INTO `users`(`login`, `password`, `phoneNumber`, `mail`) " +
                "VALUES (@login, @password, @phone, @mail)",
                database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordUser;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneNumber;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mailUser;

            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт було успішно створено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Profile account_profile = new Profile(loginUser, passwordUser, phoneNumber, mailUser);
                account_profile.Show();
            }
            else
            {
                MessageBox.Show("Акаунт не вдалося створити!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            database.closeConnection();
        }

        private void loginField_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if(!validLogin(loginField.Text, out errorMessage))
            {
                loginField.Select(0, loginField.TextLength);
                MessageBox.Show(errorMessage,"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validLogin(string loginUser, out string errorMessage)
        {
            if (loginUser.Length <= 3)
            {
                errorMessage = "Логін повинен складатися мінімум з 4 символів.";
                return false;
            }
            if(loginUser == "Логін" || loginUser == "")
            {
                errorMessage = "Введіть будь ласка логін.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private void mailField_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if(!validMail(mailField.Text, out errorMessage))
            {
                mailField.Select(0, mailField.TextLength);
                MessageBox.Show(errorMessage, "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validMail(string mailUser, out string errorMessage)
        {
            var foo = new EmailAddressAttribute();
            bool result = foo.IsValid(mailUser);
            if(mailUser == "Пошта" || mailUser == "")
            {
                errorMessage = "Введіть будь ласка пошту";
                return result;
            }
            if (!result)
            {
                errorMessage = "Некоректна пошта";
                return result;
            }
            else            
            { 
                errorMessage = "";
                return result;
            }                
        }

        private void passwordField_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!validPassword(passwordField.Text, out errorMessage))
            {
                passwordField.Select(0, passwordField.TextLength);
                MessageBox.Show(errorMessage, "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validPassword(string passwordUser, out string errorMessage)
        {
            if (passwordUser.Length <= 3)
            {
                errorMessage = "Пароль повинен складатися мінімум з 4 символів.";
                return false;
            }
            if (passwordUser == "Пароль" || passwordUser == "")
            {
                errorMessage = "Введіть будь ласка пароль.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private void phoneField_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!validPhone(phoneField.Text, out errorMessage))
            {
                phoneField.Select(0, phoneField.TextLength);
                MessageBox.Show(errorMessage, "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validPhone(string phoneNumber, out string errorMessage)
        {
            if (phoneNumber.Length != 10 || !isNumber(phoneNumber))
            {
                errorMessage = "Номер телефону повинен складатися з 10 цифр.";
                return false;
            }
            if (phoneNumber == "Номер" || phoneNumber == "")
            {
                errorMessage = "Введіть будь ласка пароль.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }
       
        public static Boolean isNumber(String test)
        {
            char[] chars = test.ToCharArray();
            foreach (char c in chars)
            {
                int charCode = (int)c;
                if (charCode < 48 || charCode > 57)
                    return false;
            }
            return true;
        }

        public Boolean isLoginExist()       
        {
            string loginUser = loginField.Text;
            ConnectionDB database = new ConnectionDB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM `profiles`" +
                "WHERE `login` = @login",
                database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Акаунт з таким логіном вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
                
    }
}
