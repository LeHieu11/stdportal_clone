using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [PrimaryKey(nameof(UserName), nameof(ChuongTrinhDaoTaoId))]
    public class SinhVienVaChuongTrinhDaoTao : BaseEntity
    {
        [ForeignKey("UserName")]
        public required string UserName { get; set; }
        public required virtual SinhVien SinhVien { get; set; }

        [ForeignKey("ChuongTrinhDaoTaoId")]
        public required string ChuongTrinhDaoTaoId { get; set; }
        public required virtual ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; }
    }
}