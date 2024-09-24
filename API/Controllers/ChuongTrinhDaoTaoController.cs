using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.DbContext;
using AutoMapper;
using API.DTOs;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuongTrinhDaoTaoController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public ChuongTrinhDaoTaoController(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ChuongTrinhDaoTao/5
        [HttpGet("{userName}")]
        public async Task<ActionResult<ChuongTrinhDaoTaoDTO>> 
        GetChuongTrinhDaoTao(string userName)
        {
            var listCTDT = await _context.SinhVienVaChuongTrinhDaoTao
                .Where(x => x.UserName == userName)
                .ToListAsync();

            if (listCTDT == null) return NotFound();

            if (listCTDT.Count == 0) return NoContent();
            
            return Ok(_mapper.Map<List<ChuongTrinhDaoTaoDTO>>(listCTDT));
        }
    }
}
