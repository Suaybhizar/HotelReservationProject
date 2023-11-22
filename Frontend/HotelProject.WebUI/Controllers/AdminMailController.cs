using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
          
            //kimden gönderilecek mail
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "coders5858@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //kime gönderilecek
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);


            //mesaj içeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("coders5858@gmail.com", "dzwvpbcdievicave");
            client.Send(mimeMessage);
            client.Disconnect(true);

            //Gönderilen Mailin Veri Tabanına Kaydedilmesi.


            return View();
        }
    }
}
