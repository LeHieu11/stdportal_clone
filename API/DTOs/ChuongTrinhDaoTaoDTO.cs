using API.Entities;

namespace API.DTOs
{
    public class ChuongTrinhDaoTaoDTO
    {
        public required string ChuongTrinhDaoTaoId { get; set; }
        public string HeDaoTao { get; set; } = string.Empty;
        public string Nganh { get; set; } = string.Empty;
        public string ChuyenNganh { get; set; } = string.Empty;
        public int NienKhoa { get; set; }

        //relationship
        public ICollection<ChuongTrinhDaoTaoChiTietDTO>? ChuongTrinhDaoTaoChiTiet { get; set; }
    }
}