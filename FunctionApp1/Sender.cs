using System.Net.Mail;
using System.Net;

namespace FunctionApp
{
    public class Sender
    {
        private SmtpClient _smtpClient;

        public Sender(string email, string pw)
        {
            _smtpClient = new SmtpClient("asmtp.mail.hostpoint.ch")
            {
                Port = 587,
                Credentials = new NetworkCredential(email, pw),
                EnableSsl = true,
            };
        }


        public bool EmailSender(string htmlBody, string playerEmail)
        {

            var mailMessage = new MailMessage
            {
                From = new MailAddress("alfredtest@sato-code.com"),
                Subject = "Test",
                IsBodyHtml = true,
            };

            mailMessage.Body = htmlBody;
            mailMessage.To.Add(playerEmail);
            _smtpClient.Send(mailMessage);
            return true;
        }
    }
}
