using AutoMapper;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.Mapping.Converters;
using PlasticisingTile.Core.Models.DynamicQuery;

namespace PlasticisingTile.Core.Mapping;
public class PlasticisingTileConfigurateRequestProfile : Profile
{
    public PlasticisingTileConfigurateRequestProfile()
    {
        CreateMap<PlasticisingTileConfigureRequestBo, DynamicQuery>()
            .ConvertUsing(new PlasticisingTileConfigureRequestConverter());
    }
}
