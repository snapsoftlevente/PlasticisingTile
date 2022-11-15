namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Px080DeFile
{
    public long FileId { get; set; }
    public DateTime TimeStamp { get; set; }
    public string? FileName { get; set; }
    public string? FileType { get; set; }
    public long? Complete { get; set; }
    public long? ErrorOnExtract { get; set; }
    public string? CycleNumber { get; set; }
    public string? MachineNumber { get; set; }
    public double? PlasticisingLinearity { get; set; }
    public double? InjectionTime { get; set; }
    public double? MaxInju1PrsAct { get; set; }
    public double? MinInju1PrsAct { get; set; }
    public double? MaxPeakValleyMoldHeatingTemp { get; set; }
    public double? MaxPeakValleyMoldHeatingZone { get; set; }
}
