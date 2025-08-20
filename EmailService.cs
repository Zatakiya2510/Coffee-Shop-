using System.Threading.Tasks;

namespace NiceAdmin.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
