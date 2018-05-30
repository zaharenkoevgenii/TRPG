using System.Collections.Generic;
using System.Linq;

namespace TRPG.Library.Items.Armors.Viewers
{
    public class ArmorsViewerModel
    {
        public ArmorsViewerModel()
        {
            var items = DataStorage.DataStorage.ReadItems();
            Items = items.Select(i => new ArmorsViewerItem(i)).ToList();
        }

        public List<ArmorsViewerItem> Items { get; set; }
    }
}