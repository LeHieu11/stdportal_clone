using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class MonHoc : BaseEntity
    {
        [Key]
        public required string MaMonHoc {get; set;}
        public string TenMonHoc { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public int TinChi { get; set; }
        public int TinChiLyThuyet { get; set;}
        public int TinChiThucHanh { get; set; }

        //relationship
        public ICollection<NhomMonHocVaMonHoc>? NhomMonHocVaMonHocs{ get; set;}

        [ForeignKey("RangBuocMonHocId")]
        public string? RangBuocMonHocId { get; set; }
        public RangBuocMonHoc? RangBuocMonHoc { get; set; }
    }
}
