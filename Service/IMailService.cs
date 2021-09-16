using Shared;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface IMailService
    {
        IEnumerable<MailDTO> GetMails();
        MailDTO GetMail(Guid id);
        void InsertMail(MailDTO mail);
        void UpdateMail(MailDTO mail);
        void DeleteMail(Guid id);
    }
}
