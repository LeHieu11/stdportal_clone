using API.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class RangBuocMonHoc : BaseEntity
    {
        [Key]
        public required string RangBuocMonHocId { get; set; }
        public string LoaiRangBuoc { get; set; } = string.Empty;

        //relationship
        public ICollection<RangBuocMonHocChiTiet> RangBuocMonHocChiTiets { get; set; }
            = new List<RangBuocMonHocChiTiet>();
    }
}