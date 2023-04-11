using c135api.DAL.Abstract;
using c135api.DAL.UnitOfWork.Abstract;

namespace c135api.DAL.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }

        public IRoleRepository RoleRepository { get; set; }
        private readonly MyContext _ctx;

        public UnitOfWork(IUserRepository userRepository, IRoleRepository roleRepository, MyContext myContext)
        {
            UserRepository = userRepository;
            RoleRepository = roleRepository;    
            _ctx = myContext;
        }

        public void Commit()
        {
            _ctx.SaveChanges();
        }
    }
}
