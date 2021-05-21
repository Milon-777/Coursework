using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Kursova
{
    class SendMessage
    {
        private string bodyMail;
        private string loginUser;
        private string theme ="";
        private const string passwordMail = "Z49x57c13v68b20";
        

        public SendMessage(string bodyMail, string loginUser, string theme)
        {
            this.bodyMail = bodyMail;
            this.loginUser = loginUser;
            this.theme = theme;
        }

        public void MySendMail()
        {
            MailAddress from = new MailAddress("userMail@gmail.com", loginUser); 
            MailAddress to = new MailAddress("helpCenter@gmail.com", "Рома");     
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("userMail@gmail.com", passwordMail);
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = theme;
                mail.Body = bodyMail;

                smtp.Send(mail);

                MessageBox.Show("Повідомлення успішно відправлено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка відправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
    }
}
