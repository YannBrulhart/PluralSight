namespace eManager.Domain
{
    using System.Collections.Generic;

    public class Department
    {
        #region Public Properties

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        #endregion
    }
}