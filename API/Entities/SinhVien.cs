using API.Entities.Base;
using Microsoft.AspNetCore.Identity;

namespace API.Entities;
public class SinhVien : IdentityUser, IBaseEntity 
{
    //implement BaseEntity Interface
    public DateTimeOffset? CreatedTime { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? LastUpdatedTime { get; set; }
    public DateTimeOffset? DeletedTime { get; set; }

    public string? CreatedBy { get; set; } = string.Empty;
    public string? LastUpdatedBy { get; set; } = string.Empty;
    public string? DeletedBy { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
    public bool IsDelete { get; set; } = false;

    //custom prop
    public ICollection<Diem> Diems { get; set; }
    
}