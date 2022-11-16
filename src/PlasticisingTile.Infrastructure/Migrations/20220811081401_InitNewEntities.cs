using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticisingTile.Infrastructure.Migrations;

public partial class InitNewEntities : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "AspNetRoles",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                Description = table.Column<string>(type: "TEXT", nullable: true),
                DisplayName = table.Column<string>(type: "TEXT", nullable: true),
                Domain = table.Column<string>(type: "TEXT", nullable: true),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                NormalizedName = table.Column<string>(type: "TEXT", nullable: true),
                Sid = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUsers",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                AccessFailedCount = table.Column<long>(type: "INTEGER", nullable: false),
                ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                DisplayName = table.Column<string>(type: "TEXT", nullable: true),
                Domain = table.Column<string>(type: "TEXT", nullable: true),
                Email = table.Column<string>(type: "TEXT", nullable: true),
                EmailConfirmed = table.Column<long>(type: "INTEGER", nullable: false),
                LockoutEnabled = table.Column<long>(type: "INTEGER", nullable: false),
                LockoutEnd = table.Column<string>(type: "TEXT", nullable: true),
                NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                PhoneNumberConfirmed = table.Column<long>(type: "INTEGER", nullable: false),
                SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                Sid = table.Column<string>(type: "TEXT", nullable: true),
                TwoFactorEnabled = table.Column<long>(type: "INTEGER", nullable: false),
                UserName = table.Column<string>(type: "TEXT", nullable: true),
                Language = table.Column<string>(type: "TEXT", nullable: false, defaultValueSql: "'Auto'"),
                UnitSystem = table.Column<string>(type: "TEXT", nullable: false, defaultValueSql: "'SI'"),
                DataEncoderOptions = table.Column<string>(type: "TEXT", nullable: true),
                Timezone = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Colors",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                ColorCode = table.Column<string>(type: "TEXT", nullable: true),
                DefaultColor = table.Column<long>(type: "INTEGER", nullable: false),
                Deletable = table.Column<long>(type: "INTEGER", nullable: false),
                ParentId = table.Column<long>(type: "INTEGER", nullable: true),
                Position = table.Column<long>(type: "INTEGER", nullable: false),
                PositionedId = table.Column<long>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Colors", x => x.Id);
                table.ForeignKey(
                    name: "FK_Colors_Colors_ParentId",
                    column: x => x.ParentId,
                    principalTable: "Colors",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "DatasourceConnections",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Host = table.Column<string>(type: "TEXT", nullable: true),
                IntegratedSecurity = table.Column<long>(type: "INTEGER", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                Password = table.Column<string>(type: "TEXT", nullable: true),
                Port = table.Column<long>(type: "INTEGER", nullable: false),
                Realm = table.Column<string>(type: "TEXT", nullable: true),
                Type = table.Column<string>(type: "TEXT", nullable: false),
                User = table.Column<string>(type: "TEXT", nullable: true),
                ConnectionString = table.Column<string>(type: "TEXT", nullable: true),
                Method = table.Column<string>(type: "TEXT", nullable: false, defaultValueSql: "'Manual'"),
                TlsCertificate = table.Column<string>(type: "TEXT", nullable: true),
                HdServicePort = table.Column<long>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DatasourceConnections", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Folders",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                ParentId = table.Column<long>(type: "INTEGER", nullable: true),
                ImagePath = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Folders", x => x.Id);
                table.ForeignKey(
                    name: "FK_Folders_Folders_ParentId",
                    column: x => x.ParentId,
                    principalTable: "Folders",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewDatasources",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                DatasourceDiscriminator = table.Column<long>(type: "INTEGER", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                ParentId = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewDatasources", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewDatasources_NewDatasources_ParentId",
                    column: x => x.ParentId,
                    principalTable: "NewDatasources",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewFolderItems",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                FolderItemDiscriminator = table.Column<long>(type: "INTEGER", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                ImagePath = table.Column<string>(type: "TEXT", nullable: true),
                DerivedImagePath = table.Column<string>(type: "TEXT", nullable: true),
                IsSharedClone = table.Column<long>(type: "INTEGER", nullable: true),
                CreatedAt = table.Column<string>(type: "TEXT", nullable: true),
                OriginalId = table.Column<string>(type: "TEXT", nullable: true),
                EventArray = table.Column<string>(type: "TEXT", nullable: true),
                TimestampArray = table.Column<string>(type: "TEXT", nullable: true),
                Access = table.Column<long>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewFolderItems", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AspNetRoleClaims",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                ClaimValue = table.Column<string>(type: "TEXT", nullable: true),
                Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                RoleId = table.Column<long>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "AspNetRoles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserClaims",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                ClaimValue = table.Column<string>(type: "TEXT", nullable: true),
                Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                UserId = table.Column<long>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserLogins",
            columns: table => new
            {
                LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                UserId = table.Column<long>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                table.ForeignKey(
                    name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserRoles",
            columns: table => new
            {
                UserId = table.Column<long>(type: "INTEGER", nullable: false),
                RoleId = table.Column<long>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "AspNetRoles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserTokens",
            columns: table => new
            {
                UserId = table.Column<long>(type: "INTEGER", nullable: false),
                LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                Value = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                table.ForeignKey(
                    name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Datasources",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                ChannelHeader = table.Column<string>(type: "TEXT", nullable: true),
                ConnectionId = table.Column<long>(type: "INTEGER", nullable: false),
                DatPassword = table.Column<string>(type: "TEXT", nullable: true),
                DatPathFrom = table.Column<string>(type: "TEXT", nullable: true),
                DatPathReplace = table.Column<long>(type: "INTEGER", nullable: false),
                DatPathTo = table.Column<string>(type: "TEXT", nullable: true),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                PdfPathFrom = table.Column<string>(type: "TEXT", nullable: true),
                PdfPathReplace = table.Column<long>(type: "INTEGER", nullable: false),
                PdfPathTo = table.Column<string>(type: "TEXT", nullable: true),
                ReferenceDatasourceId = table.Column<long>(type: "INTEGER", nullable: true),
                ReferenceIdentColumnKey = table.Column<string>(type: "TEXT", nullable: true),
                ReferenceLevel = table.Column<long>(type: "INTEGER", nullable: true),
                ReferenceReadingMode = table.Column<string>(type: "TEXT", nullable: true),
                SegmentDataAvailable = table.Column<long>(type: "INTEGER", nullable: false),
                Segments = table.Column<string>(type: "TEXT", nullable: true),
                TableOrStoreName = table.Column<string>(type: "TEXT", nullable: true),
                TimestampColumnName = table.Column<string>(type: "TEXT", nullable: true),
                Type = table.Column<string>(type: "TEXT", nullable: false),
                Timezone = table.Column<string>(type: "TEXT", nullable: true),
                DownloadableCsvPaths = table.Column<long>(type: "INTEGER", nullable: false),
                DownloadableParquetPaths = table.Column<long>(type: "INTEGER", nullable: false),
                DownloadablePdfPaths = table.Column<long>(type: "INTEGER", nullable: false),
                DisplayOnlyFileNames = table.Column<long>(type: "INTEGER", nullable: false),
                LogTOMColumn = table.Column<string>(type: "TEXT", nullable: true),
                LogUOMColumn = table.Column<string>(type: "TEXT", nullable: true),
                LogUserUpdates = table.Column<long>(type: "INTEGER", nullable: false),
                DownloadableZipPaths = table.Column<long>(type: "INTEGER", nullable: false),
                Guid = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Datasources", x => x.Id);
                table.ForeignKey(
                    name: "FK_Datasources_DatasourceConnections_ConnectionId",
                    column: x => x.ConnectionId,
                    principalTable: "DatasourceConnections",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Datasources_Datasources_ReferenceDatasourceId",
                    column: x => x.ReferenceDatasourceId,
                    principalTable: "Datasources",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.SetNull);
            });

        migrationBuilder.CreateTable(
            name: "Dashboards",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                ParentId = table.Column<long>(type: "INTEGER", nullable: true),
                WorkShiftId = table.Column<long>(type: "INTEGER", nullable: true),
                ImagePath = table.Column<string>(type: "TEXT", nullable: true),
                CreatedAt = table.Column<string>(type: "TEXT", nullable: false, defaultValueSql: "'0001-01-01 00:00:00'"),
                EventArray = table.Column<string>(type: "TEXT", nullable: true),
                IsSharedClone = table.Column<long>(type: "INTEGER", nullable: false),
                OriginalId = table.Column<long>(type: "INTEGER", nullable: false),
                TimestampArray = table.Column<string>(type: "TEXT", nullable: true),
                Guid = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Dashboards", x => x.Id);
                table.ForeignKey(
                    name: "FK_Dashboards_Folders_ParentId",
                    column: x => x.ParentId,
                    principalTable: "Folders",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewTiles",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                TileDiscriminator = table.Column<long>(type: "INTEGER", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                X = table.Column<long>(type: "INTEGER", nullable: false),
                Y = table.Column<long>(type: "INTEGER", nullable: false),
                W = table.Column<long>(type: "INTEGER", nullable: false),
                H = table.Column<long>(type: "INTEGER", nullable: false),
                DashboardId = table.Column<string>(type: "TEXT", nullable: false),
                XType = table.Column<long>(type: "INTEGER", nullable: false),
                CursorLimit = table.Column<long>(type: "INTEGER", nullable: false),
                BarTile_AggregationType = table.Column<long>(type: "INTEGER", nullable: true),
                BarTile_SortMode = table.Column<long>(type: "INTEGER", nullable: true),
                PercentageMode = table.Column<long>(type: "INTEGER", nullable: true),
                StackedMode = table.Column<long>(type: "INTEGER", nullable: true),
                BarTile_CategoryLimit = table.Column<long>(type: "INTEGER", nullable: true),
                BarTile_ShowOthersCategory = table.Column<long>(type: "INTEGER", nullable: true),
                BarTile_ShowLegendOnDashboard = table.Column<long>(type: "INTEGER", nullable: true),
                ShowLastValue = table.Column<long>(type: "INTEGER", nullable: true),
                BulletTile_ShowLegendOnDashboard = table.Column<long>(type: "INTEGER", nullable: true),
                GaugeTile_AggregationType = table.Column<long>(type: "INTEGER", nullable: true),
                AbsoluteRanges = table.Column<long>(type: "INTEGER", nullable: true),
                ColorLimits = table.Column<string>(type: "TEXT", nullable: true),
                GaugeTile_ShowLegendOnDashboard = table.Column<long>(type: "INTEGER", nullable: true),
                AggregationType = table.Column<long>(type: "INTEGER", nullable: true),
                SortMode = table.Column<long>(type: "INTEGER", nullable: true),
                CategoryLimit = table.Column<long>(type: "INTEGER", nullable: true),
                ShowOthersCategory = table.Column<long>(type: "INTEGER", nullable: true),
                ShowLegendOnDashboard = table.Column<long>(type: "INTEGER", nullable: true),
                ValueColors = table.Column<string>(type: "TEXT", nullable: true),
                RowLimit = table.Column<long>(type: "INTEGER", nullable: true),
                DownloadableDat = table.Column<long>(type: "INTEGER", nullable: true),
                DownloadablePdf = table.Column<long>(type: "INTEGER", nullable: true),
                DownloadableHdq = table.Column<long>(type: "INTEGER", nullable: true),
                DirectPrint = table.Column<long>(type: "INTEGER", nullable: true),
                UniformFont = table.Column<long>(type: "INTEGER", nullable: true),
                CheckboxPosition = table.Column<string>(type: "TEXT", nullable: true),
                ScatterTile_ShowLegendOnDashboard = table.Column<long>(type: "INTEGER", nullable: true),
                ShowInSequentialOrder = table.Column<long>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewTiles", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewTiles_NewFolderItems_DashboardId",
                    column: x => x.DashboardId,
                    principalTable: "NewFolderItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "DatasourceColumns",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                AccessLevel = table.Column<long>(type: "INTEGER", nullable: false),
                ColorCode = table.Column<string>(type: "TEXT", nullable: true),
                ColorId = table.Column<long>(type: "INTEGER", nullable: true),
                DatasourceDataLevel = table.Column<long>(type: "INTEGER", nullable: true),
                DatasourceId = table.Column<long>(type: "INTEGER", nullable: false),
                DatasourceReadingMode = table.Column<long>(type: "INTEGER", nullable: true),
                DecimalPlaces = table.Column<long>(type: "INTEGER", nullable: true),
                Key = table.Column<string>(type: "TEXT", nullable: true),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                Unit = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DatasourceColumns", x => x.Id);
                table.ForeignKey(
                    name: "FK_DatasourceColumns_Datasources_DatasourceId",
                    column: x => x.DatasourceId,
                    principalTable: "Datasources",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Filters",
            columns: table => new
            {
                Id = table.Column<long>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                ActiveMarks = table.Column<string>(type: "TEXT", nullable: true),
                BoolValue = table.Column<long>(type: "INTEGER", nullable: true),
                DashboardId = table.Column<long>(type: "INTEGER", nullable: true),
                DatasourceId = table.Column<long>(type: "INTEGER", nullable: true),
                EndEventId = table.Column<long>(type: "INTEGER", nullable: true),
                FileCount = table.Column<long>(type: "INTEGER", nullable: true),
                IsRelative = table.Column<long>(type: "INTEGER", nullable: false),
                Key = table.Column<string>(type: "TEXT", nullable: true),
                LeftInclusive = table.Column<string>(type: "TEXT", nullable: true),
                Name = table.Column<string>(type: "TEXT", nullable: true),
                NumEnd = table.Column<double>(type: "REAL", nullable: true),
                NumMultiEnd = table.Column<string>(type: "TEXT", nullable: true),
                NumMultiStart = table.Column<string>(type: "TEXT", nullable: true),
                NumStart = table.Column<double>(type: "REAL", nullable: true),
                Operator = table.Column<string>(type: "TEXT", nullable: false),
                ParentId = table.Column<long>(type: "INTEGER", nullable: true),
                ReferenceData = table.Column<string>(type: "TEXT", nullable: true),
                RelativeDate = table.Column<string>(type: "TEXT", nullable: true),
                RightInclusive = table.Column<string>(type: "TEXT", nullable: true),
                StartEventId = table.Column<long>(type: "INTEGER", nullable: true),
                StrValues = table.Column<string>(type: "TEXT", nullable: true),
                Text = table.Column<string>(type: "TEXT", nullable: true),
                TileId = table.Column<long>(type: "INTEGER", nullable: true),
                TimestampEnd = table.Column<long>(type: "INTEGER", nullable: true),
                TimestampStart = table.Column<long>(type: "INTEGER", nullable: true),
                WorkShiftEnd = table.Column<string>(type: "TEXT", nullable: true),
                WorkShiftStart = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Filters", x => x.Id);
                table.ForeignKey(
                    name: "FK_Filters_Dashboards_DashboardId",
                    column: x => x.DashboardId,
                    principalTable: "Dashboards",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Filters_Datasources_DatasourceId",
                    column: x => x.DatasourceId,
                    principalTable: "Datasources",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Filters_Filters_ParentId",
                    column: x => x.ParentId,
                    principalTable: "Filters",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewAxes",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                AutoScale = table.Column<long>(type: "INTEGER", nullable: false),
                AxisType = table.Column<long>(type: "INTEGER", nullable: false),
                ColorTileId = table.Column<string>(type: "TEXT", nullable: true),
                DataType = table.Column<long>(type: "INTEGER", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                Position = table.Column<long>(type: "INTEGER", nullable: false),
                Unit = table.Column<string>(type: "TEXT", nullable: true),
                XTileId = table.Column<string>(type: "TEXT", nullable: true),
                YTileId = table.Column<string>(type: "TEXT", nullable: true),
                ZTileId = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewAxes", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewAxes_NewTiles_ColorTileId",
                    column: x => x.ColorTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewAxes_NewTiles_XTileId",
                    column: x => x.XTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewAxes_NewTiles_YTileId",
                    column: x => x.YTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewAxes_NewTiles_ZTileId",
                    column: x => x.ZTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewSignalGroupItems",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                Active = table.Column<long>(type: "INTEGER", nullable: true),
                Advanced = table.Column<long>(type: "INTEGER", nullable: true),
                Alias = table.Column<string>(type: "TEXT", nullable: true),
                BoolConstantSignal_Value = table.Column<long>(type: "INTEGER", nullable: true),
                ColorCode = table.Column<string>(type: "TEXT", nullable: true),
                ColorId = table.Column<string>(type: "TEXT", nullable: true),
                Comment1 = table.Column<string>(type: "TEXT", nullable: true),
                Comment2 = table.Column<string>(type: "TEXT", nullable: true),
                DataType = table.Column<long>(type: "INTEGER", nullable: true),
                DatasourceId = table.Column<string>(type: "TEXT", nullable: true),
                DecimalPlaces = table.Column<long>(type: "INTEGER", nullable: true),
                Expression = table.Column<string>(type: "TEXT", nullable: true),
                FunctionName = table.Column<string>(type: "TEXT", nullable: true),
                Hidden = table.Column<long>(type: "INTEGER", nullable: false),
                Key = table.Column<string>(type: "TEXT", nullable: true),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                Ordinal = table.Column<long>(type: "INTEGER", nullable: true),
                ParentId = table.Column<string>(type: "TEXT", nullable: true),
                SignalGroupItemDiscriminator = table.Column<long>(type: "INTEGER", nullable: false),
                SignalGroupType = table.Column<long>(type: "INTEGER", nullable: true),
                Signal_ParentId = table.Column<string>(type: "TEXT", nullable: true),
                StringConstantSignal_Value = table.Column<string>(type: "TEXT", nullable: true),
                System = table.Column<long>(type: "INTEGER", nullable: false),
                TileId = table.Column<string>(type: "TEXT", nullable: true),
                Unit = table.Column<string>(type: "TEXT", nullable: true),
                Updatable = table.Column<long>(type: "INTEGER", nullable: true),
                Value = table.Column<double>(type: "REAL", nullable: true),
                XType = table.Column<long>(type: "INTEGER", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewSignalGroupItems", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewSignalGroupItems_NewDatasources_DatasourceId",
                    column: x => x.DatasourceId,
                    principalTable: "NewDatasources",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewSignalGroupItems_NewSignalGroupItems_ParentId",
                    column: x => x.ParentId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewSignalGroupItems_NewSignalGroupItems_Signal_ParentId",
                    column: x => x.Signal_ParentId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewSignalGroupItems_NewTiles_TileId",
                    column: x => x.TileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewTileDatasources",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                TileId = table.Column<string>(type: "TEXT", nullable: false),
                DatasourceId = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewTileDatasources", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewTileDatasources_NewDatasources_DatasourceId",
                    column: x => x.DatasourceId,
                    principalTable: "NewDatasources",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewTileDatasources_NewTiles_TileId",
                    column: x => x.TileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewAxisSignals",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                MinAxisId = table.Column<string>(type: "TEXT", nullable: true),
                MaxAxisId = table.Column<string>(type: "TEXT", nullable: true),
                SignalId = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewAxisSignals", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewAxisSignals_NewAxes_MaxAxisId",
                    column: x => x.MaxAxisId,
                    principalTable: "NewAxes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewAxisSignals_NewAxes_MinAxisId",
                    column: x => x.MinAxisId,
                    principalTable: "NewAxes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewAxisSignals_NewSignalGroupItems_SignalId",
                    column: x => x.SignalId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewFilters",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                FilterDiscriminator = table.Column<long>(type: "INTEGER", nullable: false),
                DashboardId = table.Column<string>(type: "TEXT", nullable: true),
                TileId = table.Column<string>(type: "TEXT", nullable: true),
                SignalId = table.Column<string>(type: "TEXT", nullable: true),
                ParentId = table.Column<string>(type: "TEXT", nullable: true),
                Editable = table.Column<long>(type: "INTEGER", nullable: false),
                Active = table.Column<long>(type: "INTEGER", nullable: false),
                Text = table.Column<string>(type: "TEXT", nullable: true),
                EditableFilterDiscriminator = table.Column<long>(type: "INTEGER", nullable: true),
                Value = table.Column<long>(type: "INTEGER", nullable: true),
                Low = table.Column<string>(type: "TEXT", nullable: true),
                High = table.Column<string>(type: "TEXT", nullable: true),
                IncludeLow = table.Column<long>(type: "INTEGER", nullable: true),
                IncludeHigh = table.Column<long>(type: "INTEGER", nullable: true),
                StartTriggerSignalId = table.Column<string>(type: "TEXT", nullable: true),
                StartTriggerRisingEdge = table.Column<long>(type: "INTEGER", nullable: true),
                StopTriggerSignalId = table.Column<string>(type: "TEXT", nullable: true),
                StopriggerRisingEdge = table.Column<long>(type: "INTEGER", nullable: true),
                NumberBetweenFilter_Low = table.Column<double>(type: "REAL", nullable: true),
                NumberBetweenFilter_High = table.Column<double>(type: "REAL", nullable: true),
                NumberBetweenFilter_IncludeLow = table.Column<long>(type: "INTEGER", nullable: true),
                NumberBetweenFilter_IncludeHigh = table.Column<long>(type: "INTEGER", nullable: true),
                OrFilter_EditableFilterDiscriminator = table.Column<long>(type: "INTEGER", nullable: true),
                StringContainsFilter_Value = table.Column<string>(type: "TEXT", nullable: true),
                StringEqFilter_Value = table.Column<string>(type: "TEXT", nullable: true),
                WorkShiftFilter_Low = table.Column<string>(type: "TEXT", nullable: true),
                WorkShiftFilter_High = table.Column<string>(type: "TEXT", nullable: true),
                WorkShiftFilter_IncludeLow = table.Column<long>(type: "INTEGER", nullable: true),
                WorkShiftFilter_IncludeHigh = table.Column<long>(type: "INTEGER", nullable: true),
                XType = table.Column<long>(type: "INTEGER", nullable: true),
                XRangeFilter_Low = table.Column<long>(type: "INTEGER", nullable: true),
                XRangeFilter_High = table.Column<long>(type: "INTEGER", nullable: true),
                Global = table.Column<long>(type: "INTEGER", nullable: true),
                Relative = table.Column<long>(type: "INTEGER", nullable: true),
                RelativeDate = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewFilters", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewFilters_NewFilters_ParentId",
                    column: x => x.ParentId,
                    principalTable: "NewFilters",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewFilters_NewFolderItems_DashboardId",
                    column: x => x.DashboardId,
                    principalTable: "NewFolderItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewFilters_NewSignalGroupItems_SignalId",
                    column: x => x.SignalId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewFilters_NewSignalGroupItems_StartTriggerSignalId",
                    column: x => x.StartTriggerSignalId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_NewFilters_NewSignalGroupItems_StopTriggerSignalId",
                    column: x => x.StopTriggerSignalId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_NewFilters_NewTiles_TileId",
                    column: x => x.TileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewSignalGroupSignals",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                SignalGroupId = table.Column<string>(type: "TEXT", nullable: false),
                SignalId = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewSignalGroupSignals", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewSignalGroupSignals_NewSignalGroupItems_SignalGroupId",
                    column: x => x.SignalGroupId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewSignalGroupSignals_NewSignalGroupItems_SignalId",
                    column: x => x.SignalId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "NewTileSignals",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                AggregationType = table.Column<long>(type: "INTEGER", nullable: true),
                CategoryTileId = table.Column<string>(type: "TEXT", nullable: true),
                ColorAxisId = table.Column<string>(type: "TEXT", nullable: true),
                ColorCode = table.Column<string>(type: "TEXT", nullable: true),
                ColorId = table.Column<string>(type: "TEXT", nullable: true),
                Hidden = table.Column<long>(type: "INTEGER", nullable: false),
                IdentTileId = table.Column<string>(type: "TEXT", nullable: true),
                OrderDirection = table.Column<long>(type: "INTEGER", nullable: true),
                OrderTileId = table.Column<string>(type: "TEXT", nullable: true),
                Position = table.Column<long>(type: "INTEGER", nullable: true),
                ReferenceTileId = table.Column<string>(type: "TEXT", nullable: true),
                SelectedTileId = table.Column<string>(type: "TEXT", nullable: true),
                SignalId = table.Column<string>(type: "TEXT", nullable: false),
                XAxisId = table.Column<string>(type: "TEXT", nullable: true),
                YAxisId = table.Column<string>(type: "TEXT", nullable: true),
                ZAxisId = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NewTileSignals", x => x.Id);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewAxes_ColorAxisId",
                    column: x => x.ColorAxisId,
                    principalTable: "NewAxes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.SetNull);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewAxes_XAxisId",
                    column: x => x.XAxisId,
                    principalTable: "NewAxes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.SetNull);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewAxes_YAxisId",
                    column: x => x.YAxisId,
                    principalTable: "NewAxes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.SetNull);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewAxes_ZAxisId",
                    column: x => x.ZAxisId,
                    principalTable: "NewAxes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.SetNull);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewSignalGroupItems_SignalId",
                    column: x => x.SignalId,
                    principalTable: "NewSignalGroupItems",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewTiles_CategoryTileId",
                    column: x => x.CategoryTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewTiles_IdentTileId",
                    column: x => x.IdentTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewTiles_OrderTileId",
                    column: x => x.OrderTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewTiles_ReferenceTileId",
                    column: x => x.ReferenceTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_NewTileSignals_NewTiles_SelectedTileId",
                    column: x => x.SelectedTileId,
                    principalTable: "NewTiles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_AspNetRoleClaims_RoleId",
            table: "AspNetRoleClaims",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "RoleNameIndex",
            table: "AspNetRoles",
            column: "NormalizedName",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserClaims_UserId",
            table: "AspNetUserClaims",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserLogins_UserId",
            table: "AspNetUserLogins",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserRoles_RoleId",
            table: "AspNetUserRoles",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "EmailIndex",
            table: "AspNetUsers",
            column: "NormalizedEmail");

        migrationBuilder.CreateIndex(
            name: "UserNameIndex",
            table: "AspNetUsers",
            column: "NormalizedUserName",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Colors_ParentId",
            table: "Colors",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_Dashboards_ParentId",
            table: "Dashboards",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_DatasourceColumns_DatasourceId",
            table: "DatasourceColumns",
            column: "DatasourceId");

        migrationBuilder.CreateIndex(
            name: "IX_Datasources_ConnectionId",
            table: "Datasources",
            column: "ConnectionId");

        migrationBuilder.CreateIndex(
            name: "IX_Datasources_ReferenceDatasourceId",
            table: "Datasources",
            column: "ReferenceDatasourceId");

        migrationBuilder.CreateIndex(
            name: "IX_Filters_DashboardId",
            table: "Filters",
            column: "DashboardId");

        migrationBuilder.CreateIndex(
            name: "IX_Filters_DatasourceId",
            table: "Filters",
            column: "DatasourceId");

        migrationBuilder.CreateIndex(
            name: "IX_Filters_ParentId",
            table: "Filters",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_Folders_ParentId",
            table: "Folders",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxes_ColorTileId",
            table: "NewAxes",
            column: "ColorTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxes_XTileId",
            table: "NewAxes",
            column: "XTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxes_YTileId",
            table: "NewAxes",
            column: "YTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxes_ZTileId",
            table: "NewAxes",
            column: "ZTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxisSignals_MaxAxisId",
            table: "NewAxisSignals",
            column: "MaxAxisId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxisSignals_MinAxisId",
            table: "NewAxisSignals",
            column: "MinAxisId");

        migrationBuilder.CreateIndex(
            name: "IX_NewAxisSignals_SignalId",
            table: "NewAxisSignals",
            column: "SignalId");

        migrationBuilder.CreateIndex(
            name: "IX_NewDatasources_ParentId",
            table: "NewDatasources",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_NewFilters_DashboardId",
            table: "NewFilters",
            column: "DashboardId");

        migrationBuilder.CreateIndex(
            name: "IX_NewFilters_ParentId",
            table: "NewFilters",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_NewFilters_SignalId",
            table: "NewFilters",
            column: "SignalId");

        migrationBuilder.CreateIndex(
            name: "IX_NewFilters_StartTriggerSignalId",
            table: "NewFilters",
            column: "StartTriggerSignalId");

        migrationBuilder.CreateIndex(
            name: "IX_NewFilters_StopTriggerSignalId",
            table: "NewFilters",
            column: "StopTriggerSignalId");

        migrationBuilder.CreateIndex(
            name: "IX_NewFilters_TileId",
            table: "NewFilters",
            column: "TileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewSignalGroupItems_DatasourceId",
            table: "NewSignalGroupItems",
            column: "DatasourceId");

        migrationBuilder.CreateIndex(
            name: "IX_NewSignalGroupItems_ParentId",
            table: "NewSignalGroupItems",
            column: "ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_NewSignalGroupItems_Signal_ParentId",
            table: "NewSignalGroupItems",
            column: "Signal_ParentId");

        migrationBuilder.CreateIndex(
            name: "IX_NewSignalGroupItems_TileId",
            table: "NewSignalGroupItems",
            column: "TileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewSignalGroupSignals_SignalGroupId",
            table: "NewSignalGroupSignals",
            column: "SignalGroupId");

        migrationBuilder.CreateIndex(
            name: "IX_NewSignalGroupSignals_SignalId",
            table: "NewSignalGroupSignals",
            column: "SignalId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileDatasources_DatasourceId",
            table: "NewTileDatasources",
            column: "DatasourceId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileDatasources_TileId",
            table: "NewTileDatasources",
            column: "TileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTiles_DashboardId",
            table: "NewTiles",
            column: "DashboardId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_CategoryTileId",
            table: "NewTileSignals",
            column: "CategoryTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_ColorAxisId",
            table: "NewTileSignals",
            column: "ColorAxisId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_IdentTileId",
            table: "NewTileSignals",
            column: "IdentTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_OrderTileId",
            table: "NewTileSignals",
            column: "OrderTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_ReferenceTileId",
            table: "NewTileSignals",
            column: "ReferenceTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_SelectedTileId",
            table: "NewTileSignals",
            column: "SelectedTileId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_SignalId",
            table: "NewTileSignals",
            column: "SignalId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_XAxisId",
            table: "NewTileSignals",
            column: "XAxisId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_YAxisId",
            table: "NewTileSignals",
            column: "YAxisId");

        migrationBuilder.CreateIndex(
            name: "IX_NewTileSignals_ZAxisId",
            table: "NewTileSignals",
            column: "ZAxisId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AspNetRoleClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserLogins");

        migrationBuilder.DropTable(
            name: "AspNetUserRoles");

        migrationBuilder.DropTable(
            name: "AspNetUserTokens");

        migrationBuilder.DropTable(
            name: "Colors");

        migrationBuilder.DropTable(
            name: "DatasourceColumns");

        migrationBuilder.DropTable(
            name: "Filters");

        migrationBuilder.DropTable(
            name: "NewAxisSignals");

        migrationBuilder.DropTable(
            name: "NewFilters");

        migrationBuilder.DropTable(
            name: "NewSignalGroupSignals");

        migrationBuilder.DropTable(
            name: "NewTileDatasources");

        migrationBuilder.DropTable(
            name: "NewTileSignals");

        migrationBuilder.DropTable(
            name: "AspNetRoles");

        migrationBuilder.DropTable(
            name: "AspNetUsers");

        migrationBuilder.DropTable(
            name: "Dashboards");

        migrationBuilder.DropTable(
            name: "Datasources");

        migrationBuilder.DropTable(
            name: "NewAxes");

        migrationBuilder.DropTable(
            name: "NewSignalGroupItems");

        migrationBuilder.DropTable(
            name: "Folders");

        migrationBuilder.DropTable(
            name: "DatasourceConnections");

        migrationBuilder.DropTable(
            name: "NewDatasources");

        migrationBuilder.DropTable(
            name: "NewTiles");

        migrationBuilder.DropTable(
            name: "NewFolderItems");
    }
}
