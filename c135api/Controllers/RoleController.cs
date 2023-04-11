using AutoMapper;
using c135api.DAL;
using c135api.DTOs.RoleDtos;
using c135api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c135api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly MyContext _ctx;
        private readonly IMapper _mapper;
        public RoleController(MyContext ctx, IMapper mapper)
        {
            _ctx= ctx;
            _mapper= mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Role> entities = _ctx.Roles.ToList();
            List<RoleToListDto> dtos = _mapper.Map<List<RoleToListDto>>(entities);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            Role entity = _ctx.Roles.Include(m => m.Permissions).SingleOrDefault(m => m.RoleId == id);
            RoleToByIdDto dto = _mapper.Map<RoleToByIdDto>(entity);
            return Ok(dto);
        }

        [HttpPost]
        public IActionResult Add([FromBody] RoleToAddDto dto)
        {
            Role entity = _mapper.Map<Role>(dto);
           
            _ctx.Roles.Add(entity);
            _ctx.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] RoleToUpdateDto dto)
        {
            Role entity = _mapper.Map<Role>(dto);
            entity.RoleId = id;

            _ctx.Entry(entity).Property(m => m.Key).IsModified = false;
            _ctx.Roles.Update(entity);
            _ctx.SaveChanges();
            return Ok();
        }

    }
}
