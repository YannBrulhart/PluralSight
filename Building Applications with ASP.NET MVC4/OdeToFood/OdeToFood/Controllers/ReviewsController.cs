namespace OdeToFood.Controllers
{
    using System.Data;
    using System.Web.Mvc;

    using OdeToFood.Models;

    public class ReviewsController : Controller
    {
        #region Fields

        private readonly OdeToFoodDb db = new OdeToFoodDb();

        #endregion

        //
        // GET: /Reviews/

        #region Public Methods and Operators

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Reviews.Add(review);
                this.db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }

            return this.View(review);
        }

        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var restaurant = this.db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return this.HttpNotFound();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Releases unmanaged resources and optionally releases managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            this.db.Dispose();

            base.Dispose(disposing);
        }

        #endregion

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var review = db.Reviews.Find(id);
            return View(review);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Exclude = "ReviewerName")]RestaurantReview review)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Entry(review).State = EntityState.Modified;
                this.db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }

            return this.View(review);
        }
    }
}