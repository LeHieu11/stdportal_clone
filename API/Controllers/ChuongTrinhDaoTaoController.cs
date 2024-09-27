using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.DbContext;
using AutoMapper;
using API.DTOs;
using Microsoft.AspNetCore.Authorization;
using API.Entities;

namespace API.Controllers
{
    [Route("[controller]")]
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
        [HttpGet("Username/{userName}")]
        [Authorize]
        public async Task<ActionResult<ChuongTrinhDaoTaoDTO>> 
        GetListChuongTrinhDaoTaoByUsername(string userName)
        {
            //Find that sinh vien record by username
            var query = await _context.SinhVienVaChuongTrinhDaoTao
                .Where(svctdt => svctdt.SinhVien.UserName == userName)
                .ToListAsync();

            if (query == null) return NotFound("SinhVien not found");

            return Ok(query);
        }

        [HttpGet("CTDTId/{id}")]
        public async Task<ActionResult<ChuongTrinhDaoTao>> 
        Test(string id)
        {
            var CTDT = await _context.ChuongTrinhDaoTao
                .Select(ctdt => new ChuongTrinhDaoTaoDTO
                {
                    ChuongTrinhDaoTaoId = ctdt.ChuongTrinhDaoTaoId,
                    HeDaoTao = ctdt.HeDaoTao,
                    Nganh = ctdt.Nganh,
                    ChuyenNganh = ctdt.ChuyenNganh,
                    NienKhoa = ctdt.NienKhoa,
                    ChuongTrinhDaoTaoChiTiet = ctdt.ChuongTrinhDaoTaoChiTiets
                        .Select(ctdtct => new ChuongTrinhDaoTaoChiTietDTO
                        {
                            HocKy = ctdtct.HocKy,
                            MaMonHoc = ctdtct.MonHocMaMonHoc,
                            TenMonHoc = ctdtct.MonHoc.TenMonHoc,
                            MoTa = ctdtct.MonHoc.MoTa,
                            TinChi = ctdtct.MonHoc.TinChi,
                            TinChiLyThuyet = ctdtct.MonHoc.TinChiLyThuyet,
                            TinChiThucHanh = ctdtct.MonHoc.TinChiThucHanh,
                            NamHoc = ctdtct.HocPhi.NamHoc,
                            SoTien = ctdtct.HocPhi.SoTien,
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync(ctdt => ctdt.ChuongTrinhDaoTaoId == id);

            if (CTDT == null) return NotFound("CTDT not found");
            
            return Ok(CTDT);
        }
    }
}
