using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NouApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NouApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {

        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Message> GetLatestMessage()
        {
            return Ok(new Message
            {
                Id = 1,
                Body = "Hello team"
            });
        }
    }
}
