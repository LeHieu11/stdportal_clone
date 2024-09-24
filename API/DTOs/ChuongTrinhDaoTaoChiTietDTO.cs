using API.Entities;

namespace API.DTOs
{
    public class ChuongTrinhDaoTaoChiTietDTO
    {
        public string ChuongTrinhDaoTaoChiTietId { get; set; }
        public string HocKy { get; set; }
        public virtual MonHocDTO MonHoc { get; set; }  
    }
}