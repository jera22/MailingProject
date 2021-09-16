using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Shared;
using System.Collections.Generic;

namespace MailingProject.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {

        private readonly ILogger<MailController> logger;
        private IMailService _mailService;

        public MailController(ILogger<MailController> logger, IMailService mailService)
        {
            this.logger = logger;
            _mailService = mailService;
        }

        [HttpGet]
        public IEnumerable<MailDTO> Get()
        {
            return _mailService.GetMails();
        }
    }
}
