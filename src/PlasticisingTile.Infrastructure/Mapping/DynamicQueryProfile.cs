using AutoMapper;
using PlasticisingTile.Core.Models.DynamicQuery;
using PlasticisingTile.Infrastructure.Mapping.Converters;
using Serenity.Data;

namespace PlasticisingTile.Infrastructure.Mapping;
public class DynamicQueryProfile : Profile
{
    public DynamicQueryProfile()
    {
        CreateMap<IEnumerable<string>, SqlQuery>()
            .ConvertUsing(new DynamicQueryProjectionConverter());

        CreateMap<IEnumerable<DynamicQuerySelection>, SqlQuery>()
            .ConvertUsing(new DynamicQuerySelectionConverter());

        CreateMap<DynamicQuery, SqlQuery>()
            .ConvertUsing(new DynamicQueryConverter());
    }
}
