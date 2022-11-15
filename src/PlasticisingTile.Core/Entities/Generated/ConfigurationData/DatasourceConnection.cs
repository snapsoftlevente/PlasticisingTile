namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class DatasourceConnection
{
    public DatasourceConnection()
    {
        Datasources = new HashSet<Datasource>();
    }

    public long Id { get; set; }
    public string? Host { get; set; }
    public long IntegratedSecurity { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    public long Port { get; set; }
    public string? Realm { get; set; }
    public string Type { get; set; } = null!;
    public string? User { get; set; }
    public string? ConnectionString { get; set; }
    public string Method { get; set; } = null!;
    public string? TlsCertificate { get; set; }
    public long? HdServicePort { get; set; }

    public virtual ICollection<Datasource> Datasources { get; set; }
}
