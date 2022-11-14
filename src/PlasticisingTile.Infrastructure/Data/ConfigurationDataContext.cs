using Microsoft.EntityFrameworkCore;
using PlasticisingTile.Core.Entities.ConfigurationData;

namespace PlasticisingTile.Infrastructure.Data;

public partial class ConfigurationDataContext : DbContext
{
    public ConfigurationDataContext()
    {
    }

    public ConfigurationDataContext(DbContextOptions<ConfigurationDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
    public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
    public virtual DbSet<Color> Colors { get; set; } = null!;
    public virtual DbSet<Dashboard> Dashboards { get; set; } = null!;
    public virtual DbSet<Datasource> Datasources { get; set; } = null!;
    public virtual DbSet<DatasourceColumn> DatasourceColumns { get; set; } = null!;
    public virtual DbSet<DatasourceConnection> DatasourceConnections { get; set; } = null!;
    public virtual DbSet<Filter> Filters { get; set; } = null!;
    public virtual DbSet<Folder> Folders { get; set; } = null!;
    public virtual DbSet<NewAxis> NewAxes { get; set; } = null!;
    public virtual DbSet<NewAxisSignal> NewAxisSignals { get; set; } = null!;
    public virtual DbSet<NewDatasource> NewDatasources { get; set; } = null!;
    public virtual DbSet<NewFilter> NewFilters { get; set; } = null!;
    public virtual DbSet<NewFolderItem> NewFolderItems { get; set; } = null!;
    public virtual DbSet<NewSignalGroupItem> NewSignalGroupItems { get; set; } = null!;
    public virtual DbSet<NewSignalGroupSignal> NewSignalGroupSignals { get; set; } = null!;
    public virtual DbSet<NewTile> NewTiles { get; set; } = null!;
    public virtual DbSet<NewTileDatasource> NewTileDatasources { get; set; } = null!;
    public virtual DbSet<NewTileSignal> NewTileSignals { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique();
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.AspNetRoleClaims)
                .HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique();

            entity.Property(e => e.Language).HasDefaultValueSql("'Auto'");

            entity.Property(e => e.UnitSystem).HasDefaultValueSql("'SI'");

            entity.HasMany(d => d.Roles)
                .WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");

                        j.ToTable("AspNetUserRoles");

                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User)
                .WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User)
                .WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User)
                .WithMany(p => p.AspNetUserTokens)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_Colors_ParentId");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Dashboard>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_Dashboards_ParentId");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("'0001-01-01 00:00:00'");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.Dashboards)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Datasource>(entity =>
        {
            entity.HasIndex(e => e.ConnectionId, "IX_Datasources_ConnectionId");

            entity.HasIndex(e => e.ReferenceDatasourceId, "IX_Datasources_ReferenceDatasourceId");

            entity.Property(e => e.LogTomcolumn).HasColumnName("LogTOMColumn");

            entity.Property(e => e.LogUomcolumn).HasColumnName("LogUOMColumn");

            entity.HasOne(d => d.Connection)
                .WithMany(p => p.Datasources)
                .HasForeignKey(d => d.ConnectionId);

            entity.HasOne(d => d.ReferenceDatasource)
                .WithMany(p => p.InverseReferenceDatasource)
                .HasForeignKey(d => d.ReferenceDatasourceId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<DatasourceColumn>(entity =>
        {
            entity.HasIndex(e => e.DatasourceId, "IX_DatasourceColumns_DatasourceId");

            entity.HasOne(d => d.Datasource)
                .WithMany(p => p.DatasourceColumns)
                .HasForeignKey(d => d.DatasourceId);
        });

        modelBuilder.Entity<DatasourceConnection>(entity =>
        {
            entity.Property(e => e.Method).HasDefaultValueSql("'Manual'");
        });

        modelBuilder.Entity<Filter>(entity =>
        {
            entity.HasOne(d => d.Dashboard)
                .WithMany(p => p.Filters)
                .HasForeignKey(d => d.DashboardId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Datasource)
                .WithMany(p => p.Filters)
                .HasForeignKey(d => d.DatasourceId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_Folders_ParentId");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<NewAxis>(entity =>
        {
            entity.HasIndex(e => e.ColorTileId, "IX_NewAxes_ColorTileId");

            entity.HasIndex(e => e.XtileId, "IX_NewAxes_XTileId");

            entity.HasIndex(e => e.YtileId, "IX_NewAxes_YTileId");

            entity.HasIndex(e => e.ZtileId, "IX_NewAxes_ZTileId");

            entity.Property(e => e.XtileId).HasColumnName("XTileId");

            entity.Property(e => e.YtileId).HasColumnName("YTileId");

            entity.Property(e => e.ZtileId).HasColumnName("ZTileId");

            entity.HasOne(d => d.ColorTile)
                .WithMany(p => p.NewAxisColorTiles)
                .HasForeignKey(d => d.ColorTileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Xtile)
                .WithMany(p => p.NewAxisXtiles)
                .HasForeignKey(d => d.XtileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Ytile)
                .WithMany(p => p.NewAxisYtiles)
                .HasForeignKey(d => d.YtileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Ztile)
                .WithMany(p => p.NewAxisZtiles)
                .HasForeignKey(d => d.ZtileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<NewAxisSignal>(entity =>
        {
            entity.HasIndex(e => e.MaxAxisId, "IX_NewAxisSignals_MaxAxisId");

            entity.HasIndex(e => e.MinAxisId, "IX_NewAxisSignals_MinAxisId");

            entity.HasIndex(e => e.SignalId, "IX_NewAxisSignals_SignalId");

            entity.HasOne(d => d.MaxAxis)
                .WithMany(p => p.NewAxisSignalMaxAxes)
                .HasForeignKey(d => d.MaxAxisId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.MinAxis)
                .WithMany(p => p.NewAxisSignalMinAxes)
                .HasForeignKey(d => d.MinAxisId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Signal)
                .WithMany(p => p.NewAxisSignals)
                .HasForeignKey(d => d.SignalId);
        });

        modelBuilder.Entity<NewDatasource>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_NewDatasources_ParentId");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<NewFilter>(entity =>
        {
            entity.HasIndex(e => e.DashboardId, "IX_NewFilters_DashboardId");

            entity.HasIndex(e => e.ParentId, "IX_NewFilters_ParentId");

            entity.HasIndex(e => e.SignalId, "IX_NewFilters_SignalId");

            entity.HasIndex(e => e.StartTriggerSignalId, "IX_NewFilters_StartTriggerSignalId");

            entity.HasIndex(e => e.StopTriggerSignalId, "IX_NewFilters_StopTriggerSignalId");

            entity.HasIndex(e => e.TileId, "IX_NewFilters_TileId");

            entity.Property(e => e.NumberBetweenFilterHigh).HasColumnName("NumberBetweenFilter_High");

            entity.Property(e => e.NumberBetweenFilterIncludeHigh).HasColumnName("NumberBetweenFilter_IncludeHigh");

            entity.Property(e => e.NumberBetweenFilterIncludeLow).HasColumnName("NumberBetweenFilter_IncludeLow");

            entity.Property(e => e.NumberBetweenFilterLow).HasColumnName("NumberBetweenFilter_Low");

            entity.Property(e => e.OrFilterEditableFilterDiscriminator).HasColumnName("OrFilter_EditableFilterDiscriminator");

            entity.Property(e => e.StringContainsFilterValue).HasColumnName("StringContainsFilter_Value");

            entity.Property(e => e.StringEqFilterValue).HasColumnName("StringEqFilter_Value");

            entity.Property(e => e.WorkShiftFilterHigh).HasColumnName("WorkShiftFilter_High");

            entity.Property(e => e.WorkShiftFilterIncludeHigh).HasColumnName("WorkShiftFilter_IncludeHigh");

            entity.Property(e => e.WorkShiftFilterIncludeLow).HasColumnName("WorkShiftFilter_IncludeLow");

            entity.Property(e => e.WorkShiftFilterLow).HasColumnName("WorkShiftFilter_Low");

            entity.Property(e => e.XrangeFilterHigh).HasColumnName("XRangeFilter_High");

            entity.Property(e => e.XrangeFilterLow).HasColumnName("XRangeFilter_Low");

            entity.Property(e => e.Xtype).HasColumnName("XType");

            entity.HasOne(d => d.Dashboard)
                .WithMany(p => p.NewFilters)
                .HasForeignKey(d => d.DashboardId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Signal)
                .WithMany(p => p.NewFilterSignals)
                .HasForeignKey(d => d.SignalId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.StartTriggerSignal)
                .WithMany(p => p.NewFilterStartTriggerSignals)
                .HasForeignKey(d => d.StartTriggerSignalId);

            entity.HasOne(d => d.StopTriggerSignal)
                .WithMany(p => p.NewFilterStopTriggerSignals)
                .HasForeignKey(d => d.StopTriggerSignalId);

            entity.HasOne(d => d.Tile)
                .WithMany(p => p.NewFilters)
                .HasForeignKey(d => d.TileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<NewSignalGroupItem>(entity =>
        {
            entity.HasIndex(e => e.DatasourceId, "IX_NewSignalGroupItems_DatasourceId");

            entity.HasIndex(e => e.ParentId, "IX_NewSignalGroupItems_ParentId");

            entity.HasIndex(e => e.SignalParentId, "IX_NewSignalGroupItems_Signal_ParentId");

            entity.HasIndex(e => e.TileId, "IX_NewSignalGroupItems_TileId");

            entity.Property(e => e.BoolConstantSignalValue).HasColumnName("BoolConstantSignal_Value");

            entity.Property(e => e.SignalParentId).HasColumnName("Signal_ParentId");

            entity.Property(e => e.StringConstantSignalValue).HasColumnName("StringConstantSignal_Value");

            entity.Property(e => e.Xtype).HasColumnName("XType");

            entity.HasOne(d => d.Datasource)
                .WithMany(p => p.NewSignalGroupItems)
                .HasForeignKey(d => d.DatasourceId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.SignalParent)
                .WithMany(p => p.InverseSignalParent)
                .HasForeignKey(d => d.SignalParentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Tile)
                .WithMany(p => p.NewSignalGroupItems)
                .HasForeignKey(d => d.TileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<NewSignalGroupSignal>(entity =>
        {
            entity.HasIndex(e => e.SignalGroupId, "IX_NewSignalGroupSignals_SignalGroupId");

            entity.HasIndex(e => e.SignalId, "IX_NewSignalGroupSignals_SignalId");

            entity.HasOne(d => d.SignalGroup)
                .WithMany(p => p.NewSignalGroupSignalSignalGroups)
                .HasForeignKey(d => d.SignalGroupId);

            entity.HasOne(d => d.Signal)
                .WithMany(p => p.NewSignalGroupSignalSignals)
                .HasForeignKey(d => d.SignalId);
        });

        modelBuilder.Entity<NewTile>(entity =>
        {
            entity.HasIndex(e => e.DashboardId, "IX_NewTiles_DashboardId");

            entity.Property(e => e.BarTileAggregationType).HasColumnName("BarTile_AggregationType");

            entity.Property(e => e.BarTileCategoryLimit).HasColumnName("BarTile_CategoryLimit");

            entity.Property(e => e.BarTileShowLegendOnDashboard).HasColumnName("BarTile_ShowLegendOnDashboard");

            entity.Property(e => e.BarTileShowOthersCategory).HasColumnName("BarTile_ShowOthersCategory");

            entity.Property(e => e.BarTileSortMode).HasColumnName("BarTile_SortMode");

            entity.Property(e => e.BulletTileShowLegendOnDashboard).HasColumnName("BulletTile_ShowLegendOnDashboard");

            entity.Property(e => e.GaugeTileAggregationType).HasColumnName("GaugeTile_AggregationType");

            entity.Property(e => e.GaugeTileShowLegendOnDashboard).HasColumnName("GaugeTile_ShowLegendOnDashboard");

            entity.Property(e => e.ScatterTileShowLegendOnDashboard).HasColumnName("ScatterTile_ShowLegendOnDashboard");

            entity.Property(e => e.Xtype).HasColumnName("XType");

            entity.HasOne(d => d.Dashboard)
                .WithMany(p => p.NewTiles)
                .HasForeignKey(d => d.DashboardId);
        });

        modelBuilder.Entity<NewTileDatasource>(entity =>
        {
            entity.HasIndex(e => e.DatasourceId, "IX_NewTileDatasources_DatasourceId");

            entity.HasIndex(e => e.TileId, "IX_NewTileDatasources_TileId");

            entity.HasOne(d => d.Datasource)
                .WithMany(p => p.NewTileDatasources)
                .HasForeignKey(d => d.DatasourceId);

            entity.HasOne(d => d.Tile)
                .WithMany(p => p.NewTileDatasources)
                .HasForeignKey(d => d.TileId);
        });

        modelBuilder.Entity<NewTileSignal>(entity =>
        {
            entity.HasIndex(e => e.CategoryTileId, "IX_NewTileSignals_CategoryTileId");

            entity.HasIndex(e => e.ColorAxisId, "IX_NewTileSignals_ColorAxisId");

            entity.HasIndex(e => e.IdentTileId, "IX_NewTileSignals_IdentTileId");

            entity.HasIndex(e => e.OrderTileId, "IX_NewTileSignals_OrderTileId");

            entity.HasIndex(e => e.ReferenceTileId, "IX_NewTileSignals_ReferenceTileId");

            entity.HasIndex(e => e.SelectedTileId, "IX_NewTileSignals_SelectedTileId");

            entity.HasIndex(e => e.SignalId, "IX_NewTileSignals_SignalId");

            entity.HasIndex(e => e.XaxisId, "IX_NewTileSignals_XAxisId");

            entity.HasIndex(e => e.YaxisId, "IX_NewTileSignals_YAxisId");

            entity.HasIndex(e => e.ZaxisId, "IX_NewTileSignals_ZAxisId");

            entity.Property(e => e.XaxisId).HasColumnName("XAxisId");

            entity.Property(e => e.YaxisId).HasColumnName("YAxisId");

            entity.Property(e => e.ZaxisId).HasColumnName("ZAxisId");

            entity.HasOne(d => d.CategoryTile)
                .WithMany(p => p.NewTileSignalCategoryTiles)
                .HasForeignKey(d => d.CategoryTileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.ColorAxis)
                .WithMany(p => p.NewTileSignalColorAxes)
                .HasForeignKey(d => d.ColorAxisId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdentTile)
                .WithMany(p => p.NewTileSignalIdentTiles)
                .HasForeignKey(d => d.IdentTileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.OrderTile)
                .WithMany(p => p.NewTileSignalOrderTiles)
                .HasForeignKey(d => d.OrderTileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.ReferenceTile)
                .WithMany(p => p.NewTileSignalReferenceTiles)
                .HasForeignKey(d => d.ReferenceTileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.SelectedTile)
                .WithMany(p => p.NewTileSignalSelectedTiles)
                .HasForeignKey(d => d.SelectedTileId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Signal)
                .WithMany(p => p.NewTileSignals)
                .HasForeignKey(d => d.SignalId);

            entity.HasOne(d => d.Xaxis)
                .WithMany(p => p.NewTileSignalXaxes)
                .HasForeignKey(d => d.XaxisId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Yaxis)
                .WithMany(p => p.NewTileSignalYaxes)
                .HasForeignKey(d => d.YaxisId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Zaxis)
                .WithMany(p => p.NewTileSignalZaxes)
                .HasForeignKey(d => d.ZaxisId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
