namespace EManager.Web.DependencyResolution
{
    using eManager.Domain;

    using StructureMap;
    using StructureMap.Graph;

    public static class IoC
    {
        #region Public Methods and Operators

        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
                                         {
                                             x.Scan(scan =>
                                                        {
                                                            scan.TheCallingAssembly();
                                                            scan.WithDefaultConventions();
                                                        });
                                             x.For<IDepartmentDataSource>().Use<DepartmentDb>();
                                         });
            return ObjectFactory.Container;
        }

        #endregion
    }
}