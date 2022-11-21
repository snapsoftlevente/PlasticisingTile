using AutoMapper;
using PlasticisingTile.Core.Models.DynamicQuery;
using Serenity.Data;

namespace PlasticisingTile.Infrastructure.Mapping.Converters;
internal class DynamicQueryConverter : ITypeConverter<DynamicQuery, SqlQuery>
{
    public SqlQuery Convert(DynamicQuery dynamicQuery, SqlQuery sqlQuery, ResolutionContext context)
    {
        sqlQuery ??= new SqlQuery();

        sqlQuery
            .From($"'{dynamicQuery.TableOrViewName}'");

        context.Mapper.Map(dynamicQuery.ProjectionAttributeKeys, sqlQuery);
        context.Mapper.Map(dynamicQuery.Selections, sqlQuery);

        return sqlQuery;
    }
}
