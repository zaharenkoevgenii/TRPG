using TRPG.Library.Items.Armors.Core.Types;

namespace TRPG.Library.Items.Armors.Viewers
{
    public class ArmorsViewerItem
    {
        public ArmorsViewerItem(IArmor armor)
        {
            Name = armor.Name;
            Type = armor.Type.ToString();
            BaseArmor = armor.BaseArmor.ToString();
            Price = armor.Price.ToString();
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string BaseArmor { get; set; }
        public string Price { get; set; }
    }
}