using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NouApi.Data;
using NouApi.Dtos;
using NouApi.Models;
namespace NouApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly ILogger<MessageController> _logger;
        private readonly IMessageRepo _repository;
        private readonly IMapper _mapper;


        public MessageController(ILogger<MessageController> logger, IMessageRepo repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<Message> GetLatestMessage()
        {
            var message = _repository.GetLatestMessage();

            return Ok(_mapper.Map<MessageReadDto>(message));
        }

        [HttpPost]
        public ActionResult<MessageReadDto> CreateMessage(MessageCreateDto messageCreateDto)
        {
            var messageModel = _mapper.Map<Message>(messageCreateDto);
            _repository.CreateMessage(messageModel);
            _repository.SaveChanges();

            var messageReadDto = _mapper.Map<MessageReadDto>(messageModel);

            return Ok(messageReadDto);
        }
    }
}
