namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Px200DeFile
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
    public double? InjectionTime { get; set; }
    public double? MaxInju1PrsAct { get; set; }
    public double? MinInju1PrsAct { get; set; }
    public double? CavityHeatTime1 { get; set; }
    public double? CavityHeatTime2 { get; set; }
    public double? CavityCoolingTime { get; set; }
    public double? CavityHeatingTime { get; set; }
}
