namespace eManager.Domain
{
    using System.Linq;

    public interface IDepartmentDataSource
    {
        #region Public Properties

        IQueryable<Department> Departments { get; }

        IQueryable<Employee> Employees { get; }

        #endregion

        void Save();
    }
}