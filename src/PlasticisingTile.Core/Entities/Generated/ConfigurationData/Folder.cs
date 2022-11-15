namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class Folder
{
    public Folder()
    {
        Dashboards = new HashSet<Dashboard>();
        InverseParent = new HashSet<Folder>();
    }

    public long Id { get; set; }
    public string? Name { get; set; }
    public long? ParentId { get; set; }
    public string? ImagePath { get; set; }

    public virtual Folder? Parent { get; set; }
    public virtual ICollection<Dashboard> Dashboards { get; set; }
    public virtual ICollection<Folder> InverseParent { get; set; }
}
