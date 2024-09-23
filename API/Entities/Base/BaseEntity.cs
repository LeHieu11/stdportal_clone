namespace API.Entities.Base
{
    public class BaseEntity : IBaseEntity 
    {
        public DateTimeOffset? CreatedTime { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }

        public string? CreatedBy { get; set; } = string.Empty;
        public string? LastUpdatedBy { get; set; } = string.Empty;
        public string? DeletedBy { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
    }
}

