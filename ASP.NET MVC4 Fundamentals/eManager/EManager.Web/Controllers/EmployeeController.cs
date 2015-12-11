namespace EManager.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    using eManager.Domain;

    using EManager.Web.Models;

    public class EmployeeController : Controller
    {
        #region Fields

        private readonly IDepartmentDataSource db;

        #endregion

        //
        // GET: /Employee/

        #region Constructors and Destructors

        public EmployeeController(IDepartmentDataSource db)
        {
            this.db = db;
        }

        #endregion

        #region Public Methods and Operators

        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult Create(int departmentId)
        {var model = new CreateEmployeeViewModel { DepartmentId = departmentId };
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEmployeeViewModel emplyeeViewModel)
        {
            if (this.ModelState.IsValid)
            {
                var department = this.db.Departments.Single(x => x.Id == emplyeeViewModel.DepartmentId);
                var employee =
                    new Employee
                        {
                            Name = emplyeeViewModel.Name,
                            HireDate = emplyeeViewModel.HireDate,
                        };
                department.Employees.Add(employee);
                this.db.Save();

                return RedirectToAction("detail", "Department", new { id = emplyeeViewModel.DepartmentId });
            }
            return View(emplyeeViewModel);
        }

        #endregion
    }
}