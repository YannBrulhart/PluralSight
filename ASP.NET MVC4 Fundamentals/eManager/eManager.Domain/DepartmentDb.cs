namespace eManager.Domain
{
    using System.Data.Entity;
    using System.Linq;

    public class DepartmentDb : DbContext,
                                IDepartmentDataSource
    {
        #region Public Properties

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }


        #endregion

        #region Explicit Interface Properties

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get
            {
                return this.Departments;
            }
        }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                return this.Employees;
            }
        }

        #endregion

        #region Explicit Interface Methods

        void IDepartmentDataSource.Save()
        {
            this.SaveChanges();
        }

        #endregion
    }
}