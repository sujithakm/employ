using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace email
{
    class emailsend
    {
        public void sendemail(string toAddress, string msg, string subject,string attach)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.UseDefaultCredentials = true;
            mail.From = new MailAddress("sujithveeru1@gmail.com");

            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = msg;
            mail.Attachments.Add(new Attachment(@attach));

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("sujithveeru1@gmail.com", "963392663407");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }

        class program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Email");
                string To = Console.ReadLine();
                Console.WriteLine("Enter Sub");
                string sub = Console.ReadLine();
                Console.WriteLine("Enter msg");
                string msg = Console.ReadLine();
                emailsend ob = new emailsend();
                Console.WriteLine("attachment location");
                string attach = Console.ReadLine();

                ob.sendemail(To, msg, sub,attach);
                Console.WriteLine("Done");
                Console.ReadLine();


            }
        }
    }

