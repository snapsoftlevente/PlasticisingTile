namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewAxisSignal
{
    public string Id { get; set; } = null!;
    public string? MinAxisId { get; set; }
    public string? MaxAxisId { get; set; }
    public string SignalId { get; set; } = null!;

    public virtual NewAxis? MaxAxis { get; set; }
    public virtual NewAxis? MinAxis { get; set; }
    public virtual NewSignalGroupItem Signal { get; set; } = null!;
}
