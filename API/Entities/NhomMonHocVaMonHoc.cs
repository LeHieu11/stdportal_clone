using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [PrimaryKey(nameof(NhomMonHocId), nameof(MaMonHoc))]
    public class NhomMonHocVaMonHoc : BaseEntity
    {
        [ForeignKey("NhomMonHocId")]
        public required string NhomMonHocId { get; set; }
        public required virtual NhomMonHoc NhomMonHoc { get; set; }

        [ForeignKey("MaMonHoc")]
        public required string MaMonHoc { get; set; }
        public required virtual MonHoc MonHoc { get; set; }
    }
}