using AutoMapper;
using c135api.DAL;
using c135api.DTOs.BlokDtos;
using c135api.DTOs.FloorDtos;
using c135api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c135api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlookController : ControllerBase
    {
        private readonly MyContext _ctx;
        private readonly IMapper _mapper;
        public BlookController(MyContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        [HttpGet("{id}/floors")]
        public IActionResult GetFLoors([FromRoute] int id)
        {
            ICollection<Floor> entities = _ctx.Floors.Where(m => m.BlokId == id).ToList(); //immediate execution 
            List<FloorToListDto> dtos = _mapper.Map<List<FloorToListDto>>(entities);
            return Ok(dtos);
        }

        [HttpGet]
        public IActionResult Get()
        {
            ICollection<Blok> bloks = _ctx.Bloks.IgnoreQueryFilters().ToList(); //immediate execution 
            List<BlokToListDto> dtos = _mapper.Map<List<BlokToListDto>>(bloks);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            Blok data = _ctx.Bloks.Find(id);
            BlokToListDto dto = _mapper.Map<BlokToListDto>(data);
            return Ok(dto);
        }

        [HttpPost]
        public IActionResult Add([FromBody] BlokToAddDto dto)
        {
            Blok data = _mapper.Map<Blok>(dto);

            _ctx.Bloks.Add(data);
            _ctx.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id,[FromBody] BlokToUpdateDto dto)
        {
            Blok data = _mapper.Map<Blok>(dto);
            data.Id = id;

            _ctx.Bloks.Update(data);
            _ctx.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Blok data = _ctx.Bloks.Find(id);

            data.IsDeleted = true;

            _ctx.SaveChanges();
            return Ok();
        }
    }
}