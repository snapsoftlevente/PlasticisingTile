using AutoMapper;
using PlasticisingTile.API.DTO.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Plasticising;

namespace PlasticisingTile.API.Mapping;

public class PlasticisingTileConfigurationProfile : Profile
{
    public PlasticisingTileConfigurationProfile()
    {
        CreateMap<PlasticisingTileConfigurationBo, PlasticisingTileConfigurationDto>();
        CreateMap<PlasticisingTileConfigureRequestDto, PlasticisingTileConfigureRequestBo>();
    }
}
