using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PME.Core.Test_SMTP
{
    public class SendEmail
    {
        /*public static void SendQuickMail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, password)
            };

            string subject = "MAIL FROM JOHN";
            string body = $"this is the mail sent at {DateTime.UtcNow:F}";
            try
            {
                Console.WriteLine("Sending mail **************");
                email.Send(fromAddress, recipients: ToAddress(), subject, body);
            }
            catch (SmtpException ex)
            {

            }
        }
        public static string ToAddress()
        {
            return "";
        }*/

    }
}
