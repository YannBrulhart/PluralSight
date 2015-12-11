namespace OdeToFood.Controllers
{
    using System.Configuration;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.UI;

    using OdeToFood.Models;

    using PagedList;

    public class HomeController : Controller
    {
        #region Public Methods and Operators

        IOdeToFoodDb _db;

        public HomeController()
        {
            _db = new OdeToFoodDb();
        }

        public HomeController(IOdeToFoodDb db)
        {
            _db = db;
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your app description page.";
            this.ViewBag.Location = "Bulle";

            var controllerName = RouteData.Values["controller"];
            var actionName = RouteData.Values["action"];
            var idValue = RouteData.Values["id"];

            var message = string.Format("controller={0} action={1} id={2}", controllerName, actionName, idValue);

            var model = new AboutModel
                            {
                                Name = "Brulhart",
                                Location = message
                            };

            return this.View(model);
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 60)]
        public ActionResult SayHello()
        {
            return Content("Hello");
        }

        [OutputCache(Duration=360, VaryByHeader = "X-Requested-With", Location = OutputCacheLocation.Server)]
        public ActionResult Index(string searchTerm, int page = 1)
        {
            var greeting = OdeToFood.Views.Home.Resources.Greeting;

            var model =
                _db.Query<Restaurant>()
                   .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                   .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                   .Select(r => new RestaurantListViewModel
                   {
                       Id = r.Id,
                       Name = r.Name,
                       City = r.City,
                       Country = r.Country,
                       CountOfReviews = r.Reviews.Count()
                   }).ToPagedList(page, 3);

            ViewBag.MailServer = ConfigurationManager.AppSettings["MailServer"];

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Restaurants", model);
            }

            return View(model);
        }

        #endregion
    }
}