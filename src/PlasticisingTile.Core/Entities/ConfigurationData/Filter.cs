namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class Filter
{
    public Filter()
    {
        InverseParent = new HashSet<Filter>();
    }

    public long Id { get; set; }
    public string? ActiveMarks { get; set; }
    public long? BoolValue { get; set; }
    public long? DashboardId { get; set; }
    public long? DatasourceId { get; set; }
    public long? EndEventId { get; set; }
    public long? FileCount { get; set; }
    public long IsRelative { get; set; }
    public string? Key { get; set; }
    public string? LeftInclusive { get; set; }
    public string? Name { get; set; }
    public double? NumEnd { get; set; }
    public string? NumMultiEnd { get; set; }
    public string? NumMultiStart { get; set; }
    public double? NumStart { get; set; }
    public string Operator { get; set; } = null!;
    public long? ParentId { get; set; }
    public string? ReferenceData { get; set; }
    public string? RelativeDate { get; set; }
    public string? RightInclusive { get; set; }
    public long? StartEventId { get; set; }
    public string? StrValues { get; set; }
    public string? Text { get; set; }
    public long? TileId { get; set; }
    public long? TimestampEnd { get; set; }
    public long? TimestampStart { get; set; }
    public string? WorkShiftEnd { get; set; }
    public string? WorkShiftStart { get; set; }

    public virtual Dashboard? Dashboard { get; set; }
    public virtual Datasource? Datasource { get; set; }
    public virtual Filter? Parent { get; set; }
    public virtual ICollection<Filter> InverseParent { get; set; }
}
