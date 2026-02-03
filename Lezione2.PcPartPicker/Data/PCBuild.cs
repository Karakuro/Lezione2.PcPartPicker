using System.Reflection.Metadata.Ecma335;

namespace Lezione2.PcPartPicker.Data
{
    public class PCBuild
    {
        public required Guid Id { get; set; } = Guid.NewGuid(); //<Guid("CE4291CA-8082-4683-B36C-782520628302")>
               
        //public CPU? CPU { get; set
        //    {
        //        if (IsCompatible(value))
        //            field = value;
        //    } 
        //}
        public CPU? CPU { get; set
            {
                if (IsCompatible(value))
                    field = value;
            } 
        }
        public CPUCooler? CPUCooler { get; private set; }
        public Motherboard? Motherboard { get; set
            {
                if (IsCompatible(value))
                    field = value;
            }
        }
        public RAM? RAM { get; private set; }
        public Case? Case { get; private set; }

        public bool IsCompatible(CPU? cpu)
        {
            return cpu == null || (CPUCooler == null || cpu?.Chipset == CPUCooler?.ChipsetCompatibility)
                && (Motherboard == null || cpu?.Chipset == Motherboard?.ChipsetCompatibility);
        }

        public bool IsCompatible(Motherboard? mb)
        {
            return mb == null || (CPUCooler == null || mb?.ChipsetCompatibility == CPUCooler?.ChipsetCompatibility)
                && (CPU == null || CPU?.Chipset == mb?.ChipsetCompatibility);
        }
    }
}
