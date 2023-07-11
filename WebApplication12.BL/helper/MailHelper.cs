using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication12.BL.helper
{
    public static class MailHelper
    {
       //this class represent service to send mails
            public static async Task sendMailAsync(string Title, string Message,string reciever)
            {
            var email = new MimeMessage()
            {
                Sender = MailboxAddress.Parse("atiffahmykhamis@gmail.com"),
                Subject = "message from College system"


            };
            email.To.Add(MailboxAddress.Parse(reciever));
            var builder = new BodyBuilder();


            builder.HtmlBody = Message;
            email.Body = builder.ToMessageBody();


            email.From.Add(new MailboxAddress("El-Mohamdia Co", "atiffahmykhamis@gmail.com"));



            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);
                smtp.Authenticate("atiffahmykhamis@gmail.com", "carncxaexqpzebqa");
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }
        }
    }

