﻿using Microsoft.AspNetCore.Mvc;
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
			Console.WriteLine("wysssss");
			if (ModelState.IsValid)
			{
				Console.WriteLine("wyslano");
				MailMessage mail = new MailMessage();
				mail.To.Add("koncowyprojekt1@gmail.com");   //wyslij na ten mail
															//mail.From = new MailAddress(_objModelMail.From);
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
				return View("/Views/Home/Index.cshtml", _objModelMail);
			}
			else
			{
				var errors = ModelState.Select(x => x.Value.Errors)
						   .Where(y => y.Count > 0)
						   .ToList();
				Console.WriteLine(errors);
				Console.WriteLine("nie udalo sie");
				return View("/Views/Home/Index.cshtml");
			}
		}
	}
}
