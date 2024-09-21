using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [PrimaryKey(nameof(UserName), nameof(ChuongTrinhDaoTaoId))]
    public class SinhVienVaChuongTrinhDaoTao : BaseEntity
    {
        [ForeignKey("UserName")]
        public string UserName { get; set; }
        public virtual SinhVien SinhVien { get; set; }

        [ForeignKey("ChuongTrinhDaoTaoId")]
        public string ChuongTrinhDaoTaoId { get; set; }
        public virtual ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; }
    }
}