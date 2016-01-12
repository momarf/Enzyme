using System.Threading.Tasks;

namespace Enzyme.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
