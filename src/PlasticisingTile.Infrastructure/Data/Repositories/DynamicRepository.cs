using System.Data;
using Dapper;
using PlasticisingTile.Core.Interfaces.Repository;
using PlasticisingTile.Core.Models.DynamicQuery;
using Serenity.Data;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public class DynamicRepository : IDynamicRepository
{
    protected readonly IDbConnection _wrappedConnection;

    public DynamicRepository(string realm)
    {
        // TODO: Sqlite connection construction is hard-wired now, should be database type independent
        var connection = new DefaultSqlConnections(new DefaultConnectionStrings(new ConnectionStringOptions()))
            .New($"Data Source={realm}", "Microsoft.Data.SQLite", SqliteDialect.Instance);
        _wrappedConnection = new WrappedConnection(connection, SqliteDialect.Instance);
    }

    // TODO: refactor method
    public async Task<IEnumerable<dynamic>> QueryAsync(DynamicQuery dynamicQuery)
    {
        // TODO: refactor as mapping (DynamicQuery => SqlQuery)
        var query = new SqlQuery()
            .From($"'{dynamicQuery.TableOrViewName}'");

        if (dynamicQuery.ProjectionAttributeKeys != null && dynamicQuery.ProjectionAttributeKeys.Any())
        {
            query = query
                .SelectMany(dynamicQuery.ProjectionAttributeKeys.ToArray());
        }

        // TODO: fix DateTime filtering
        if (dynamicQuery.Selections != null && dynamicQuery.Selections.Any())
        {
            BaseCriteria? criteria = null;
            var firstCriteria = true;

            foreach (var selection in dynamicQuery.Selections)
            {
                var leftOperand = new Criteria($"'{selection.SelectionAttributeKey}'");
                var rightOperand = new ValueCriteria($"'{selection.OperationValue}'");

                var newCriteria = selection.SelectionOperation switch
                {
                    SelectionOperationEnum.LessThan => leftOperand < rightOperand,
                    SelectionOperationEnum.LessThanOrEqual => leftOperand <= rightOperand,
                    SelectionOperationEnum.GreaterThan => leftOperand > rightOperand,
                    SelectionOperationEnum.GreaterThanOrEqual => leftOperand >= rightOperand,
                    _ => throw new NotImplementedException()
                };

                if (firstCriteria)
                {
                    criteria = newCriteria;
                    firstCriteria = false;
                }
                else
                {
                    criteria &= newCriteria;
                }
            }

            query = query
                .Where(criteria);
        }

        var queryString = query.ToString();
        var queryParams = query.Params;

        _wrappedConnection.EnsureOpen();
        var resultSet = await _wrappedConnection.QueryAsync(queryString, queryParams);

        return resultSet;
    }

    public void Dispose()
    {
        _wrappedConnection.Dispose();
    }
}
