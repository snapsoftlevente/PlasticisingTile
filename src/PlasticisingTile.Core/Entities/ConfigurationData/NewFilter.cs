namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewFilter
{
    public NewFilter()
    {
        InverseParent = new HashSet<NewFilter>();
    }

    public string Id { get; set; } = null!;
    public long FilterDiscriminator { get; set; }
    public string? DashboardId { get; set; }
    public string? TileId { get; set; }
    public string? SignalId { get; set; }
    public string? ParentId { get; set; }
    public long Editable { get; set; }
    public long Active { get; set; }
    public string? Text { get; set; }
    public long? EditableFilterDiscriminator { get; set; }
    public long? Value { get; set; }
    public string? Low { get; set; }
    public string? High { get; set; }
    public long? IncludeLow { get; set; }
    public long? IncludeHigh { get; set; }
    public string? StartTriggerSignalId { get; set; }
    public long? StartTriggerRisingEdge { get; set; }
    public string? StopTriggerSignalId { get; set; }
    public long? StopriggerRisingEdge { get; set; }
    public double? NumberBetweenFilterLow { get; set; }
    public double? NumberBetweenFilterHigh { get; set; }
    public long? NumberBetweenFilterIncludeLow { get; set; }
    public long? NumberBetweenFilterIncludeHigh { get; set; }
    public long? OrFilterEditableFilterDiscriminator { get; set; }
    public string? StringContainsFilterValue { get; set; }
    public string? StringEqFilterValue { get; set; }
    public string? WorkShiftFilterLow { get; set; }
    public string? WorkShiftFilterHigh { get; set; }
    public long? WorkShiftFilterIncludeLow { get; set; }
    public long? WorkShiftFilterIncludeHigh { get; set; }
    public long? Xtype { get; set; }
    public long? XrangeFilterLow { get; set; }
    public long? XrangeFilterHigh { get; set; }
    public long? Global { get; set; }
    public long? Relative { get; set; }
    public string? RelativeDate { get; set; }

    public virtual NewFolderItem? Dashboard { get; set; }
    public virtual NewFilter? Parent { get; set; }
    public virtual NewSignalGroupItem? Signal { get; set; }
    public virtual NewSignalGroupItem? StartTriggerSignal { get; set; }
    public virtual NewSignalGroupItem? StopTriggerSignal { get; set; }
    public virtual NewTile? Tile { get; set; }
    public virtual ICollection<NewFilter> InverseParent { get; set; }
}
