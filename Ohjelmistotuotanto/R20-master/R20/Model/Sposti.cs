using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20.Model
{
    internal class Sposti
    {
        private const String lahettaja = "r20sahkoposti@outlook.com"; // joku sposti
        private const String salasana = "Salasana1"; // salasana

        public void Spostilahetys(string vastaanottaja,string aihe,string viesti) // tähän voi lisätä parametreja
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp-mail.outlook.com");
                mail.From = new MailAddress(lahettaja); // lähettäjä
                mail.To.Add(new MailAddress(vastaanottaja)); // vastaanottaja
                mail.Subject = aihe; // aihe
                mail.Body = viesti; // viesti

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential(lahettaja, salasana); // lähettäjä, salasana
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
