using S_SquaredEnterprices3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.Security;

namespace S_SquaredEnterprices3.Controllers
{
    public class EmployeeController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            //this method is to dispose dbcontext
        }

        // GET: Employee
        public ActionResult Index()
        {
            var managersThreeFullRowsTable = _context.Employees.Include(r => r.Role)
                                            .Where(r => r.EmployeeRoleId == 1)
                                            .Select(r => r.FirstName + " " + r.LastName);

            var managerEmployeeIdRowsTable = _context.Employees.Include(r => r.Role)
                                  .Where(r => r.EmployeeRoleId == 1)
                                  .Select(r => r.EmployeeId);

            List<int> ManagerEmpId = new List<int> { };
            foreach (var Id in managerEmployeeIdRowsTable)
            {
                ManagerEmpId.Add(Id);
            }

            List<string> ManagerFullName = new List<string> { };

            foreach (var fullname in managersThreeFullRowsTable)
            {
                ManagerFullName.Add(fullname);

            }

            var ManagerIdFullNameDictionary = ManagerEmpId.Zip(ManagerFullName, (k, v) => new { k, v }).ToDictionary(m => m.k, m => m.v);

            return View(ManagerIdFullNameDictionary);

        }

        public ActionResult Assignees(int ManagerEmpId)
        {
            var assigneeDetailsTable = _context.Employees.Include(a => a.Role).Where(a => a.ManagerEmployeeId == ManagerEmpId)
                                  .Select(a => new { a.EmployeeId, a.FirstName, a.LastName });

            Dictionary<int, Tuple<string, string>> assigneeDetails = new Dictionary<int, Tuple<string, string>>();

            foreach (var assignee in assigneeDetailsTable)
            {
                assigneeDetails.Add(assignee.EmployeeId, Tuple.Create(assignee.FirstName, assignee.LastName));
            }

            return View(assigneeDetails);
        }

        public ActionResult NewEmployee()
          {
              var employee = _context.Employees.Include(e => e.Role).ToList();
              
              return View("EmployeeForm");
          }

        public ActionResult Save(Employee employee)
        {
            var employeeInDb = _context.Employees;
            
           /* employeeInDb.FirstName = employee.FirstName;
            employeeInDb.LastName = employee.LastName;
            employeeInDb.Role.RoleName = employee.Role.RoleName; */

           

            return View();
        }

        public ActionResult Cancel()
        {
            return View("index");
        }

    }
}