using Microsoft.AspNetCore.Mvc;
using API.DbContext;
using API.Entities;
using AutoMapper;
using API.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonHocController : ControllerBase
    {
        private MyDbContext _dbContext;
        private IMapper _mapper;

        public MonHocController(MyDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonHocDTO>> GetMonHocByMaMonHoc(string id)
        {
            var monHoc = await _dbContext.MonHoc.FindAsync(id);

            if (monHoc == null) return NotFound();

            return Ok(_mapper.Map<MonHocDTO>(monHoc));
        }
    }
}