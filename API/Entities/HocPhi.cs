using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class HocPhi : BaseEntity
    {
        [Key]
        public required string HocPhiId { get; set; }
        public int NamHoc { get; set; }
        public int SoTien { get; set; }

        //relationship
        [ForeignKey("MaMonHoc")]
        public required string MaMonHoc { get; set; }
        public required virtual MonHoc MonHoc { get; set; }
    }
}

