using Microsoft.AspNetCore.Mvc;
using NiceAdmin.Services;
using System.Threading.Tasks;

namespace NiceAdmin.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var receiver = "mandeepgohil19@gmail.com";
            var subject = "Testing";
            var message = "Hey there i'm mandeep";

            await _emailService.SendEmailAsync(receiver, subject, message);

            return View();
        }
    }
}
