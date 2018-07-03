namespace Library.GUI.WPF.Items.Armors
{
    /// <summary>
    ///     Interaction logic for WPFArmorEditor.xaml
    /// </summary>
    public partial class WPFArmorsViewer
    {
        public WPFArmorsViewer()
        {
            InitializeComponent();
            ArmorsListView.ItemsSource = new ArmorsViewerModel().Items;
        }
    }
}