namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewDatasource
{
    public NewDatasource()
    {
        InverseParent = new HashSet<NewDatasource>();
        NewSignalGroupItems = new HashSet<NewSignalGroupItem>();
        NewTileDatasources = new HashSet<NewTileDatasource>();
    }

    public string Id { get; set; } = null!;
    public long DatasourceDiscriminator { get; set; }
    public string Name { get; set; } = null!;
    public string? ParentId { get; set; }

    public virtual NewDatasource? Parent { get; set; }
    public virtual ICollection<NewDatasource> InverseParent { get; set; }
    public virtual ICollection<NewSignalGroupItem> NewSignalGroupItems { get; set; }
    public virtual ICollection<NewTileDatasource> NewTileDatasources { get; set; }
}
