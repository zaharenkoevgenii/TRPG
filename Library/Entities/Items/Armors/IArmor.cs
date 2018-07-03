using Library.Entities.Common.Storage;
using Library.Entities.Enumerables;

namespace Library.Entities.Items.Armors
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