using System;
using System.Net;
using System.Net.Mail;
using DnsClient;

namespace GFCA.Infrastructure.Services
{
    public class MailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly MailMessage _mailMessage;
        private readonly string _systemEmail;
        //private readonly string _systemPassword;
        private readonly string _domain;

        /// <summary>
        /// smtp server : webmail.gfca.com
        /// port        : 143
        /// user        : aai_edi
        /// passed      : (Dn81Wi
        /// </summary>
        /// <param name="smtpClient"></param>
        private MailService(SmtpClient smtpClient,string domain)
        {
            //_systemEmail = "aai_edi@gfca.com";
            //_systemPassword = "(Dn81Wi";

            _mailMessage = new MailMessage();
            _smtpClient = smtpClient;
            _domain = domain;
        }

        public static MailService CreateInstance(string server, int port, string user, string password, string domain, string transportTarget = "SMTPSVC")
        {
            string targetName = $"{transportTarget}/{domain}";
            var smtp = new SmtpClient();
            smtp.Host = server;
            smtp.Port = port;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(user, password, domain);
            //smtp.ServicePoint.MaxIdleTime = 1;
            smtp.TargetName = targetName;
            var service = new MailService(smtp, domain);
            //service._systemEmail = user;
            //service._systemPassword = password;
            return service;
            
        }
        public bool SentEmail(string toEmail, string subject, string message)
        {
            return this.SendEmail(string.Empty, toEmail, string.Empty, string.Empty, subject, message);
        }

        public bool SentEmail(string fromEmail, string toEmail, string subject, string message)
        {
            return this.SendEmail(fromEmail, toEmail, string.Empty, string.Empty, subject, message);
        }

        private bool SendEmail(string fromEmail, string toEmail, string ccEmail, string bccEmail, string subject, string message)
        {

            if (string.IsNullOrEmpty(fromEmail))
                fromEmail = _systemEmail;

            var messageEncode = System.Text.Encoding.UTF8;
            _mailMessage.From = new MailAddress(fromEmail);
            _mailMessage.Subject = subject;
            _mailMessage.Body = message;
            _mailMessage.SubjectEncoding = messageEncode;
            _mailMessage.BodyEncoding = messageEncode;
            _mailMessage.IsBodyHtml = true;


            string[] toEmails = toEmail.Split(',');
            foreach (var email in toEmails)
                _mailMessage.To.Add(new MailAddress(email));

            if (!string.IsNullOrEmpty(ccEmail) || (ccEmail.Length > 0))
            {
                string[] ccEmails = ccEmail.Split(',');
                foreach (var email in ccEmails)
                    _mailMessage.CC.Add(new MailAddress(email));
            }

            if (!string.IsNullOrEmpty(bccEmail) || (bccEmail.Length > 0))
            {
                string[] bccEmails = bccEmail.Split(',');
                foreach (var email in bccEmails)
                    _mailMessage.Bcc.Add(new MailAddress(email));
            }

            bool isSuccess = false;
            /*
            LookupClient lookup = new LookupClient();
            IDnsQueryResponse response = lookup.Query(_domain, QueryType.MX);
            foreach (DnsClient.Protocol.MxRecord record in response.Answers)
            {
                try
                {
                    _smtpClient.Host = record.Exchange;
                    _smtpClient.Send(_mailMessage);
                    isSuccess = true;
                    break;
                }
                catch (SmtpFailedRecipientsException exSmtpFail)
                {
                    //receipiants fail
                    //throw exSmtpFail;
                }
                catch (SmtpException exSmtp)
                {
                    //connection fail
                    //throw exSmtp;
                }
            }
            */


            try
            {
                _smtpClient.Send(_mailMessage);
                isSuccess = true;
            }
            catch (SmtpFailedRecipientsException exSmtpFail)
            {
                //receipiants fail
                //throw exSmtpFail;
            }
            catch (SmtpException exSmtp)
            {
                //connection fail
                //throw exSmtp;
            }

            return isSuccess;



        }
    }
}
