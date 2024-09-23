using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class RangBuocMonHocChiTiet : BaseEntity
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("RangBuocMonHocId")]
        public string RangBuocMonHocId { get; set; }
        public virtual RangBuocMonHoc RangBuocMonHoc { get; set; }

        [ForeignKey("MonHocRangBuocId")]
        public string MonHocRangBuocId { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}