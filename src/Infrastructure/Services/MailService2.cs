using System;

using MailKit;
using MimeKit;
using MailKit.Security;
using MailKit.Net.Imap;
using MimeKit.Utils;
using MailKit.Net.Smtp;
using GFCA.Infrastructure.Mails.SmtpValidator;
using System.Net;
using System.Text;

namespace GFCA.Infrastructure.Services
{
    public class MailService2
    {

        private readonly string _server;
        private readonly int _port;
        private readonly string _user;
        private readonly string _password;
        private readonly string _domain;
        public bool IsConnected { get; set; } = false;
        public MailService2(string server, int port, string user, string password, string domain = "")
        {
            _server = server;
            _port = port;
            _user = user;
            _password = password;
            _domain = domain;
        }


        private MimeMessage GetMessage()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("System APT", "aai_edi@gfca.com"));
            message.To.Add(new MailboxAddress("Panupong.K", "x.fronzen@gmail.com"));
            message.Subject = "Subject Test";
            message.Body = new TextPart("plain")
            {
                Text = @"Hi There,
    Best Regards
GFCA Group
"
            };

            return message;
        }

        public bool SmtpSent()
        {

            bool sent = false;
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Connect(_server, _port, SecureSocketOptions.None);
                var ntlm = new SaslMechanismNtlm(_user, _password);
                smtp.Authenticate(ntlm);
                //ICredentials credentials = new NetworkCredential(_user, _password, _domain);
                //smtp.Authenticate(credentials);
                IsConnected = true;
                var message = GetMessage();
                smtp.Send(message);
                sent = true;
                smtp.Disconnect(true);
            }

            return sent;
            
        }

        public bool ImapSent()
        {
            bool sent = false;
            using (ImapClient imap = new ImapClient())
            {
                imap.Connect(_server, _port, SecureSocketOptions.Auto);
                imap.Authenticate(_user, _password);
                IsConnected = true;

                imap.Disconnect(true);
            }
            return sent;
        }

        public static bool ValidateCredentials(string login, string password, string server, int port, bool enableSsl)
        {
            SmtpConnectorBase connector;
            if (enableSsl)
            {
                connector = new SmtpConnectorWithSsl(server, port);
            }
            else
            {
                connector = new SmtpConnectorWithoutSsl(server, port);
            }

            if (!connector.CheckResponse(220))
            {
                return false;
            }

            connector.SendData($"HELO {Dns.GetHostName()}{SmtpConnectorBase.EOF}");
            if (!connector.CheckResponse(250))
            {
                return false;
            }

            connector.SendData($"AUTH LOGIN{SmtpConnectorBase.EOF}");
            if (!connector.CheckResponse(334))
            {
                return false;
            }

            connector.SendData(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}")) + SmtpConnectorBase.EOF);
            if (!connector.CheckResponse(334))
            {
                return false;
            }

            connector.SendData(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{password}")) + SmtpConnectorBase.EOF);
            if (!connector.CheckResponse(235))
            {
                return false;
            }

            return true;
        }
    }
}
