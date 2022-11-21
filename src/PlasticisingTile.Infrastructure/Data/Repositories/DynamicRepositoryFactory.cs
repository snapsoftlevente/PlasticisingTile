using AutoMapper;
using PlasticisingTile.Core.Interfaces.Repository;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public class DynamicRepositoryFactory : IDynamicRepositoryFactory
{
    private readonly IMapper _mapper;

    public DynamicRepositoryFactory(IMapper mapper)
    {
        _mapper = mapper;
    }

    public IDynamicRepository Create(string realm) => new DynamicRepository(realm, _mapper);
}
