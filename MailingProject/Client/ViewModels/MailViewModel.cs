using Microsoft.AspNetCore.Components;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MailingProject.Client.ViewModels
{
    public class MailViewModel : IMailViewModel
    {
        private HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public MailViewModel(HttpClient httpClient)
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
