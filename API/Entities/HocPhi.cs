using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class HocPhi : BaseEntity
    {
        [Key]
        public string HocPhiId { get; set; }
        public int NamHoc { get; set; }
        public int SoTien { get; set; }

        //relationship
        [ForeignKey("MaMonHoc")]
        public string MaMonHoc { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}

