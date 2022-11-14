namespace PlasticisingTile.API.DTO.Interfaces;

public interface ISerieDto<TChartDataDto>
{
    string Name { get; }
    IEnumerable<TChartDataDto> DataPoints { get; }
}
