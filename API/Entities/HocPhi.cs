using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Entities.Base;

namespace API.Entities
{
    public class HocPhi : BaseEntity
    {
        [Key]
        public required string HocPhiId { get; set; }
        public string NamHoc { get; set; } = string.Empty;
        public int SoTien { get; set; }
    }
}

