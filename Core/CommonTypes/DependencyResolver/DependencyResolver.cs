using System.Linq;
using Ninject;
using Ninject.Activation.Caching;
using Ninject.Modules;

namespace CommonTypes.DependencyResolver
{
    public static class DependencyResolver
    {
        private static readonly StandardKernel Kernel;

        static DependencyResolver()
        {
            Kernel = new StandardKernel();
        }

        public static StandardKernel ArmorEditorKernel
        {
            get
            {
                CleanKernel();
                Kernel.Load(new ArmorEditorModule());
                return Kernel;
            }
        }

        public static StandardKernel WeaponEditorKernel
        {
            get
            {
                CleanKernel();
                Kernel.Load(new WeaponEditorModule());
                return Kernel;
            }
        }

        private static void CleanKernel()
        {
            foreach (var module in Kernel.GetModules().Where(m => m is NinjectModule)) Kernel.Unload(module.Name);
            Kernel.Components.Get<ICache>().Clear();
        }
    }
}