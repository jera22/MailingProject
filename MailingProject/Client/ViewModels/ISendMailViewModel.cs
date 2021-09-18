using Shared;
using System.Net.Http;
using System.Threading.Tasks;

namespace MailingProject.Client.ViewModels
{
    public interface ISendMailViewModel
    {
        MailDTO _mailDTO { get; set; }
        public Task<HttpResponseMessage> SendMail();
        public void CheckFields();

    }
}
