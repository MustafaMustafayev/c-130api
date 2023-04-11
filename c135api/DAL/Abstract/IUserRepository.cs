using c135api.Entities;

namespace c135api.DAL.Abstract
{
    public interface IUserRepository
    {
        void Add(User user);
        void Delete(User user);
        List<User> Get();
        User Get(int id);
    }
}
