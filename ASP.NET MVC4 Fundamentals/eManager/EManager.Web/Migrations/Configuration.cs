namespace EManager.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    using eManager.Domain;

    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<DepartmentDb>
    {
        #region Constructors and Destructors

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        #endregion

        #region Methods

        protected override void Seed(DepartmentDb context)
        {
            base.Seed(context);

            if (context.Departments == null)
            {
                throw new Exception("dddd");
            }
            context.Departments.AddOrUpdate(d => d.Name,
                                            new Department { Name = "Engineering" },
                                            new Department { Name = "RH" },
                                            new Department { Name = "Sales" },
                                            new Department { Name = "Expeditions" },
                                            new Department { Name = "Facturation" }
                );

            this.SeedMembership();
        }

        private void SeedMembership()
        {
            WebSecurity.InitializeDatabaseConnection("DepartmentDb", "UserProfile", "UserId", "UserName", true);

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("sales"))
            {
                roles.CreateRole("sales");
            }
            if (membership.GetUser("Yann Brulhart", false) == null)
            {
                membership.CreateUserAndAccount("Yann Brulhart", "2345678");
            }

            if (!roles.GetRolesForUser("Yann Brulhart").Contains("sales"))
            {
                roles.AddUsersToRoles(new[] { "Yann Brulhart" }, new[] { "sales" });
            }
        }

        #endregion
    }
}