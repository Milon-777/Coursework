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
    public partial class Main : Form
    {
        private string loginUser = null;
        private string passwordUser = null;
        private string phoneNumber = null;
        private string mailUser = null;
        public Main()
        {
            InitializeComponent();
        }

        public Main(string login, string password, string phoneNumber, string mail)
        {
            InitializeComponent();
            this.loginUser = login;
            this.passwordUser = password;
            this.phoneNumber = phoneNumber;
            this.mailUser = mail;
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profileUser = new Profile(loginUser, passwordUser, phoneNumber, mailUser);
            profileUser.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assortmentButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Assortment assortment = new Assortment(loginUser, passwordUser, phoneNumber, mailUser);
            assortment.Show();
        }

        private void feedBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FeedBack feedback = new FeedBack(loginUser, mailUser);
            feedback.Show();
        }
    }
}
