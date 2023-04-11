using AutoMapper;
using c135api.DAL;
using c135api.DTOs.FloorDtos;
using c135api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c135api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorController : ControllerBase
    {
        private readonly MyContext _ctx;
        private readonly IMapper _mapper;
        public FloorController(MyContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Floor> entities = _ctx.Floors.Include(m => m.Blok).ToList(); //eager load, lazy load
            List<FloorToListDto> dtos = _mapper.Map<List<FloorToListDto>>(entities);
            return Ok(dtos);
        }

        [HttpPost]
        public IActionResult Add([FromBody] FLoorToAddWithBlokDto dto)
        {
            Floor entity = _mapper.Map<Floor>(dto);
            _ctx.Floors.Add(entity);
            _ctx.SaveChanges();
            return Ok();
        }
    }
}
