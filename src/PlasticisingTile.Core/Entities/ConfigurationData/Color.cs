namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class Color
{
    public Color()
    {
        InverseParent = new HashSet<Color>();
    }

    public long Id { get; set; }
    public string? ColorCode { get; set; }
    public long DefaultColor { get; set; }
    public long Deletable { get; set; }
    public long? ParentId { get; set; }
    public long Position { get; set; }
    public long PositionedId { get; set; }

    public virtual Color? Parent { get; set; }
    public virtual ICollection<Color> InverseParent { get; set; }
}
