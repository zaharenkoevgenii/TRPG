using System.Collections.Generic;

namespace Library.GUI.WPF.Items.Armors
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