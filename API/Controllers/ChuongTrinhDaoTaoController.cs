using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.DbContext;
using API.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuongTrinhDaoTaoController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ChuongTrinhDaoTaoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/ChuongTrinhDaoTao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChuongTrinhDaoTao>>> 
        GetChuongTrinhDaoTao()
        {
            return await _context.ChuongTrinhDaoTao.ToListAsync();
        }

        // GET: api/ChuongTrinhDaoTao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChuongTrinhDaoTao>> GetChuongTrinhDaoTao(string id)
        {
            var chuongTrinhDaoTao = await _context.ChuongTrinhDaoTao.FindAsync(id);

            if (chuongTrinhDaoTao == null)
            {
                return NotFound();
            }

            return chuongTrinhDaoTao;
        }

        // PUT: api/ChuongTrinhDaoTao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChuongTrinhDaoTao(string id, ChuongTrinhDaoTao chuongTrinhDaoTao)
        {
            if (id != chuongTrinhDaoTao.ChuongTrinhDaoTaoId)
            {
                return BadRequest();
            }

            _context.Entry(chuongTrinhDaoTao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChuongTrinhDaoTaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ChuongTrinhDaoTao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChuongTrinhDaoTao>> PostChuongTrinhDaoTao(ChuongTrinhDaoTao chuongTrinhDaoTao)
        {
            _context.ChuongTrinhDaoTao.Add(chuongTrinhDaoTao);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChuongTrinhDaoTaoExists(chuongTrinhDaoTao.ChuongTrinhDaoTaoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChuongTrinhDaoTao", new { id = chuongTrinhDaoTao.ChuongTrinhDaoTaoId }, chuongTrinhDaoTao);
        }

        private bool ChuongTrinhDaoTaoExists(string id)
        {
            return _context.ChuongTrinhDaoTao.Any(e => e.ChuongTrinhDaoTaoId == id);
        }
    }
}
