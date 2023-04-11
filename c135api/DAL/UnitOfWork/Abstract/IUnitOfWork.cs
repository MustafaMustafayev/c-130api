using c135api.DAL.Abstract;

namespace c135api.DAL.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
        public IRoleRepository RoleRepository { get; }
        public void Commit();
    }
}
