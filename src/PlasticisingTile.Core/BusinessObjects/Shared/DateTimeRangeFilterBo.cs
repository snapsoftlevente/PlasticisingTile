using PlasticisingTile.Core.Interfaces.BusinessObjects;

namespace PlasticisingTile.Core.BusinessObjects.Shared;
public class DateTimeRangeFilterBo : IBusinessObject
{
    public DateTime? DateTimeFrom { get; set; }
    public DateTime? DateTimeTo { get; set; }
}
