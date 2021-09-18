using Shared;
using System;
using System.Net.Http;
using System.Net.Http.Json;

using System.Threading.Tasks;

namespace MailingProject.Client.ViewModels
{
    public class SendMailViewModel : ISendMailViewModel
    {
        public MailDTO _mailDTO { get; set; } = new MailDTO();

        private HttpClient _httpClient;

        public SendMailViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> SendMail()
        {
            try
            {
              var result = await _httpClient.PostAsJsonAsync("/mail", _mailDTO);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void CheckFields()
        {
            throw new NotImplementedException();
        }
    }
}
