using AutoMapper.API.Model.DbSet;
using AutoMapper.API.Model.Dtos.Requests;
using AutoMapper.API.Model.Dtos.Responses;

namespace AutoMapper.API.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, GetUserResponse>()
            .ForMember(dest => dest.FullName,
                src =>
                    src.MapFrom(x => x.FirstName + " " + x.LastName))
            .ForMember(dest => dest.Email,
                src =>
                    src.MapFrom(x => $"Email: {x.Email}"))
            .ForMember(dest => dest.Address,
                src =>
                    src.MapFrom(x => $"Address: {x.StreetAddress}, {x.PostCode}"));

        CreateMap<CreateUserRequest, User>()
            .ForMember(dest => dest.Id,
                src =>
                    src.MapFrom(x => Guid.NewGuid()))
            .ForMember(dest => dest.Status,
                src =>
                    src.MapFrom(x => 1))
            .ForMember(dest => dest.CreateAt,
                src =>
                    src.MapFrom(x => DateTime.Now));
    }
}