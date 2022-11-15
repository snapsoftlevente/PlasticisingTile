namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class NewTile
{
    public NewTile()
    {
        NewAxisColorTiles = new HashSet<NewAxis>();
        NewAxisXtiles = new HashSet<NewAxis>();
        NewAxisYtiles = new HashSet<NewAxis>();
        NewAxisZtiles = new HashSet<NewAxis>();
        NewFilters = new HashSet<NewFilter>();
        NewSignalGroupItems = new HashSet<NewSignalGroupItem>();
        NewTileDatasources = new HashSet<NewTileDatasource>();
        NewTileSignalCategoryTiles = new HashSet<NewTileSignal>();
        NewTileSignalIdentTiles = new HashSet<NewTileSignal>();
        NewTileSignalOrderTiles = new HashSet<NewTileSignal>();
        NewTileSignalReferenceTiles = new HashSet<NewTileSignal>();
        NewTileSignalSelectedTiles = new HashSet<NewTileSignal>();
    }

    public string Id { get; set; } = null!;
    public long TileDiscriminator { get; set; }
    public string Name { get; set; } = null!;
    public long X { get; set; }
    public long Y { get; set; }
    public long W { get; set; }
    public long H { get; set; }
    public string DashboardId { get; set; } = null!;
    public long Xtype { get; set; }
    public long CursorLimit { get; set; }
    public long? BarTileAggregationType { get; set; }
    public long? BarTileSortMode { get; set; }
    public long? PercentageMode { get; set; }
    public long? StackedMode { get; set; }
    public long? BarTileCategoryLimit { get; set; }
    public long? BarTileShowOthersCategory { get; set; }
    public long? BarTileShowLegendOnDashboard { get; set; }
    public long? ShowLastValue { get; set; }
    public long? BulletTileShowLegendOnDashboard { get; set; }
    public long? GaugeTileAggregationType { get; set; }
    public long? AbsoluteRanges { get; set; }
    public string? ColorLimits { get; set; }
    public long? GaugeTileShowLegendOnDashboard { get; set; }
    public long? AggregationType { get; set; }
    public long? SortMode { get; set; }
    public long? CategoryLimit { get; set; }
    public long? ShowOthersCategory { get; set; }
    public long? ShowLegendOnDashboard { get; set; }
    public string? ValueColors { get; set; }
    public long? RowLimit { get; set; }
    public long? DownloadableDat { get; set; }
    public long? DownloadablePdf { get; set; }
    public long? DownloadableHdq { get; set; }
    public long? DirectPrint { get; set; }
    public long? UniformFont { get; set; }
    public string? CheckboxPosition { get; set; }
    public long? ScatterTileShowLegendOnDashboard { get; set; }
    public long? ShowInSequentialOrder { get; set; }

    public virtual NewFolderItem Dashboard { get; set; } = null!;
    public virtual ICollection<NewAxis> NewAxisColorTiles { get; set; }
    public virtual ICollection<NewAxis> NewAxisXtiles { get; set; }
    public virtual ICollection<NewAxis> NewAxisYtiles { get; set; }
    public virtual ICollection<NewAxis> NewAxisZtiles { get; set; }
    public virtual ICollection<NewFilter> NewFilters { get; set; }
    public virtual ICollection<NewSignalGroupItem> NewSignalGroupItems { get; set; }
    public virtual ICollection<NewTileDatasource> NewTileDatasources { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalCategoryTiles { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalIdentTiles { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalOrderTiles { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalReferenceTiles { get; set; }
    public virtual ICollection<NewTileSignal> NewTileSignalSelectedTiles { get; set; }
}
