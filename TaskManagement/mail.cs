using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace TaskManagement
{
    class mail
    {
        internal bool SentMail(string toMail, string subject, string message)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("alfav2blackgroup@gmail.com");
            ePosta.To.Add(toMail);
            ePosta.Subject = subject;
            ePosta.Body = message;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("alfav2blackgroup@gmail.com", "Fx8Tc6E8");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool control = true;
            try
            {
                smtp.Send(ePosta);
            }
            catch (SmtpException ex)
            {
                control = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return control;
        }
    }
}
