using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class Diem : BaseEntity
    {
        [Key]
        public required string DiemId { get; set; }

        [ForeignKey("SinhVienId")]
        public required string SinhVienId { get; set; }
        public required virtual SinhVien SinhVien { get; set; }

        [ForeignKey("MaMonHoc")]
        public required string MaMonHoc { get; set; }
        public required virtual MonHoc MonHoc { get; set; }

        public double TongKet { get; set; }
        public double QuaTrinh1 { get; set; }
        public double QuaTrinh2 { get; set; }
        public double GiuaKy { get; set; }
        public double CuoiKy { get; set; }

        public string HocKy { get; set; } = string.Empty;
    }
}