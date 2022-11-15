namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewSignalGroupSignal
{
    public string Id { get; set; } = null!;
    public string SignalGroupId { get; set; } = null!;
    public string SignalId { get; set; } = null!;

    public virtual NewSignalGroupItem Signal { get; set; } = null!;
    public virtual NewSignalGroupItem SignalGroup { get; set; } = null!;
}
