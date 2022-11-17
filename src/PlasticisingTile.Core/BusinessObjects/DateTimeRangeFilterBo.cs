namespace PlasticisingTile.Core.BusinessObjects;
public class DateTimeRangeFilterBo : IBusinessObject
{
    public DateTime? DateTimeFrom { get; set; }
    public DateTime? DateTimeTo { get; set; }
}
