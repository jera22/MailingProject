using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Data;
using Shared;

namespace Service.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Mail, MailDTO>().ReverseMap();
           
        }
    }
}
