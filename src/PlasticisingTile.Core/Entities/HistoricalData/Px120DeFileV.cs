namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Px120DeFileV
{
    public long? FileId { get; set; }
    public byte[]? TimeStamp { get; set; }
    public string? FileName { get; set; }
    public string? FileType { get; set; }
    public long? Complete { get; set; }
    public long? ErrorOnExtract { get; set; }
    public byte[]? CycleDateTime { get; set; }
    public string? CycleNumber { get; set; }
    public string? MachineNumber { get; set; }
    public double? PlasticisingLinearity { get; set; }
    public double? MaxInj1PrsAct { get; set; }
    public double? InjectionTime { get; set; }
    public double? MaxInju1PrsAct { get; set; }
    public double? MinInju1PrsAct { get; set; }
    public double? SdInjectionTime { get; set; }
    public double? SdCoolingTime { get; set; }
    public double? SdOpeningClampTime { get; set; }
    public double? SdClosingClampTime { get; set; }
    public double? SdPauseTime { get; set; }
}
