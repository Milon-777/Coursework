using MySql.Data.MySqlClient;
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

namespace Kursova
{

    public partial class Profile : Form
    {
        private ConnectionDB connectionDb = new ConnectionDB();
        private string loginUser = null;
        private string passwordUser = null;
        private string phoneNumber = null;
        private string mailUser = null;

        public Profile()
        {
            InitializeComponent();
        }
        public Profile(string login, string password, string phone, string mail)
        {
            InitializeComponent();            
            loginUser = login;
            passwordUser = password;
            phoneNumber = phone;
            mailUser = mail;
            loginLabel.Text = loginUser;
            phoneLabel.Text = phoneNumber;
            mailLabel.Text = mailUser;
        }

        private void getUserOrders()
        {
            ConnectionDB database = new ConnectionDB();
            MySqlDataReader reader = null;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `orders` WHERE `loginUser` = @login",database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;

            try
            {
                database.openConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string User = reader["loginUser"].ToString();
                    string carName = reader["carName"].ToString();
                    DateTime dateOrder = Convert.ToDateTime(reader["dateOrder"]);
                    string[] row = { id, User, carName, Convert.ToString(dateOrder) };
                    if ((DateTime.Now - dateOrder).Days >= 7)
                    {
                        history.Rows.Add(row);
                    }
                    else
                    {
                        actual.Rows.Add(row);
                    }
                }
                reader.Close();
                database.closeConnection();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main menu = new Main(loginUser, passwordUser, phoneNumber, mailUser);
            menu.Show();
        }

        private void actualOrders_Paint(object sender, PaintEventArgs e)
        {
            actualOrders.AutoScroll = true;
        }

        private void historyOrders_Paint(object sender, PaintEventArgs e)
        {
            historyOrders.AutoScroll = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedBack feedback = new FeedBack(loginUser,mailUser);
            feedback.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            getUserOrders();
        }

    }
}
