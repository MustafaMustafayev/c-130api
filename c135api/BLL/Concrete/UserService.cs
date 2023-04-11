using AutoMapper;
using c135api.BLL.Abstract;
using c135api.DAL.Abstract;
using c135api.DAL.UnitOfWork.Abstract;
using c135api.DTOs.UserDtos;
using c135api.Entities;

namespace c135api.BLL.Concrete
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;    
        public UserService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public void Add(UserToAddDto dto)
        {
            User entity = _mapper.Map<User>(dto);
            _unitOfWork.UserRepository.Add(entity);

            _unitOfWork.RoleRepository.Add(new Role()
            {
                RoleId = 1,
                Name = "afafa",
                Key = "wefwef"
            });
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            User entity = _unitOfWork.UserRepository.Get(id);
            _unitOfWork.UserRepository.Delete(entity);
        }

        public List<UserToListDto> Get()
        {
            List<User> entities = _unitOfWork.UserRepository.Get();
            return _mapper.Map<List<UserToListDto>>(entities);
        }
    }
}
