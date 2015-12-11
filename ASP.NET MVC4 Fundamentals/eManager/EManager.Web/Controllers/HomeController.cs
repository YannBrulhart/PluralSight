namespace EManager.Web.Controllers
{
    using System.Web.Mvc;

    using eManager.Domain;

    public class HomeController : Controller
    {
        #region Fields

        private readonly IDepartmentDataSource db;

        #endregion

        #region Constructors and Destructors

        public HomeController(IDepartmentDataSource db)
        {
            this.db = db;
        }

        #endregion

        #region Public Methods and Operators

        public ActionResult About()
        {
            this.ViewBag.Message = "Your app description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }

        public ActionResult Index()
        {
            var departements = this.db.Departments;
            return this.View("Index", departements);
        }

        #endregion
    }
}