using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class FeedBack : Form
    {
        private string loginUser = null;
        private string mailUser = null;
        public FeedBack()
        {
            InitializeComponent();
        }

        public FeedBack(string login, string mail)
        {
            InitializeComponent();
            loginUser = login;
            mailUser = mail;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
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

        private void sendMessage_Click(object sender, EventArgs e)
        {
            try
            { 
                using (MailMessage mm = new MailMessage("Новий тікет" + "<" + mailUser + ">", "helpCenter@gmail.com"))
                {
                    mm.Subject = theme.Text;
                    mm.Body = bodyMessage.Text;
                    using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                    {
                        sc.EnableSsl = true;
                        sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                        sc.UseDefaultCredentials = false;
                        sc.Timeout = 30000;
                        sc.Credentials = new NetworkCredential("@mailUser", "@passwordMailUser");
                        sc.Send(mm);
                    }
                }
                MessageBox.Show("Ваше повідомлення було відправлено успішно!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.OpenForms[1].Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
