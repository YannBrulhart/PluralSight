namespace OdeToFood
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        #region Public Methods and Operators

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Cuisine", "Cuisine/{name}", new { controller = "Cuisine", action = "Search", name = UrlParameter.Optional });
            //routes.MapRoute("Cuisine", "Cuisine/{name}", new { controller = "Cuisine", action = "Search", name = "French" });

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
        }

        #endregion
    }
}