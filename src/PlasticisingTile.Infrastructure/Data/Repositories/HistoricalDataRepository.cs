using PlasticisingTile.Core.Interfaces.Entities;
using PlasticisingTile.Infrastructure.Data.DataContexts;

namespace PlasticisingTile.Infrastructure.Data.Repositories;
public class HistoricalDataRepository<T> : RepositoryBase<HistoricalDataContext, T> where T : class, IHistoricalDataEntity
{
    public HistoricalDataRepository(HistoricalDataContext context) 
            : base(context)
    {
    }
}
