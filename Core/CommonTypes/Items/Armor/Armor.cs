using CommonTypes.Common;
using CommonTypes.Enums;

namespace CommonTypes.Items.Armor
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

    internal class Armor : IArmor
    {
        public Armor(uint id)
        {
            Id = id;
        }

        public string Name { get; set; }
        public ArmorType Type { get; set; }
        public ulong Price { get; set; }
        public byte BaseArmor { get; set; }
        public byte MaxAgility { get; set; }
        public byte StrengthCap { get; set; }
        public bool StealthDisadvantage { get; set; }
        public byte Weight { get; set; }
        public uint Id { get; set; }
    }
}