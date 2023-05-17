using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Work.BL.Models;

namespace Work.BL.Helper
{
    public class MailSender
    {
        public static string SendMail(MailVM model)
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("mahmoudmagdykamel333@gmail.com", "oxdwhkmejbwffkls"),
                    EnableSsl = true
                };
                client.Send("mahmoudmagdykamel333@gmail.com", model.Mail, model.Title, model.Message);
                var result = "Mail Sent Successfully";
                return result;
            }
            catch (Exception ex)
            {
                var result = "Failed To Send Mail";
                return result;

            }
        }
    }
}
