using Microsoft.EntityFrameworkCore.Migrations;
using PlasticisingTile.Core.Entities.ConfigurationData;

#nullable disable

namespace PlasticisingTile.Infrastructure.Migrations;

public partial class PlasticisingTileDatasourceData : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "DatasourceConnections",
            columns: new[]
            {
                nameof(DatasourceConnection.Id),
                nameof(DatasourceConnection.IntegratedSecurity),
                nameof(DatasourceConnection.Method),
                nameof(DatasourceConnection.Name),
                nameof(DatasourceConnection.Port),
                nameof(DatasourceConnection.Realm),
                nameof(DatasourceConnection.Type)
            },
            values: new object[]
            {
                0,
                1,
                "Manual",
                "DatabaseForPlasticisingTile",
                0,
                "data/historical-data.db",
                "Sqlite",
            }
        );

        migrationBuilder.InsertData(
            table: "Datasources",
            columns: new[] 
            { 
                nameof(Datasource.Id), 
                nameof(Datasource.ConnectionId),
                nameof(Datasource.DatPathReplace),
                nameof(Datasource.Name),
                nameof(Datasource.PdfPathFrom),
                nameof(Datasource.PdfPathReplace),
                nameof(Datasource.SegmentDataAvailable),
                nameof(Datasource.TableOrStoreName),
                nameof(Datasource.TimestampColumnName),
                nameof(Datasource.Type),
                nameof(Datasource.DownloadableCsvPaths),
                nameof(Datasource.DownloadableParquetPaths),
                nameof(Datasource.DownloadablePdfPaths),
                nameof(Datasource.DownloadableZipPaths),
                nameof(Datasource.DisplayOnlyFileNames),
                nameof(Datasource.LogUserUpdates),
                nameof(Datasource.Guid)
            },
            values: new object[] 
            { 
                0, 
                0, 
                0, 
                "ViewForPlasticisingTile", 
                "M1-6" , 
                0, 
                0, 
                "M1-6_Comapre_v", 
                "_TimeStamp", 
                "Default",
                0,
                0,
                0,
                0,
                0,
                0,
                "1fcb4274-01cd-4d15-bbc3-397d9991d05e",
            }
        );

        migrationBuilder.InsertData(
            table: "DatasourceColumns",
            columns: new[]
            {
                nameof(DatasourceColumn.Id),
                nameof(DatasourceColumn.AccessLevel),
                nameof(DatasourceColumn.DatasourceId),
                nameof(DatasourceColumn.Key),
            },
            values: new object[,]
            {
                { 0, 1, 0, "_TimeStamp" },
                { 1, 1, 0, "cx300_Plasticising_Linearity" },
                { 2, 1, 0, "px050_Plasticising_Linearity" },
                { 3, 1, 0, "px120_Plasticising_Linearity" },
                { 4, 1, 0, "px160_Plasticising_Linearity" },
                { 5, 1, 0, "px200_Plasticising_Linearity" },
                { 6, 1, 0, "px080_Plasticising_Linearity" }
            }
        );
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 0);
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 1);
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 2);
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 3);
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 4);
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 5);
        migrationBuilder.DeleteData("DatasourceColumns", "Id", 6);

        migrationBuilder.DeleteData("Datasources", "Id", 0);

        migrationBuilder.DeleteData("DatasourceConnections", "Id", 0);
    }
}
