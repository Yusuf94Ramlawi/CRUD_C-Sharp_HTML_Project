using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FinalProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EmployeesController : ApiController
    {
        public static EmployeesBL bl = new EmployeesBL();

        // GET: api/Employees
        public IEnumerable<EmployeeWithDepartment> Get()
        {
            return bl.GetEmployees();
        }

        // GET: api/Employees/5
        public Employee Get(int id)
        {
            return bl.GetEmployee(id);
        }

        // POST: api/Employees
        public void Post(Employee employee)
        {
            bl.AddEmployee(employee);
        }

        // PUT: api/Employees/5
        public void Put(int id, Employee employee)
        {
            bl.EditEmployee(id, employee);
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
            bl.DeleteEmployee(id);

        }
    }
}
