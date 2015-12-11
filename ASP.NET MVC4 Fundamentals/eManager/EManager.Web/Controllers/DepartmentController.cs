using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EManager.Web.Controllers
{
    using eManager.Domain;

    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataSource departmentDataSource;

        //
        // GET: /Department/
        public DepartmentController(IDepartmentDataSource departmentDataSource)
        {
            this.departmentDataSource = departmentDataSource;
        }

        public ActionResult Detail(int id)
        {
            var model = departmentDataSource.Departments.Single(x => x.Id == id);
            return View(model);
        }

    }
}
