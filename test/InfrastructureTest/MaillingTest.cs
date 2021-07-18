using System;
using Xunit;

namespace GFCA.Infrastructure.Test
{
    using System.IO;
    using System.Net.Security;
    using System.Net.Sockets;
    using GFCA.Infrastructure.Services;
    public class MaillingTest
    {

        //protected const string host = "webmail.gfca.com"; //210.4.143.163
        protected const string host = "210.4.143.163";
        protected const int port = 25;
        protected const string user = "automail_aai@asiatic.co.th";
        protected const string passwd = "(Dn81Wi";
        protected const string domain = "gfca.com";

        public class Connection
        {
            /*
            [Fact]
            public void TcpTest()
            {
                using (var client = new TcpClient())
                {
                    client.Connect(host, port);
                    // As GMail requires SSL we should use SslStream
                    // If your SMTP server doesn't support SSL you can
                    // work directly with the underlying stream
                    using (var stream = client.GetStream())
                    using (var sslStream = new SslStream(stream))
                    {
                        sslStream.AuthenticateAsClient(host);
                        using (var writer = new StreamWriter(sslStream))
                        using (var reader = new StreamReader(sslStream))
                        {
                            writer.WriteLine("EHLO " + host);
                            writer.Flush();
                            Console.WriteLine(reader.ReadLine());
                            // GMail responds with: 220 mx.google.com ESMTP
                        }
                    }
                }
            }
            */
            
            [Fact]
            public void SmtpSvcTest()
            {
                
                MailService context = MailService.CreateInstance(host, port, user, passwd, domain);

                string toEmail = "panupong.k@itsmart.co.th";
                toEmail = "x.fronzen@gmail.com";
                string subject = "test : mail from cocomax";
                string body = "body";
                bool expected = true;
                bool actual = context.SentEmail(
                    fromEmail: user,
                    toEmail: toEmail,
                    subject: subject,
                    message : body);

                Assert.Equal(expected, actual);
            }
            

            /*
            [Fact]
            public void SmtpValidateTest()
            {
                var newPasswd = string.Empty;
                bool isCredential = MailService2.ValidateCredentials(user, newPasswd, host, port, false);
                bool expected = true;

                Assert.Equal(expected, isCredential);
            }
            */

            /*
            [Fact]
            public void SmtpSvcTest()
            {

                MailService2 context = new MailService2(host, port, user, passwd, domain);

                bool expected = true;
                bool actual = context.SmtpSent();

                Assert.Equal(expected, actual);
            }
            */

        }
    }
}
