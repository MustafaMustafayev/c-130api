using c135api.DAL.Abstract;
using c135api.Entities;

namespace c135api.DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _ctx;
        public UserRepository(MyContext ctx)
        {
            _ctx = ctx; 
        }
        public void Add(User user)
        {
            _ctx.User.Add(user);
        }

        public void Delete(User user)
        {
            _ctx.Remove(user);
        }

        public List<User> Get()
        {
            return _ctx.User.ToList();
        }

        public User Get(int id)
        {
            return _ctx.User.Find(id);
        }
    }
}
