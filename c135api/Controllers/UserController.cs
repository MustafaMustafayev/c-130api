using AutoMapper;
using c135api.BLL.Abstract;
using c135api.DAL;
using c135api.DTOs.RoleDtos;
using c135api.DTOs.UserDtos;
using c135api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c135api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService; 
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dtos = _userService.Get();
            return Ok(dtos);
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserToAddDto dto)
        {
            _userService.Add(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
