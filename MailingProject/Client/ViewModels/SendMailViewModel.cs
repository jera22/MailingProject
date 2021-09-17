using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task SendMail()
        {
            try
            {
                await _httpClient.PostAsJsonAsync("/ mail", _mailDTO);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
