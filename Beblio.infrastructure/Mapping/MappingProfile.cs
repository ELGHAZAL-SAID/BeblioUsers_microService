using AutoMapper;
using Beblio.Domain.Entities;
using Beblio.infrastructure.DTOs.RolesDTO;
using Beblio.infrastructure.DTOs.UsersDTO;

namespace Beblio.infrastructure.Mapping;

internal class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Users, UsersDTO>().ReverseMap();
        CreateMap<Users, AddUsersDTO>().ReverseMap();
        CreateMap<Users, UpdateUsersDTO>().ReverseMap();


        CreateMap<Roles, RolesDTO>().ReverseMap();
        CreateMap<Roles, AddRolesDTO>().ReverseMap();
        CreateMap<Roles, UpdateRolesDTO>().ReverseMap();
    }
}
