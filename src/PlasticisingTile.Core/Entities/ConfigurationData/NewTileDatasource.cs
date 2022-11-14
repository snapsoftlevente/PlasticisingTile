namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewTileDatasource
{
    public string Id { get; set; } = null!;
    public string TileId { get; set; } = null!;
    public string DatasourceId { get; set; } = null!;

    public virtual NewDatasource Datasource { get; set; } = null!;
    public virtual NewTile Tile { get; set; } = null!;
}
