namespace OdeToFood.Migrations
{
    using System.Collections.ObjectModel;
    using System.Data.Entity.Migrations;

    using OdeToFood.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        #region Constructors and Destructors

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        #endregion

        #region Methods

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(new Restaurant
                                                {
                                                    City = "Fribourg",
                                                    Country = "Suisse",
                                                    Name = "Le Pérolles",
                                                    Reviews = new Collection<RestaurantReview>
                                                                  {
                                                                      new RestaurantReview
                                                                          {
                                                                              Body = "Excellent Restaurant!",
                                                                              Rating = 3,
                                                                              ReviewerName = "Yann"
                                                                          }
                                                                  }
                                                });
            context.Restaurants.AddOrUpdate(new Restaurant
                                                {
                                                    City = "Romont",
                                                    Country = "Suisse",
                                                    Name = "Le Chateau",
                                                    Reviews = new Collection<RestaurantReview>
                                                                  {
                                                                      new RestaurantReview
                                                                          {
                                                                              Body = "Sympa",
                                                                              Rating = 2,
                                                                              ReviewerName = "Yann"
                                                                          }
                                                                  }
                                                });
            context.Restaurants.AddOrUpdate(new Restaurant
                                                {
                                                    City = "Bulle",
                                                    Country = "Suisse",
                                                    Name = "Migros",
                                                    Reviews = new Collection<RestaurantReview>
                                                                  {
                                                                      new RestaurantReview
                                                                          {
                                                                              Body = "Tambouille!",
                                                                              Rating = 1,
                                                                              ReviewerName = "Pascal"
                                                                          }
                                                                  }
                                                });
            context.Restaurants.AddOrUpdate(new Restaurant
                                                {
                                                    City = "Paris",
                                                    Country = "France",
                                                    Name = "La tour",
                                                    Reviews = new Collection<RestaurantReview>
                                                                  {
                                                                      new RestaurantReview
                                                                          {
                                                                              Body = "Trop cher!",
                                                                              Rating = 4,
                                                                              ReviewerName = "Fab"
                                                                          }
                                                                  }
                                                });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        #endregion
    }
}