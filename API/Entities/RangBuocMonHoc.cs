using API.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class RangBuocMonHoc : BaseEntity
    {
        [Key]
        public string RangBuocMonHocId { get; set; }
        public string LoaiRangBuoc { get; set; }

        //relationship
        public ICollection<RangBuocMonHocChiTiet> RangBuocMonHocChiTiets { get; set; }
    }
}