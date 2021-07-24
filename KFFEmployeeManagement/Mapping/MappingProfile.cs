using AutoMapper;
using KFFEmployeeManagement.Domain.DTO;
using KFFEmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFFEmployeeManagement.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, User>()
                 .ForMember(dest => dest.PasswordHash, source => source.MapFrom(source => source.Password)); //Map from User Object to UserDTO Object
            CreateMap<RoleDTO, Role>();
            //.ReverseMap();
        }
    }
}
