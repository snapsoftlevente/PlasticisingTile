namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewSignalGroupItem
{
    public NewSignalGroupItem()
    {
        InverseParent = new HashSet<NewSignalGroupItem>();
        InverseSignalParent = new HashSet<NewSignalGroupItem>();
        NewAxisSignals = new HashSet<NewAxisSignal>();
        NewFilterSignals = new HashSet<NewFilter>();
        NewFilterStartTriggerSignals = new HashSet<NewFilter>();
        NewFilterStopTriggerSignals = new HashSet<NewFilter>();
        NewSignalGroupSignalSignalGroups = new HashSet<NewSignalGroupSignal>();
        NewSignalGroupSignalSignals = new HashSet<NewSignalGroupSignal>();
        NewTileSignals = new HashSet<NewTileSignal>();
    }

    public string Id { get; set; } = null!;
    public long? Active { get; set; }
    public long? Advanced { get; set; }
    public string? Alias { get; set; }
    public long? BoolConstantSignalValue { get; set; }
    public string? ColorCode { get; set; }
    public string? ColorId { get; set; }
    public string? Comment1 { get; set; }
    public string? Comment2 { get; set; }
    public long? DataType { get; set; }
    public string? DatasourceId { get; set; }
    public long? DecimalPlaces { get; set; }
    public string? Expression { get; set; }
    public string? FunctionName { get; set; }
    public long Hidden { get; set; }
    public string? Key { get; set; }
    public string Name { get; set; } = null!;
    public long? Ordinal { get; set; }
    public string? ParentId { get; set; }
    public long SignalGroupItemDiscriminator { get; set; }
    public long? SignalGroupType { get; set; }
    public string? SignalParentId { get; set; }
    public string? StringConstantSignalValue { get; set; }
    public long System { get; set; }
    public string? TileId { get; set; }
    public string? Unit { get; set; }
    public long? Updatable { get; set; }
    public double? Value { get; set; }
    public long? Xtype { get; set; }

    public virtual NewDatasource? Datasource { get; set; }
    public virtual NewSignalGroupItem? Parent { get; set; }
    public virtual NewSignalGroupItem? SignalParent { get; set; }
    public virtual NewTile? Tile { get; set; }
    public virtual ICollection<NewSignalGroupItem> InverseParent { get; set; }
    public virtual ICollection<NewSignalGroupItem> InverseSignalParent { get; set; }
    public virtual ICollection<NewAxisSignal> NewAxisSignals { get; set; }
    public virtual ICollection<NewFilter> NewFilterSignals { get; set; }
    public virtual ICollection<NewFilter> NewFilterStartTriggerSignals { get; set; }
    public virtual ICollection<NewFilter> NewFilterStopTriggerSignals { get; set; }
    public virtual ICollection<NewSignalGroupSignal> NewSignalGroupSignalSignalGroups { get; set; }
    public virtual ICollection<NewSignalGroupSignal> NewSignalGroupSignalSignals { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignals { get; set; }
}
