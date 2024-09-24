using API.Entities;

namespace API.DTOs
{
    public class ChuongTrinhDaoTaoDTO
    {
        public string ChuongTrinhDaoTaoId { get; set; }
        public string HeDaoTao { get; set; }
        public string Nganh { get; set; }
        public string ChuyenNganh { get; set; }

        //relationship
        public ICollection<ChuongTrinhDaoTaoChiTietDTO>? CTDT_ChiTiets { get; set; }
    }
}