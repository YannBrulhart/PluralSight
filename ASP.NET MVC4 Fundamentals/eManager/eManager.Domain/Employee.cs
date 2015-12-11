namespace eManager.Domain
{
    using System;

    public class Employee
    {
        #region Public Properties

        public virtual DateTime? HireDate { get; set; }

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        #endregion
    }
}