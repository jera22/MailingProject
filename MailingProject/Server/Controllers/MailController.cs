using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using Shared;
using System;
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
        public IActionResult GetAllMails()
        {
            try
            {
                return Ok(_mailService.GetMails());
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);

                throw;
            }
            
        }

        [HttpGet("{id}")]
        public IActionResult GetMailById([FromRoute] int id)
        {
            var mail = _mailService.GetMail(Guid.Parse(id.ToString()));
            return Ok(mail);
        }

        [HttpPost]
        public IActionResult CreateNewMail(MailDTO mail) {
            try
            {
                _mailService.InsertMail(mail);
                return Created("",mail);
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
            
        }
    }
}
