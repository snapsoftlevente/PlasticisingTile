namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Px160DeFile
{
    public long FileId { get; set; }
    public DateTime TimeStamp { get; set; }
    public string? FileName { get; set; }
    public string? FileType { get; set; }
    public long? Complete { get; set; }
    public long? ErrorOnExtract { get; set; }
    public string? CycleNumber { get; set; }
    public string? MachineNumber { get; set; }
    public double? MaxInj1PrsAct { get; set; }
    public double? InjectionTime { get; set; }
    public double? MaxInju1PrsAct { get; set; }
    public double? MinInju1PrsAct { get; set; }
    public double? SwitchoverMeltPressure { get; set; }
    public double? SwitchoverStroke { get; set; }
    public double? ScrewPosPastHoldPrs { get; set; }
    public double? PlasticisingLinearity { get; set; }
}
