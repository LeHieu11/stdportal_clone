using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class ChuongTrinhDaoTaoChiTiet : BaseEntity
    {
        [Key]
        public string ChuongTrinhDaoTaoChiTietId { get; set; }
        public int HK { get; set; }
        
        [ForeignKey("ChuongTrinhChiTietId")]
        public string ChuongTrinhDaoTaoId { get; set; }
        public virtual ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; }

        [ForeignKey("MaMonHoc")]
        public string MaMonHoc { get; set; }
        public virtual MonHoc MonHoc { get; set; }  
    }
}