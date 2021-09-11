using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NouApi.Models;
using NouApi.Dtos;

namespace NouApi.Profiles
{
    public class MessagesProfile : Profile
    {
        public MessagesProfile()
        {
            CreateMap<Message, MessageReadDto>();
            CreateMap<MessageCreateDto, Message>();
        }
    }
}
