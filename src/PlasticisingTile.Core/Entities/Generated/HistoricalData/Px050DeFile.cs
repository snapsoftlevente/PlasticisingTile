namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Px050DeFile
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
    public double? MaxInj1PrsAct { get; set; }
    public double? InjectionTime { get; set; }
    public double? MaxInju1PrsAct { get; set; }
    public double? MinInju1PrsAct { get; set; }
    public double? LsrValveLeak1 { get; set; }
    public double? LsrValveLeak2 { get; set; }
    public double? MoldOpenTime1 { get; set; }
    public double? MoldOpenTime2 { get; set; }
    public double? LsrValveLeakage { get; set; }
    public double? MoldOpenTime { get; set; }
}
