using System.Data;
using AutoMapper;
using Dapper;
using PlasticisingTile.Core.Interfaces.Repository;
using PlasticisingTile.Core.Models.DynamicQuery;
using Serenity.Data;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public class DynamicRepository : IDynamicRepository
{
    private readonly IMapper _mapper;
    protected readonly IDbConnection _wrappedConnection;

    public DynamicRepository(string realm, IMapper mapper)
    {
        _mapper = mapper;

        // TODO: Sqlite connection construction is hard-wired now, should be database type independent
        var connection = new DefaultSqlConnections(new DefaultConnectionStrings(new ConnectionStringOptions()))
            .New($"Data Source={realm}", "Microsoft.Data.SQLite", SqliteDialect.Instance);
        _wrappedConnection = new WrappedConnection(connection, SqliteDialect.Instance);
    }

    public async Task<IEnumerable<dynamic>> QueryAsync(DynamicQuery dynamicQuery)
    {
        var sqlQuery = _mapper.Map<SqlQuery>(dynamicQuery);

        var queryString = sqlQuery.ToString();
        var queryParams = sqlQuery.Params;

        _wrappedConnection.EnsureOpen();
        var resultSet = await _wrappedConnection.QueryAsync(queryString, queryParams);

        return resultSet;
    }

    public void Dispose()
    {
        _wrappedConnection.Dispose();
    }
}
