namespace OdeToFood.Controllers
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        #region Public Methods and Operators

        public ActionResult Search(string name)
        {
            var encodedName = Server.HtmlEncode(name);
            return this.Content(string.Format("Hello {0}!", encodedName));
        }

        public ActionResult Search2(string name)
        {
            var encodedName = Server.HtmlEncode(name);
            //return this.RedirectPermanent("http://www.google.ch");
            return this.RedirectToAction("Index", "Home",new {name = name});
        }

        #endregion
    }
}