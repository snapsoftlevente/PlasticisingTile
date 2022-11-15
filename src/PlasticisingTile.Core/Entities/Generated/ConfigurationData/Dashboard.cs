namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class Dashboard
{
    public Dashboard()
    {
        Filters = new HashSet<Filter>();
    }

    public long Id { get; set; }
    public string? Name { get; set; }
    public long? ParentId { get; set; }
    public long? WorkShiftId { get; set; }
    public string? ImagePath { get; set; }
    public string CreatedAt { get; set; } = null!;
    public string? EventArray { get; set; }
    public long IsSharedClone { get; set; }
    public long OriginalId { get; set; }
    public string? TimestampArray { get; set; }
    public string? Guid { get; set; }

    public virtual Folder? Parent { get; set; }
    public virtual ICollection<Filter> Filters { get; set; }
}
