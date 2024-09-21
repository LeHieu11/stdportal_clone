using System.ComponentModel.DataAnnotations;
using API.Entities.Base;

namespace API.Entities
{
    public class ChuongTrinhDaoTao : BaseEntity
    {
        [Key]
        public string ChuongTrinhDaoTaoId { get; set; }
        public string HeDaoTao { get; set; }
        public string Nganh { get; set; }
        public string ChuyenNganh { get; set; }

        //relationship
        public ICollection<ChuongTrinhDaoTaoChiTiet>? CTDT_ChiTiets { get; set; }
    }
}