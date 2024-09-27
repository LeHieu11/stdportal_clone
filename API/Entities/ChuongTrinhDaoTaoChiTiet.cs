using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class ChuongTrinhDaoTaoChiTiet : BaseEntity
    {
        [Key]
        public required string ChuongTrinhDaoTaoChiTietId { get; set; }
        public string HocKy { get; set; } = string.Empty;
        
        [ForeignKey("ChuongTrinhDaoTaoId")]
        public required string ChuongTrinhDaoTaoId { get; set; }
        public virtual required ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; }

        [ForeignKey("MaMonHoc")]
        public required string MonHocMaMonHoc { get; set; }
        public virtual required MonHoc MonHoc { get; set; }

        [ForeignKey("HocPhiId")]
        public required string HocPhiId { get; set; }
        public virtual required HocPhi HocPhi { get; set; }
    }
}