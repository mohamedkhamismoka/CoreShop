using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication12.BL.helper
{
    public static class MailHelper
    {
       //this class represent service to send mails
            public static string sendMail(string Title, string Message)
            {
                try
                {

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                    smtp.EnableSsl = true;

                    smtp.Credentials = new NetworkCredential("atiffahmykhamis@gmail.com", "01065578456M");


                    smtp.Send("atiffahmykhamis@gmail.com", "mostafaatif609@gmail.com", Title, Message);

                    return "Mail Sent Successfully";

                }
                catch (Exception ex)
                {
                    return "Mail Faild";
                }
            }
        }
    }

