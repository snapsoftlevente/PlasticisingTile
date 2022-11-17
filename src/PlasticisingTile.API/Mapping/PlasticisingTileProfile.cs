using AutoMapper;
using PlasticisingTile.API.DTO.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Plasticising;

namespace PlasticisingTile.API.Mapping;

public class PlasticisingTileProfile : Profile
{
    public PlasticisingTileProfile()
    {
        CreateMap<PlasticisingTileBo, PlasticisingTileDto>();
        CreateMap<PlasticisingSerieBo, PlasticisingSerieDto>();
    }
}
