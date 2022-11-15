namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class Datasource
{
    public Datasource()
    {
        DatasourceColumns = new HashSet<DatasourceColumn>();
        Filters = new HashSet<Filter>();
        InverseReferenceDatasource = new HashSet<Datasource>();
    }

    public long Id { get; set; }
    public string? ChannelHeader { get; set; }
    public long ConnectionId { get; set; }
    public string? DatPassword { get; set; }
    public string? DatPathFrom { get; set; }
    public long DatPathReplace { get; set; }
    public string? DatPathTo { get; set; }
    public string? Name { get; set; }
    public string? PdfPathFrom { get; set; }
    public long PdfPathReplace { get; set; }
    public string? PdfPathTo { get; set; }
    public long? ReferenceDatasourceId { get; set; }
    public string? ReferenceIdentColumnKey { get; set; }
    public long? ReferenceLevel { get; set; }
    public string? ReferenceReadingMode { get; set; }
    public long SegmentDataAvailable { get; set; }
    public string? Segments { get; set; }
    public string? TableOrStoreName { get; set; }
    public string? TimestampColumnName { get; set; }
    public string Type { get; set; } = null!;
    public string? Timezone { get; set; }
    public long DownloadableCsvPaths { get; set; }
    public long DownloadableParquetPaths { get; set; }
    public long DownloadablePdfPaths { get; set; }
    public long DisplayOnlyFileNames { get; set; }
    public string? LogTomcolumn { get; set; }
    public string? LogUomcolumn { get; set; }
    public long LogUserUpdates { get; set; }
    public long DownloadableZipPaths { get; set; }
    public string? Guid { get; set; }

    public virtual DatasourceConnection Connection { get; set; } = null!;
    public virtual Datasource? ReferenceDatasource { get; set; }
    public virtual ICollection<DatasourceColumn> DatasourceColumns { get; set; }
    public virtual ICollection<Filter> Filters { get; set; }
    public virtual ICollection<Datasource> InverseReferenceDatasource { get; set; }
}
