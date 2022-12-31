using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FinalProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeShiftsController : ApiController
    {
        EmployeeShiftsBL bl = new EmployeeShiftsBL();

        // GET: api/EmployeeShifts
        public IEnumerable<Employeesshift> Get()
        {
            return bl.GetEmployeesShifts();
        }

        // GET: api/EmployeeShifts/5
        public List<Employeesshift> Get(int id)
        {
            return bl.GetEmployeeShifts(id);

        }

        // POST: api/EmployeeShifts
        public void Post(Employee_shift empShift)
        {
            bl.AddEmployeeShifts(empShift);
        }

        // PUT: api/EmployeeShifts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmployeeShifts/5
        public void Delete(int id)
        {
            bl.DeleteEmployeeShifts(id);
        }
    }
}
