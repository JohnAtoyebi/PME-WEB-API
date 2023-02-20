using System;
using System.Net.Mail;
using System.Net;

namespace ConsoleApp1
{
    public class Program
    {
        public static void SendQuickEmail(string fromAddress, string toAddress, string subject,
                string body, string smtpServer, int smtpPort, string smtpUsername, string smtpPassword)
        {
            try
            {
                var message = new MailMessage(fromAddress, toAddress, subject, body);
                using (var client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the email sending process.
                Console.WriteLine("Error sending email: {0}", ex.ToString());
            }
        }
        /*public static void SendQuickMail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, password)
            };

            string subject = "MAIL FROM JOHN";
            string body = $"JOHN SENT THIS MAIL AROUND {DateTime.UtcNow:F}";
            try
            {
                Console.WriteLine("Sending mail **************");
                email.Send(fromAddress, recipients: ToAddress(), subject, body);
            }
            catch (SmtpException ex)
            {

            }
        }*/
        public static string ToAddress()
        {
            return "atoyebijohn1@gmail.com";
        }
        static void Main(string[] args)
        {
            SendQuickEmail("atoyebijohn1@gmail.com", "atoyebijohn1@gmail.com", "Test email", "Hello, world!", "smtp.gmail.com", 587, "atoyebijohn1@gmail.com", "");
            //SendQuickMail("atoyebijohn1@gmail.com", "");
        }
    }
}
