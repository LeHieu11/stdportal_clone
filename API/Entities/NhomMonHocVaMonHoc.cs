using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [PrimaryKey(nameof(NhomMonHocId), nameof(MaMonHoc))]
    public class NhomMonHocVaMonHoc : BaseEntity
    {
        [ForeignKey("NhomMonHocId")]
        public string NhomMonHocId { get; set; }
        public virtual NhomMonHoc NhomMonHoc { get; set; }

        [ForeignKey("MaMonHoc")]
        public string MaMonHoc { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}