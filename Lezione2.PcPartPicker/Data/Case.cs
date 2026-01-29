namespace Lezione2.PcPartPicker.Data
{
    public class Case
    {
        public required string Code { get; set; }
        public required List<MBFormFactor> CompatibleMBFormFactors { get; set; }
    }
}
