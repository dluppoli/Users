using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersAPI.Dtos;
using UsersAPI.Models;

namespace UsersAPI.App_Start
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Login,LoginDto>();
            CreateMap<Login, LoginDto>().ReverseMap();

        }
    }
}