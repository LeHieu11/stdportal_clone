using System.ComponentModel.DataAnnotations;
using API.Entities.Base;

namespace API.Entities
{
    public class ChuongTrinhDaoTao : BaseEntity
    {
        [Key]
        public required string ChuongTrinhDaoTaoId { get; set; }
        public string HeDaoTao { get; set; } = string.Empty;
        public string Nganh { get; set; } = string.Empty;
        public string ChuyenNganh { get; set; } = string.Empty;
        public int NienKhoa { get; set; }

        //relationship
        public required ICollection<ChuongTrinhDaoTaoChiTiet> ChuongTrinhDaoTaoChiTiets { get; set; }
    }
}