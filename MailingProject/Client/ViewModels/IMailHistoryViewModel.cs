using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailingProject.Client.ViewModels
{
    public interface IMailHistoryViewModel
    {
        public IEnumerable<MailDTO> mailCollection { get; set; }
        public Task getAllMails();

    }
}
