using c135api.DAL.Abstract;
using c135api.Entities;

namespace c135api.DAL.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MyContext _ctx;
        public RoleRepository(MyContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(Role role)
        {
            _ctx.Roles.Add(role);
        }
    }
}
