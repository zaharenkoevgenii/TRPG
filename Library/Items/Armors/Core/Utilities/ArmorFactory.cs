using TRPG.Library.Items.Armors.Core.Types;

namespace TRPG.Library.Items.Armors.Core.Utilities
{
    internal static class ArmorFactory
    {
        internal static IArmor CreateArmor()
        {
            return new Armor();
        }

        internal static IArmor CreateArmor(uint id)
        {
            var armor = new Armor {Id = id};
            return armor;
        }
    }
}