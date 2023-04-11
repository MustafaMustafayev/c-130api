using c135api.DTOs.RoleDtos;

namespace c135api.DTOs.UserDtos
{
    public class UserToByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleToByIdDto? Role { get; set; }
    }
}
