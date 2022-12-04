using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace WebLogin1.Models
{
    public class MailSender
    {
        public async Task<bool> sendMail(string toEmailAddress, string subject, string htmlMessage)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("Proyecto_Final_01@hotmail.com");
            mail.To.Add(toEmailAddress);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = htmlMessage;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Proyecto_Final_01@hotmail.com", "ProyectoFinal_1");
            SmtpServer.EnableSsl = true;

            try
            {
                await Task.Run(() => SmtpServer.Send(mail));
                return true;
            }
            catch (Exception) {return false;}
        }
    }
}