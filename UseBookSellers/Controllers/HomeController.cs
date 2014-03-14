using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using UseBookSellers.Models;

namespace UseBookSellers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var fromAddress = "johngibbers@yahoo.com";
 
             using (var smtp = new SmtpClient
            {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress, "password")
            })
             {
            using (var message = new MailMessage(fromAddress, fromAddress)
                {
                    Subject = model.Subject,
                    Body = model.Email + " sent you the following message:\n\n" + model.Message
                })
            {
                smtp.Send(message);
            }
        }
        return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
