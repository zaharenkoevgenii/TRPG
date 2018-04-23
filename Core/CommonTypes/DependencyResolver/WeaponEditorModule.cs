using CommonTypes.Common;
using CommonTypes.Items.Weapon;
using Ninject.Modules;

namespace CommonTypes.DependencyResolver
{
    internal class WeaponEditorModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IDices)).To(typeof(Dices));
            Bind(typeof(IWeapon)).To(typeof(Weapon));
        }
    }
}
