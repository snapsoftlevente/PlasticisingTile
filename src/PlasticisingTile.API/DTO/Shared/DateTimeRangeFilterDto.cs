using PlasticisingTile.API.DTO.Interfaces;

namespace PlasticisingTile.API.DTO.Shared;

public class DateTimeRangeFilterDto : IDto
{
    public DateTime? DateTimeFrom { get; set; }
    public DateTime? DateTimeTo { get; set; }
}
