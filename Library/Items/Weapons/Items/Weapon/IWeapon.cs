using TRPG.Library.Core.Common;
using TRPG.Library.Core.Common.Interfaces;
using TRPG.Library.Items.Weapons.Enums;

namespace TRPG.Library.Items.Weapons.Items.Weapon
{
    public interface IWeapon : IStored
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
}