using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace NiceAdmin.Services
{
    public class EmailSender : IEmailService
    {
        private const string SenderEmail = "ritesh.lakhani1507@gmail.com";
        private const string SenderPassword = "Ritesh@15072005";
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;

        public async Task SendEmailAsync(string recipientEmail, string subject, string message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Ritesh", SenderEmail));
            mimeMessage.To.Add(new MailboxAddress("Recipient", recipientEmail));
            mimeMessage.Subject = subject;
            mimeMessage.Body = new TextPart("plain") { Text = message };

            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(SmtpServer, SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(SenderEmail, SenderPassword);
                    await client.SendAsync(mimeMessage);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    // Handle exceptions, such as logging
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
            }
        }
    }
}
