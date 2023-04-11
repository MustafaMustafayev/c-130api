using AutoMapper;
using c135api.DTOs.BlokDtos;
using c135api.DTOs.FloorDtos;
using c135api.DTOs.RoleDtos;
using c135api.DTOs.UserDtos;
using c135api.Entities;

namespace c135api.BLL.Mappers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Blok, BlokToListDto>()
                .ForMember(d => d.No, src => src.MapFrom(s => s.Number));

            CreateMap<BlokToAddDto, Blok>();
            CreateMap<BlokToUpdateDto, Blok>();

            CreateMap<FloorToAddDto, Floor>();
            CreateMap<Floor, FloorToListDto>();
            CreateMap<FLoorToAddWithBlokDto, Floor>();

            CreateMap<Role, RoleToListDto>();
            CreateMap<Role, RoleToByIdDto>();
            CreateMap<RoleToAddDto, Role>();
            CreateMap<RoleToUpdateDto, Role>();

            CreateMap<User, UserToListDto>();
            CreateMap<User, UserToByIdDto>();
            CreateMap<UserToAddDto, User>();
            CreateMap<UserToUpdateDto, User>();

            CreateMap<Permission, PermissionToListDto>();
            CreateMap<PermissionToAddDto, Permission>();
        }
    }
}
