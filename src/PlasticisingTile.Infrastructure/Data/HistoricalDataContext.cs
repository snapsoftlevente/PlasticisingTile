using Microsoft.EntityFrameworkCore;
using PlasticisingTile.Core.Entities.HistoricalData;

namespace PlasticisingTile.Infrastructure.Data;

public partial class HistoricalDataContext : DbContext
{
    public HistoricalDataContext()
    {
    }

    public HistoricalDataContext(DbContextOptions<HistoricalDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cx300DeFile> Cx300DeFiles { get; set; } = null!;
    public virtual DbSet<Cx300DeFileV> Cx300DeFileVs { get; set; } = null!;
    public virtual DbSet<Cx300ZipFileTest> Cx300ZipFileTests { get; set; } = null!;
    public virtual DbSet<M16CompareV> M16CompareVs { get; set; } = null!;
    public virtual DbSet<Px050DeFile> Px050DeFiles { get; set; } = null!;
    public virtual DbSet<Px050DeFileV> Px050DeFileVs { get; set; } = null!;
    public virtual DbSet<Px080DeFile> Px080DeFiles { get; set; } = null!;
    public virtual DbSet<Px080DeFileV> Px080DeFileVs { get; set; } = null!;
    public virtual DbSet<Px120DeFile> Px120DeFiles { get; set; } = null!;
    public virtual DbSet<Px120DeFileV> Px120DeFileVs { get; set; } = null!;
    public virtual DbSet<Px160DeFile> Px160DeFiles { get; set; } = null!;
    public virtual DbSet<Px160DeFileV> Px160DeFileVs { get; set; } = null!;
    public virtual DbSet<Px200DeFile> Px200DeFiles { get; set; } = null!;
    public virtual DbSet<Px200DeFileV> Px200DeFileVs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cx300DeFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("CX300_deFile");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .ValueGeneratedNever()
                .HasColumnName("_FileId");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.HeatingTime).HasColumnName("Heating_time");

            entity.Property(e => e.HeatingTime1)
                .HasColumnType("real")
                .HasColumnName("Heating_time1");

            entity.Property(e => e.HeatingTime2)
                .HasColumnType("real")
                .HasColumnName("Heating_time2");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MaximumMeltPressure)
                .HasColumnType("real")
                .HasColumnName("Maximum_melt_pressure");

            entity.Property(e => e.MeanHeatingRateZone1)
                .HasColumnType("real")
                .HasColumnName("Mean_heating_rate_zone1");

            entity.Property(e => e.MeanHeatingRateZone11).HasColumnName("Mean_heating_rate_zone_1");

            entity.Property(e => e.MeltingTemperature)
                .HasColumnType("real")
                .HasColumnName("Melting_temperature");

            entity.Property(e => e.MeltingTemperature1).HasColumnName("Melting_temperature_1");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");

            entity.Property(e => e.TransferTime).HasColumnName("Transfer_time");

            entity.Property(e => e.TransferTime1)
                .HasColumnType("real")
                .HasColumnName("Transfer_time1");

            entity.Property(e => e.TransferTime2)
                .HasColumnType("real")
                .HasColumnName("Transfer_time2");
        });

        modelBuilder.Entity<Cx300DeFileV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CX300_deFile_v");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleDateTime).HasColumnName("Cycle_DateTime");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.HeatingTime).HasColumnName("Heating_time");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MeanHeatingRateZone1).HasColumnName("Mean_heating_rate_zone_1");

            entity.Property(e => e.MeltingTemperature1).HasColumnName("Melting_temperature_1");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");

            entity.Property(e => e.TransferTime).HasColumnName("Transfer_time");
        });

        modelBuilder.Entity<Cx300ZipFileTest>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("cx300_zipFileTest");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileNameZip).HasColumnName("_fileNameZip");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.HeatingTime).HasColumnName("Heating_time");

            entity.Property(e => e.HeatingTime1)
                .HasColumnType("real")
                .HasColumnName("Heating_time1");

            entity.Property(e => e.HeatingTime2)
                .HasColumnType("real")
                .HasColumnName("Heating_time2");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MaximumMeltPressure)
                .HasColumnType("real")
                .HasColumnName("Maximum_melt_pressure");

            entity.Property(e => e.MeanHeatingRateZone1)
                .HasColumnType("real")
                .HasColumnName("Mean_heating_rate_zone1");

            entity.Property(e => e.MeanHeatingRateZone11).HasColumnName("Mean_heating_rate_zone_1");

            entity.Property(e => e.MeltingTemperature)
                .HasColumnType("real")
                .HasColumnName("Melting_temperature");

            entity.Property(e => e.MeltingTemperature1).HasColumnName("Melting_temperature_1");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");

            entity.Property(e => e.TransferTime).HasColumnName("Transfer_time");

            entity.Property(e => e.TransferTime1)
                .HasColumnType("real")
                .HasColumnName("Transfer_time1");

            entity.Property(e => e.TransferTime2)
                .HasColumnType("real")
                .HasColumnName("Transfer_time2");
        });

        modelBuilder.Entity<M16CompareV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("M1-6_Compare_v");

            entity.Property(e => e.Cx300PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("cx300_Plasticising_Linearity");

            entity.Property(e => e.Px050PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("px050_Plasticising_Linearity");

            entity.Property(e => e.Px080PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("px080_Plasticising_Linearity");

            entity.Property(e => e.Px120PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("px120_Plasticising_Linearity");

            entity.Property(e => e.Px160PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("px160_Plasticising_Linearity");

            entity.Property(e => e.Px200PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("px200_Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px050DeFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("PX050_deFile");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .ValueGeneratedNever()
                .HasColumnName("_FileId");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.LsrValveLeak1)
                .HasColumnType("real")
                .HasColumnName("LSR_valve_leak1");

            entity.Property(e => e.LsrValveLeak2)
                .HasColumnType("real")
                .HasColumnName("LSR_valve_leak2");

            entity.Property(e => e.LsrValveLeakage).HasColumnName("LSR_valve_leakage");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.MoldOpenTime).HasColumnName("Mold_open_time");

            entity.Property(e => e.MoldOpenTime1)
                .HasColumnType("real")
                .HasColumnName("Mold_open_time1");

            entity.Property(e => e.MoldOpenTime2)
                .HasColumnType("real")
                .HasColumnName("Mold_open_time2");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px050DeFileV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PX050_deFile_v");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleDateTime).HasColumnName("Cycle_DateTime");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.LsrValveLeakage).HasColumnName("LSR_valve_leakage");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.MoldOpenTime).HasColumnName("Mold_open_time");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px080DeFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("PX080_deFile");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .ValueGeneratedNever()
                .HasColumnName("_FileId");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MaxPeakValleyMoldHeatingTemp)
                .HasColumnType("real")
                .HasColumnName("Max_Peak_valley_mold_heating_temp");

            entity.Property(e => e.MaxPeakValleyMoldHeatingZone)
                .HasColumnType("real")
                .HasColumnName("Max_Peak_Valley_mold_heating_Zone");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px080DeFileV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PX080_deFile_v");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleDateTime).HasColumnName("Cycle_DateTime");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MaxPeakValleyMoldHeatingTemp)
                .HasColumnType("real")
                .HasColumnName("Max_Peak_valley_mold_heating_temp");

            entity.Property(e => e.MaxPeakValleyMoldHeatingZone)
                .HasColumnType("real")
                .HasColumnName("Max_Peak_Valley_mold_heating_Zone");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px120DeFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("PX120_deFile");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .ValueGeneratedNever()
                .HasColumnName("_FileId");

            entity.Property(e => e.ClosingClampTime)
                .HasColumnType("real")
                .HasColumnName("Closing_clamp_time");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CoolingTime)
                .HasColumnType("real")
                .HasColumnName("Cooling_Time");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.OpeningClampTime)
                .HasColumnType("real")
                .HasColumnName("Opening_clamp_time");

            entity.Property(e => e.PauseTime).HasColumnName("Pause_Time");

            entity.Property(e => e.PauseTime1)
                .HasColumnType("real")
                .HasColumnName("Pause_Time1");

            entity.Property(e => e.PauseTime2)
                .HasColumnType("real")
                .HasColumnName("Pause_Time2");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.SdClosingClampTime).HasColumnName("SD_Closing_clamp_time");

            entity.Property(e => e.SdCoolingTime).HasColumnName("SD_Cooling_Time");

            entity.Property(e => e.SdInjectionTime).HasColumnName("SD_Injection_Time");

            entity.Property(e => e.SdOpeningClampTime).HasColumnName("SD_Opening_clamp_time");

            entity.Property(e => e.SdPauseTime).HasColumnName("SD_Pause_Time");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px120DeFileV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PX120_deFile_v");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleDateTime).HasColumnName("Cycle_DateTime");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.SdClosingClampTime).HasColumnName("SD_Closing_clamp_time");

            entity.Property(e => e.SdCoolingTime).HasColumnName("SD_Cooling_Time");

            entity.Property(e => e.SdInjectionTime).HasColumnName("SD_Injection_Time");

            entity.Property(e => e.SdOpeningClampTime).HasColumnName("SD_Opening_clamp_time");

            entity.Property(e => e.SdPauseTime).HasColumnName("SD_Pause_Time");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px160DeFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("PX160_deFile");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .ValueGeneratedNever()
                .HasColumnName("_FileId");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.ScrewPosPastHoldPrs)
                .HasColumnType("real")
                .HasColumnName("Screw_Pos_past_hold_Prs");

            entity.Property(e => e.SwitchoverMeltPressure)
                .HasColumnType("real")
                .HasColumnName("Switchover_melt_pressure");

            entity.Property(e => e.SwitchoverStroke)
                .HasColumnType("real")
                .HasColumnName("Switchover_stroke");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px160DeFileV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PX160_deFile_v");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleDateTime).HasColumnName("Cycle_DateTime");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.ScrewPosPastHoldPrs)
                .HasColumnType("real")
                .HasColumnName("Screw_Pos_past_hold_Prs");

            entity.Property(e => e.SwitchoverMeltPressure)
                .HasColumnType("real")
                .HasColumnName("Switchover_melt_pressure");

            entity.Property(e => e.SwitchoverStroke)
                .HasColumnType("real")
                .HasColumnName("Switchover_stroke");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px200DeFile>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.ToTable("PX200_deFile");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .ValueGeneratedNever()
                .HasColumnName("_FileId");

            entity.Property(e => e.CavityCoolingTime)
                .HasColumnType("real")
                .HasColumnName("Cavity_cooling_time");

            entity.Property(e => e.CavityHeatTime1)
                .HasColumnType("real")
                .HasColumnName("Cavity_Heat_Time1");

            entity.Property(e => e.CavityHeatTime2)
                .HasColumnType("real")
                .HasColumnName("Cavity_Heat_Time2");

            entity.Property(e => e.CavityHeatingTime).HasColumnName("Cavity_heating_time");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInj1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inj1PrsAct");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        modelBuilder.Entity<Px200DeFileV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PX200_deFile_v");

            entity.Property(e => e.CavityCoolingTime)
                .HasColumnType("real")
                .HasColumnName("Cavity_cooling_time");

            entity.Property(e => e.CavityHeatingTime).HasColumnName("Cavity_heating_time");

            entity.Property(e => e.Complete)
                .HasColumnType("int")
                .HasColumnName("_Complete");

            entity.Property(e => e.CycleDateTime).HasColumnName("Cycle_DateTime");

            entity.Property(e => e.CycleNumber)
                .HasColumnType("varchar (9)")
                .HasColumnName("Cycle_Number");

            entity.Property(e => e.ErrorOnExtract)
                .HasColumnType("int")
                .HasColumnName("_ErrorOnExtract");

            entity.Property(e => e.FileId)
                .HasColumnType("int")
                .HasColumnName("_FileId");

            entity.Property(e => e.FileName)
                .HasColumnType("varchar (255)")
                .HasColumnName("_FileName");

            entity.Property(e => e.FileType)
                .HasColumnType("char (8)")
                .HasColumnName("_FileType");

            entity.Property(e => e.InjectionTime)
                .HasColumnType("real")
                .HasColumnName("Injection_Time");

            entity.Property(e => e.MachineNumber)
                .HasColumnType("varchar (8)")
                .HasColumnName("Machine_Number");

            entity.Property(e => e.MaxInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Max_Inju1PrsAct");

            entity.Property(e => e.MinInju1PrsAct)
                .HasColumnType("real")
                .HasColumnName("Min_Inju1PrsAct");

            entity.Property(e => e.PlasticisingLinearity)
                .HasColumnType("real")
                .HasColumnName("Plasticising_Linearity");

            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("_TimeStamp");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
