using CommonTypes.Common;
using CommonTypes.Enums;

namespace CommonTypes.Items.Weapon
{
    public interface IWeapon:IStored
    {
        string Name { get; set; }
        WeaponType Type { get; set; }
        ulong Price { get; set; }
        IDices BaseDamage { get; set; }
        DamageType DamageType { get; set; }
        byte Weight { get; set; }

        bool Ammunition { get; set; }
        byte MinRange { get; set; }
        byte MaxRange { get; set; }

        bool Finesse { get; set; }
        bool Heavy { get; set; }
        bool Light { get; set; }
        bool Loading { get; set; }
        bool Reach { get; set; }
        bool Thrown { get; set; }
        bool TwoHanded { get; set; }
        bool Versatile { get; set; }
        
    }
    internal class Weapon: IWeapon
    {
        public Weapon(uint id)
        {
            Id = id;
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public WeaponType Type { get; set; }
        public ulong Price { get; set; }
        public IDices BaseDamage { get; set; }
        public DamageType DamageType { get; set; }
        public byte Weight { get; set; }
        public bool Ammunition { get; set; }
        public byte MinRange { get; set; }
        public byte MaxRange { get; set; }
        public bool Finesse { get; set; }
        public bool Heavy { get; set; }
        public bool Light { get; set; }
        public bool Loading { get; set; }
        public bool Reach { get; set; }
        public bool Thrown { get; set; }
        public bool TwoHanded { get; set; }
        public bool Versatile { get; set; }
    }
}
