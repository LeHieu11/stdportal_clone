namespace API.DTOs
{
    public class ChuongTrinhDaoTaoChiTietDTO
    {
        // public required string ChuongTrinhDaoTaoChiTietId { get; set; }
        public string HocKy { get; set; } = string.Empty;

        // Belong to MonHocDTO
        public required string MaMonHoc {get; set;}
        public string TenMonHoc { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public int TinChi { get; set; }
        public int TinChiLyThuyet { get; set;}
        public int TinChiThucHanh { get; set; }
        // public MonHocDTO? MonHoc { get; set; }

        // Belong to HocPhiDTO
        public string NamHoc { get; set; } = string.Empty;
        public int SoTien { get; set; }
        // public HocPhiDTO? HocPhi { get; set; }
    }
}