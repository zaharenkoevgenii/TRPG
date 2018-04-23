using CommonTypes.Items.Armor;
using Ninject.Modules;

namespace CommonTypes.DependencyResolver
{
    internal class ArmorEditorModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IArmor)).To(typeof(Armor));
        }
        //class MyClassProvider : SimpleProvider<MyClass>
        //{
        //    protected override MyClass CreateInstance( IContext context )
        //    {
        //        return new MyClass( context.Kernel.Get<IService>(), CalculateINow() );
        //    }
        //}


        //this.Bind(x => x.From(GetType().Assembly).SelectAllClasses().InNamespaceOf(GetType()).BindAllInterfaces().Configure(b => b()));
        //this.Bind(x => x.From(GetType().Assembly)
        //    .SelectAllClasses().InNamespaceOf(GetType())
        //    .Where(t => t.BaseType == typeof(object) // no parent class
        //    && t.GetInterfaces().Length == 0 // no interfaces
        //    && t.DeclaringType == null) // not an inner class
        //    .BindToSelf()
        //    .Configure(b => b.InSingletonScope()));
        //        public virtual IList<Type> Excluding
//{
//    get { return new List<Type>(); }
//}

//public virtual IList<string> Namespaces
//{
//    get { return new List<string> {GetType().Namespace}; }
//}

//public override void Load() 
//{
//    this.Bind(x => x
//        .From(GetType().Assembly)
//        .SelectAllClasses().InNamespaces(Namespaces)
//        .Excluding(Excluding)
//   // now do binding
//}
    }
}