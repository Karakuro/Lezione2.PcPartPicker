namespace Lezione2.PcPartPicker.Data
{
    public class Chipset()
    {
        public required string Code { get; set; }
        public required CpuProducer Producer { get; set; }
        public List<CPU>? CPUs { get; set; }
        public List<Motherboard>? Motherboards { get; set; }
    }
    public enum CpuProducer
    {
        AMD,
        Intel
    }
}
