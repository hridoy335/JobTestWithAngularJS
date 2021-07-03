using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private JobTestEntities db = new JobTestEntities();
        public ActionResult EmployeeHome()
        {
            //List<Employee> employees = db.Employees.ToList();
            //List<Phone> phones = db.Phones.ToList();
            //var employeeRecord = from e in employees
            //    join d in phones on e.Id equals d.Emp__Id into table1
            //    from d in table1.ToList()
            //    select new ViewModel
            //    {
            //        employee = e,
            //        phone = d,
                   
            //    };

            return View();
        }

        public JsonResult GetEmployee()
        {
            List<Employee> employees = db.Employees.ToList();
            List<Phone> phones = db.Phones.ToList();
            var employeeRecord = from e in employees
                join d in phones on e.Id equals d.Emp__Id into table1
                from d in table1.ToList()
                select new ViewModel
                {
                    employee = e.Name,
                    phone = d.Phone1,

                };
            return Json(employeeRecord, JsonRequestBehavior.AllowGet);
        }

    }
}