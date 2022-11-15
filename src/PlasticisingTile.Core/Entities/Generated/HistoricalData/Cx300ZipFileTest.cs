namespace PlasticisingTile.Core.Entities.HistoricalData;

public partial class Cx300ZipFileTest
{
    public long? FileId { get; set; }
    public byte[]? TimeStamp { get; set; }
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
    public double? MeanHeatingRateZone1 { get; set; }
    public double? HeatingTime1 { get; set; }
    public double? HeatingTime2 { get; set; }
    public double? MeltingTemperature { get; set; }
    public double? MaximumMeltPressure { get; set; }
    public double? TransferTime1 { get; set; }
    public double? TransferTime2 { get; set; }
    public double? MeanHeatingRateZone11 { get; set; }
    public double? HeatingTime { get; set; }
    public double? TransferTime { get; set; }
    public double? MeltingTemperature1 { get; set; }
    public byte[]? FileNameZip { get; set; }
}
