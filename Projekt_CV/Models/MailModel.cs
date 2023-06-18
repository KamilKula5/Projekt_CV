using System.ComponentModel.DataAnnotations;

namespace Projekt_CV.Models
{
	public class MailModel
	{
		//public string From { get; set; }
		//public string To { get; set; }
		[Required(ErrorMessage = "Musisz podać temat wiadomości")]
		public string Subject { get; set; }
		[Required(ErrorMessage = "Musisz podać treść wiadomości")]
		public string Body { get; set; }

	}
}
