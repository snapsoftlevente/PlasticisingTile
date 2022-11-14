namespace PlasticisingTile.API.DTO.Interfaces;

public interface ITileResponseDto<TSerie, TDataPoint> : IDto
    where TSerie : class, ISerieDto<TDataPoint>
{
    IEnumerable<TSerie> Series { get; }
}
