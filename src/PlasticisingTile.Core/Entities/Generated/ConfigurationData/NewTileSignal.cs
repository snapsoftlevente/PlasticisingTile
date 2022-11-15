namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewTileSignal
{
    public string Id { get; set; } = null!;
    public long? AggregationType { get; set; }
    public string? CategoryTileId { get; set; }
    public string? ColorAxisId { get; set; }
    public string? ColorCode { get; set; }
    public string? ColorId { get; set; }
    public long Hidden { get; set; }
    public string? IdentTileId { get; set; }
    public long? OrderDirection { get; set; }
    public string? OrderTileId { get; set; }
    public long? Position { get; set; }
    public string? ReferenceTileId { get; set; }
    public string? SelectedTileId { get; set; }
    public string SignalId { get; set; } = null!;
    public string? XaxisId { get; set; }
    public string? YaxisId { get; set; }
    public string? ZaxisId { get; set; }

    public virtual NewTile? CategoryTile { get; set; }
    public virtual NewAxis? ColorAxis { get; set; }
    public virtual NewTile? IdentTile { get; set; }
    public virtual NewTile? OrderTile { get; set; }
    public virtual NewTile? ReferenceTile { get; set; }
    public virtual NewTile? SelectedTile { get; set; }
    public virtual NewSignalGroupItem Signal { get; set; } = null!;
    public virtual NewAxis? Xaxis { get; set; }
    public virtual NewAxis? Yaxis { get; set; }
    public virtual NewAxis? Zaxis { get; set; }
}
