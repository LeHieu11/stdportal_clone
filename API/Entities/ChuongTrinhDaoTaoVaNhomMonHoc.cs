using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [PrimaryKey(nameof(ChuongTrinhDaoTaoId), nameof(NhomMonHocId))]
    public class ChuongTrinhDaoTaoVaNhomMonHoc : BaseEntity
    {
        [ForeignKey("ChuongTrinhDaoTaoId")]
        public string ChuongTrinhDaoTaoId { get; set; }
        public virtual ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; }

        [ForeignKey("NhomMonHocId")]
        public string NhomMonHocId { get; set; }
        public virtual NhomMonHoc NhomMonHoc { get; set; }
    }
}