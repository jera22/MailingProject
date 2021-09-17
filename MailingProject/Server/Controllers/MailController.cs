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
                return BadRequest();
                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetMailById([FromRoute] int id)
        {
            try
            {
                var mail = _mailService.GetMail(Guid.Parse(id.ToString()));
                return Ok(mail);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return BadRequest();
                throw;
            }
        }

        [HttpPost]
        public IActionResult CreateNewMail(MailDTO mail)
        {
            try
            {
                _mailService.InsertMail(mail);
                return Created("", mail);
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                return BadRequest();
                throw;
            }

        }

        [HttpPut]
        public IActionResult UpdateMail(MailDTO mail)
        {
            try
            {
                _mailService.UpdateMail(mail);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return BadRequest();
                throw;
            }
        }

        [HttpDelete]
        public IActionResult DeleteMail(Guid id)
        {
            try
            {
                _mailService.DeleteMail(id);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return BadRequest();
                throw;
            }

        }
    }
}
