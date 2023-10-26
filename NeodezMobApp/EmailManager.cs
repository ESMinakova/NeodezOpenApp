using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NeodezMobApp
{
    public static class EmailManager
    {
        public static void SendEmail(string subjectText, string bodyText)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.yandex.ru");
                var pass = EmailInfoManager.GetEmailInfo();

                mail.From = new MailAddress("********@yandex.ru");
                mail.To.Add("*********@yandex.ru");
                mail.Subject = subjectText;
                mail.Body = bodyText;

                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.yandex.ru";
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("********@yandex.ru", pass);

                SmtpServer.Send(mail);
            }
            catch 
            {
                new Exception("не удалось отправить письмо");
            }
        }
    }
}
