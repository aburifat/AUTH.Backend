using AUTH.Backend.Utilities;

namespace AUTH.Backend.Repository.Models;

public class BaseEntity : IBaseEntity
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public long? CreatedBy { get; set; }
    public long? UpdatedBy { get; set; }


    public virtual void OnCreate()
    {
        CreatedAt = DateTimeUtilities.CurrentDateTime();
        IsDeleted = false;
    }

    public virtual void OnUpdate()
    {
        UpdatedAt = DateTimeUtilities.CurrentDateTime();
    }

    public virtual void OnDelete()
    {
        UpdatedAt = DateTimeUtilities.CurrentDateTime();
        IsDeleted = true;
    }
}
