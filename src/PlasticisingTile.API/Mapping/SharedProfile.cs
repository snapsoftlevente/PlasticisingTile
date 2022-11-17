using AutoMapper;
using PlasticisingTile.API.DTO.Shared;
using PlasticisingTile.Core.BusinessObjects;

namespace PlasticisingTile.API.Mapping;

public class SharedProfile : Profile
{
    public SharedProfile()
    {
        CreateMap<DateTimeRangeFilterBo, DateTimeRangeFilterDto>()
            .ReverseMap();

        CreateMap<DatasourceColumnBo, DatasourceColumnDto>()
            .ReverseMap();
    }
}
