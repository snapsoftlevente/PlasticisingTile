using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Shared;
using PlasticisingTile.Core.Entities.ConfigurationData;

namespace PlasticisingTile.Core.Mapping;
public class DatasourceProfile : Profile
{
    public DatasourceProfile()
    {
        CreateMap<Datasource, DatasourceBo>()
            .ForMember(dest => dest.Realm, opt => opt.MapFrom(src => src.Connection.Realm))
            .ForMember(dest => dest.DatasourceColumns, opt => opt.MapFrom(src => src.DatasourceColumns));

        CreateMap<DatasourceColumn, DatasourceColumnBo>();
    }
}
