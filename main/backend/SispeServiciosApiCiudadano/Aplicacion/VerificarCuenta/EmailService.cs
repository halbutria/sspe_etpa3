using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta
{
    public interface IEmailService
    {
        void Send(string to, string subject, string html, string from = null);
    }

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        

        public void Send(string to, string subject, string html, string from = null)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from ?? _configuration["EmailConfig:EmailFrom"]));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(_configuration["EmailConfig:SmtpHost"],int.Parse(_configuration["EmailConfig:SmtpPort"]), SecureSocketOptions.StartTls);
            smtp.Authenticate(_configuration["EmailConfig:SmtpUser"], _configuration["EmailConfig:SmtpPass"]);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
