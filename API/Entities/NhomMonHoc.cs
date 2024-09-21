using System.ComponentModel.DataAnnotations;
using API.Entities.Base;

namespace API.Entities
{
    public class NhomMonHoc : BaseEntity
    {
        [Key]
        public string NhomMonHocId { get; set; }
        public string TenNhom { get; set; } = string.Empty;

        //relationship
        public ICollection<NhomMonHocVaMonHoc>? NhomMonHocVaMonHocs { get; set; }
    }
}