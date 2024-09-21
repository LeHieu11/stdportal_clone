using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    [PrimaryKey(nameof(MaMonHoc), nameof(MaMonHocRangBuoc))]
    public class RangBuocMonHoc : BaseEntity
    {
        [ForeignKey("MaMonHoc")]
        public string MaMonHoc { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public string LoaiRangBuoc { get; set; }

        //relationship
        [ForeignKey("MaMonHocRangBuoc")]
        public string MaMonHocRangBuoc { get; set; }
        public virtual MonHoc MonHocRangBuoc { get; set; }
    }
}