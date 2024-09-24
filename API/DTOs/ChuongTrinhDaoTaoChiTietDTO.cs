using API.Entities;

namespace API.DTOs
{
    public class ChuongTrinhDaoTaoChiTietDTO
    {
        public required string ChuongTrinhDaoTaoChiTietId { get; set; }
        public string HocKy { get; set; } = string.Empty;
        public virtual MonHocDTO? MonHoc { get; set; }  
    }
}