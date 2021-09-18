using AutoMapper;
using Data;
using Repository;
using Shared;
using System;
using System.Collections.Generic;

namespace Service
{
    public class MailService : IMailService
    {
        private IRepository<Mail> _mailRepository;
        private IMapper _map;

        public MailService(IRepository<Mail> mailRepository, IMapper mapper)
        {
            _mailRepository = mailRepository;
            _map = mapper;
        }

        public MailDTO GetMail(Guid id)
        {
            var mail = _mailRepository.Get(id);
            return _map.Map<MailDTO>(mail);
        }

        public IEnumerable<MailDTO> GetMails()
        {
            var _mails = _mailRepository.GetAll();

            return _map.Map<IEnumerable<MailDTO>>(_mails);
        }

        public void InsertMail(MailDTO _mailDTO)
        {
            var mail = _map.Map<Mail>(_mailDTO);
            mail.CreatedOn= DateTime.Now.ToUniversalTime();
            mail.ModifiedOn= DateTime.Now.ToUniversalTime();
            _mailRepository.Insert(mail);
        }

        public void UpdateMail(MailDTO _mailDTO)
        {
            var mail = _map.Map<Mail>(_mailDTO);
            mail.ModifiedOn = DateTime.Now.ToUniversalTime();
            _mailRepository.Update(mail);
        }
        public void DeleteMail(Guid id)
        {
            var mail = new Mail() { Id = id };
                       
            _mailRepository.Delete(_map.Map<Mail>(mail));
        }

    }
}
