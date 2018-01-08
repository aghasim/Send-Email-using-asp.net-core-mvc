using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(MailSend mail)
        {
            EmailService email = new EmailService();
            var subject ="Hello from"+" "+ mail.FirstName + " " + mail.LastName;
            await email.SendEmailAsync(mail.Email, subject, mail.DateOfBird.ToString());
            mail = new MailSend();
            return View();
        }

      
    }
}
