using System.Threading.Tasks;

namespace Enzyme.Web.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
