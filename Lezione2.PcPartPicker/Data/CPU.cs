namespace Lezione2.PcPartPicker.Data
{
    public class CPU
    {
        public required string Code { get; set; }
        public required double Frequency { get; set; }
        public required int L1Cache { get; set; }
        public required int L2Cache { get; set; }
        public required int L3Cache { get; set; }
        public required int Cores { get; set; }
        public required int TDP { get; set; }
        public required Chipset Chipset { get; set; }
    }
}
