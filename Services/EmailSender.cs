using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AdvancedDevelopment.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly String _sendGridUser;
        private readonly String _sendGridKey;

        public EmailSender(IConfiguration configuration)
        {
            KeyGrabber keyGrabber = new KeyGrabber(configuration);

            _sendGridKey = keyGrabber.GetKey("SendGridKey");
            _sendGridUser = keyGrabber.GetKey("SendGridUser");
        }

        //public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        //{
        //    Options = optionsAccessor.Value;
        //}

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(_sendGridKey, subject, message, email);
        }

        public Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("jack@contoso.com", "Wessex Applications"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
}
