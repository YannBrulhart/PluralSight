namespace OdeToFood.Models
{
    using System.Collections.Generic;

    public class Restaurant
    {
        #region Public Properties

        public string City { get; set; }

        public string Country { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<RestaurantReview> Reviews { get; set; }

        #endregion
    }
}