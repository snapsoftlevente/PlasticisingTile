﻿using AutoMapper;
using PlasticisingTile.Core.BusinessObjects;

namespace PlasticisingTile.Core.Mapping;
public class PlasticisingTileConfigurationProfile : Profile
{
    public PlasticisingTileConfigurationProfile()
    {
        CreateMap<DatasourceBo, PlasticisingTileConfigurationBo>()
            .ForMember(dest => dest.AvailableColumns, opt => opt.MapFrom(src => src.DatasourceColumns));
    }
}