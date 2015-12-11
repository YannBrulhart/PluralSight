namespace OdeToFood.Models
{
    using System;
    using System.Linq;

    public interface IOdeToFoodDb : IDisposable
    {
        #region Public Methods and Operators

        void Add<T>(T entity) where T : class;

        IQueryable<T> Query<T>() where T : class;

        void Remove<T>(T entity) where T : class;

        void SaveChanges();

        void Update<T>(T entity) where T : class;

        #endregion
    }
}