using Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MailingProject.Client.ViewModels
{
    public class MailHistoryViewModel : IMailHistoryViewModel
    {
        private HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public MailHistoryViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public IEnumerable<MailDTO> mailCollection { get; set; } = new List<MailDTO>();

        public async Task getAllMails()
        {
            mailCollection = await _httpClient.GetFromJsonAsync<IEnumerable<MailDTO>>("/mail");
        }
    }
}
