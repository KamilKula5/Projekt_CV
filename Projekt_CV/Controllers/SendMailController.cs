using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace Projekt_CV.Controllers
{
	public class SendMailController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ViewResult Index(Projekt_CV.Models.MailModel _objModelMail)
		{
			if (ModelState.IsValid)
			{
				TempData["Success"] = "Wysłano";
				MailMessage mail = new MailMessage();
				mail.To.Add("koncowyprojekt1@gmail.com");   //wyslij na ten mail															
				mail.From = new MailAddress("example@gmail.com");
				mail.Subject = _objModelMail.Subject;
				string Body = _objModelMail.Body;
				mail.Body = Body;
				mail.IsBodyHtml = true;
				SmtpClient smtp = new SmtpClient();
				smtp.Host = "smtp.gmail.com";
				smtp.Port = 587;
				smtp.Credentials = new System.Net.NetworkCredential("koncowyprojekt1@gmail.com", "rlrrkdzqkhpeowuh"); // Enter seders User name and password       
				smtp.EnableSsl = true;
				smtp.UseDefaultCredentials = false;
				smtp.Send(mail);
				ModelState.Clear();
				return View("/Views/Home/Index.cshtml");
			}
			else
			{
				var errors = ModelState.Select(x => x.Value.Errors)
						   .Where(y => y.Count > 0)
						   .ToList();
				Console.WriteLine(errors);
				return View("/Views/Home/Index.cshtml");
			}
		}
	}
}
