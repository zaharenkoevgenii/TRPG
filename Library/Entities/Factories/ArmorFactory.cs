using Library.Entities.Items.Armors;

namespace Library.Entities.Factories
{
    public static class ArmorFactory
    {
        public static IArmor CreateArmor()
        {
            return new Armor();
        }
    }
}