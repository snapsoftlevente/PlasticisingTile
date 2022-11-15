namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewAxis
{
    public NewAxis()
    {
        NewAxisSignalMaxAxes = new HashSet<NewAxisSignal>();
        NewAxisSignalMinAxes = new HashSet<NewAxisSignal>();
        NewTileSignalColorAxes = new HashSet<NewTileSignal>();
        NewTileSignalXaxes = new HashSet<NewTileSignal>();
        NewTileSignalYaxes = new HashSet<NewTileSignal>();
        NewTileSignalZaxes = new HashSet<NewTileSignal>();
    }

    public string Id { get; set; } = null!;
    public long AutoScale { get; set; }
    public long AxisType { get; set; }
    public string? ColorTileId { get; set; }
    public long DataType { get; set; }
    public string Name { get; set; } = null!;
    public long Position { get; set; }
    public string? Unit { get; set; }
    public string? XtileId { get; set; }
    public string? YtileId { get; set; }
    public string? ZtileId { get; set; }

    public virtual NewTile? ColorTile { get; set; }
    public virtual NewTile? Xtile { get; set; }
    public virtual NewTile? Ytile { get; set; }
    public virtual NewTile? Ztile { get; set; }
    public virtual ICollection<NewAxisSignal> NewAxisSignalMaxAxes { get; set; }
    public virtual ICollection<NewAxisSignal> NewAxisSignalMinAxes { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalColorAxes { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalXaxes { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalYaxes { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalZaxes { get; set; }
}
