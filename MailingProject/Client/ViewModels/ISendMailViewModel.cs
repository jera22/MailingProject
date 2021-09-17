using Shared;
using System.Threading.Tasks;

namespace MailingProject.Client.ViewModels
{
    public interface ISendMailViewModel
    {
        MailDTO _mailDTO { get; set; }
        public Task SendMail();
    }
}
