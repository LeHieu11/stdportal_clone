using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class Diem : BaseEntity
    {
        [Key]
        public string DiemId { get; set; }

        [ForeignKey("UserName")]
        public string UserName { get; set; }
        public virtual SinhVien SinhVien { get; set; }

        [ForeignKey("MaMonHoc")]
        public string MaMonHoc { get; set; }
        public virtual MonHoc MonHoc { get; set; }

        public double TongKet { get; set; }
        public double QuaTrinh1 { get; set; }
        public double QuaTrinh2 { get; set; }
        public double GiuaKy { get; set; }
        public double CuoiKy { get; set; }

        public string HocKy { get; set; }
    }
}