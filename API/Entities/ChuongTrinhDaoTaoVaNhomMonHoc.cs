using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [PrimaryKey(nameof(ChuongTrinhDaoTaoId), nameof(NhomMonHocId))]
    public class ChuongTrinhDaoTaoVaNhomMonHoc : BaseEntity
    {
        [ForeignKey("ChuongTrinhDaoTaoId")]
        public required string ChuongTrinhDaoTaoId { get; set; }
        public required virtual ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; }

        [ForeignKey("NhomMonHocId")]
        public required string NhomMonHocId { get; set; }
        public required virtual NhomMonHoc NhomMonHoc { get; set; }
    }
}