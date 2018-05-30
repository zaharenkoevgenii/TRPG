using TRPG.Library.Core.Common.Interfaces;
using TRPG.Library.Items.Armors.Core.Enumerables;

namespace TRPG.Library.Items.Armors.Core.Types
{
    public interface IArmor : IStored
    {
        string Name { get; set; }
        ArmorType Type { get; set; }
        ulong Price { get; set; }
        byte BaseArmor { get; set; }
        byte MaxAgility { get; set; }
        byte StrengthCap { get; set; }
        bool StealthDisadvantage { get; set; }
        byte Weight { get; set; }
    }
}