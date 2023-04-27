using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_kfu_2
{
    internal class ClassMailPassword
    {
        public string senderMeial = "komanda_a_2023@mail.ru";
        public string recipientEmail;
        public string text = "";
        public string status = "";
        private string Code = "836852";



        public ClassMailPassword() { }
        public ClassMailPassword(string email)
        {
            this.recipientEmail = email;
        }

        public void MailMessag()
        {

            SmtpClient smtpClient = new SmtpClient("smtp.mail.ru");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = true;
            NetworkCredential networkCredential = new NetworkCredential(senderMeial, "6bnqHkGWy6ShpnrHL5wm");
            smtpClient.Credentials = networkCredential;

            MailAddress from = new MailAddress(senderMeial, "Komand");
            MailAddress to = new MailAddress(recipientEmail, "Komand");
            MailMessage message = new MailMessage(from, to);

            MailAddress replyto = new MailAddress(senderMeial);
            message.ReplyToList.Add(replyto);

            message.Subject = Code;
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            message.Body = $"<b>Провека почты.</b?<br> <b>{Code}</b>.";
            message.BodyEncoding = System.Text.Encoding.UTF8;

            message.IsBodyHtml = true;

            smtpClient.Send(message);
        }
    }
    
}
