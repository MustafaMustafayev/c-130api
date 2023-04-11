using c135api.DTOs.UserDtos;

namespace c135api.BLL.Abstract
{
    public interface IUserService
    {
        void Add(UserToAddDto dto);
        void Delete(int id);
        List<UserToListDto> Get();
    }
}
