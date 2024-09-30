using System.Net;
using System.Net.Mail;

namespace ReservaGimnasio.Services
{
    public static class NotificacionService
    {
        public static void EnviarCorreo(string correoDestino, string asunto, string cuerpo)
        {
            MailMessage mail = new MailMessage("tuemail@gimnasio.com", correoDestino);
            mail.Subject = asunto;
            mail.Body = cuerpo;

            SmtpClient client = new SmtpClient("smtp.tuservidor.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential("tuemail@gimnasio.com", "tucontraseña");
            client.EnableSsl = true;

            client.Send(mail);
        }
    }
}
