namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class DatasourceColumn
{
    public long Id { get; set; }
    public long AccessLevel { get; set; }
    public string? ColorCode { get; set; }
    public long? ColorId { get; set; }
    public long? DatasourceDataLevel { get; set; }
    public long DatasourceId { get; set; }
    public long? DatasourceReadingMode { get; set; }
    public long? DecimalPlaces { get; set; }
    public string? Key { get; set; }
    public string? Name { get; set; }
    public string? Unit { get; set; }

    public virtual Datasource Datasource { get; set; } = null!;
}
