using System.ComponentModel.DataAnnotations;
using API.Entities.Base;

namespace API.Entities
{
    public class MonHoc : BaseEntity
    {
        [Key]
        public string MaMonHoc {get; set;}
        public string TenMonHoc { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public int TinChi { get; set; }
        public int TinChiLyThuyet { get; set;}
        public int TinChiThucHanh { get; set; }

        //relationship
        public ICollection<HocPhi> HocPhis { get; set;} = [];
        public ICollection<NhomMonHocVaMonHoc>? NhomMonHocVaMonHocs{ get; set;}

        // public ICollection<RangBuoc>? MonRangBuocs { get; set;}
        // public ICollection<RangBuoc>? MonBiRangBuocs { get; set;}
    }
}
