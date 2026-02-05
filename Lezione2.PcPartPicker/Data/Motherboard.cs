using System.ComponentModel.DataAnnotations;

namespace Lezione2.PcPartPicker.Data
{
    public class Motherboard
    {
        [MinLength(3)]
        public required string Code { get; set; }
        public required Chipset ChipsetCompatibility { get; set; }
        [Range(1, 1024, ErrorMessage = "")]
        public required int RamSlots { get; set; }
        public required List<RamSpeed> SupportedRamSpeed { get; set; }
        [Range(1, 1024, ErrorMessage = "")]
        public required int MaxRamGB { get; set; }
        public required MBFormFactor FormFactor { get; set; }
    }

    public enum MBFormFactor
    {
        ATX,
        MicroATX,
        MiniATX,
        XL_ATX,
        ITX,
        ThinMiniITX,
        MiniITX
    }
}
