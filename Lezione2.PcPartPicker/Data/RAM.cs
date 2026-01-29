namespace Lezione2.PcPartPicker.Data
{
    public class RAM
    {
        public required string Code { get; set; }
        public required int SingleModuleGB { get; set; }
        public required int TotalModules { get; set; }
        public int TotalModulesGB { get => SingleModuleGB * TotalModules; }
        public required RamSpeed RamSpeed { get; set; }
    }

    public enum RamSpeed
    {
        DDR_333,
        DDR_400,
        DDR2_400,
        DDR2_533,
        DDR2_667,
        DDR2_800,
        DDR3_1066,
        DDR3_1333,
        DDR3_1600,
        DDR4_2400,
        DDR4_2666,
        DDR4_2933,
        DDR4_3200,
        DDR4_3600,
        DDR4_4000,
        DDR4_4400,
        DDR5_4800,
        DDR5_5600,
        DDR5_6000,
        DDR5_6400,
        DDR5_7500,
        DDR5_8500
    }
}
