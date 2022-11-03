using AutoMapper;
using Sales.Api.Business.Dto;
using Sales.Api.Domain.Entity;

namespace Sales.Api.Business.Mapper;

public class UserMap : Profile
{
    public UserMap()
    {

        CreateMap<User, User>();

        CreateMap<UserRegisterDto, User>()
            .ForMember(destination => destination.CreateDate, source => source.MapFrom(i => DateTime.Now))
            .ForMember(destination => destination.IsDeleted, source => source.MapFrom(i => false));

    }
}