using EManager.Web;

[assembly: WebActivator.PreApplicationStartMethod(typeof(StructuremapMvc), "Start")]

namespace EManager.Web {
    using System.Web.Mvc;

    using EManager.Web.DependencyResolution;

    using StructureMap;

    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}