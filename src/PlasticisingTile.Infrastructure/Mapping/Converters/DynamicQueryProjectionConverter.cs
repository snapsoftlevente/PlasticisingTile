using AutoMapper;
using Serenity.Data;

namespace PlasticisingTile.Infrastructure.Mapping.Converters;
internal class DynamicQueryProjectionConverter : ITypeConverter<IEnumerable<string>, SqlQuery>
{
    public SqlQuery Convert(IEnumerable<string> projectionAttributeKeys, SqlQuery sqlQuery, ResolutionContext context)
    {
        sqlQuery ??= new SqlQuery();

        if (projectionAttributeKeys != null && projectionAttributeKeys.Any())
        {
            sqlQuery = sqlQuery
                .SelectMany(projectionAttributeKeys.ToArray());
        }

        return sqlQuery;
    }
}
