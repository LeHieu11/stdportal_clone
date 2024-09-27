using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class RangBuocMonHocChiTiet : BaseEntity
    {
        [Key]
        public required string Id { get; set; }

        [ForeignKey("RangBuocMonHocId")]
        public required string RangBuocMonHocId { get; set; }
        public required virtual RangBuocMonHoc RangBuocMonHoc { get; set; }

        [ForeignKey("MonHocRangBuocId")]
        public required string MonHocMaMonHoc { get; set; }
        public required virtual MonHoc MonHoc { get; set; }
    }
}