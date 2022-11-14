namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewFolderItem
{
    public NewFolderItem()
    {
        NewFilters = new HashSet<NewFilter>();
        NewTiles = new HashSet<NewTile>();
    }

    public string Id { get; set; } = null!;
    public long FolderItemDiscriminator { get; set; }
    public string Name { get; set; } = null!;
    public string? ImagePath { get; set; }
    public string? DerivedImagePath { get; set; }
    public long? IsSharedClone { get; set; }
    public string? CreatedAt { get; set; }
    public string? OriginalId { get; set; }
    public string? EventArray { get; set; }
    public string? TimestampArray { get; set; }
    public long? Access { get; set; }

    public virtual ICollection<NewFilter> NewFilters { get; set; }
    public virtual ICollection<NewTile> NewTiles { get; set; }
}
