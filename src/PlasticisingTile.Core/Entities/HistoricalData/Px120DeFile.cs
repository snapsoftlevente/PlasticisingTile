namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Px120DeFile
{
    public long FileId { get; set; }
    public byte[] TimeStamp { get; set; } = null!;
    public string? FileName { get; set; }
    public string? FileType { get; set; }
    public long? Complete { get; set; }
    public long? ErrorOnExtract { get; set; }
    public string? CycleNumber { get; set; }
    public string? MachineNumber { get; set; }
    public double? PlasticisingLinearity { get; set; }
    public double? MaxInj1PrsAct { get; set; }
    public double? MaxInju1PrsAct { get; set; }
    public double? MinInju1PrsAct { get; set; }
    public double? InjectionTime { get; set; }
    public double? CoolingTime { get; set; }
    public double? OpeningClampTime { get; set; }
    public double? ClosingClampTime { get; set; }
    public double? PauseTime1 { get; set; }
    public double? PauseTime2 { get; set; }
    public double? PauseTime { get; set; }
    public double? SdInjectionTime { get; set; }
    public double? SdCoolingTime { get; set; }
    public double? SdOpeningClampTime { get; set; }
    public double? SdClosingClampTime { get; set; }
    public double? SdPauseTime { get; set; }
}
