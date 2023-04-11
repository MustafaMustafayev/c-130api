using c135api.DTOs.RoleDtos;

namespace c135api.DTOs.UserDtos
{
    public class UserToAddDto
    {
        public string Name { get; set; }
        public RoleToAddDto Role { get; set; }
    }
}
