using Library.Entities.Enumerables;

namespace Library.Entities.Items.Armors
{
    internal class Armor : IArmor
    {
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