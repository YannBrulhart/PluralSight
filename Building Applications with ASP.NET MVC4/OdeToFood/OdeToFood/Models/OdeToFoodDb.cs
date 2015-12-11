namespace OdeToFood.Models
{
    using System.Data.Entity;
    using System.Linq;

    public class OdeToFoodDb : DbContext,
                               IOdeToFoodDb
    {
        #region Constructors and Destructors

        public OdeToFoodDb()
            : base("name=DefaultConnection")
        {
        }

        #endregion

        #region Public Properties

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<RestaurantReview> Reviews { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        #endregion

        #region Explicit Interface Methods

        void IOdeToFoodDb.Add<T>(T entity)
        {
            this.Set<T>().Add(entity);
        }

        IQueryable<T> IOdeToFoodDb.Query<T>()
        {
            return this.Set<T>();
        }

        void IOdeToFoodDb.Remove<T>(T entity)
        {
            this.Set<T>().Remove(entity);
        }

        void IOdeToFoodDb.SaveChanges()
        {
            this.SaveChanges();
        }

        void IOdeToFoodDb.Update<T>(T entity)
        {
            Entry(entity).State = System.Data.EntityState.Modified;
        }

        #endregion
    }
}