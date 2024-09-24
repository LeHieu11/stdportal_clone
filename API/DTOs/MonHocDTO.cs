namespace API.DTOs
{
    public class MonHocDTO
    {
        public required string MaMonHoc {get; set;}
        public string TenMonHoc { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public int TinChi { get; set; }
        public int TinChiLyThuyet { get; set;}
        public int TinChiThucHanh { get; set; }
    }
}
