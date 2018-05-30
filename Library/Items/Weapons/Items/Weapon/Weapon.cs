using TRPG.Library.Core.Common;
using TRPG.Library.Items.Weapons.Enums;

namespace TRPG.Library.Items.Weapons.Items.Weapon
{
    internal class Weapon : IWeapon
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