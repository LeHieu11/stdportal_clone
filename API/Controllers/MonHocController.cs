using Microsoft.AspNetCore.Mvc;
using API.DbContext;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonHocController : ControllerBase
    {
        private MyDbContext _dbContext;
        private readonly ILogger<MonHocController> _logger;

        public MonHocController(MyDbContext dbContext, ILogger<MonHocController> logger) 
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonHoc>> GetMonHocByMaMonHoc(string id)
        {
            var monHoc = await _dbContext.MonHoc.FindAsync(id);

            if (monHoc == null) return NotFound();

            return Ok(monHoc);
        }
    }
}