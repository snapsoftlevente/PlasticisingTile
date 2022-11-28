using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Shared;

namespace PlasticisingTile.Core.Mapping;
public class PlasticisingTileConfigurationProfile : Profile
{
    public PlasticisingTileConfigurationProfile()
    {
        CreateMap<DatasourceBo, PlasticisingTileConfigurationBo>()
            .ForMember(
                dest => dest.AvailableColumns,
                opt => opt.MapFrom(src => src.DatasourceColumns.Where(dsc => !string.IsNullOrEmpty(dsc.Key) && !dsc.Key.Equals(src.TimestampColumnName))));
    }
}
