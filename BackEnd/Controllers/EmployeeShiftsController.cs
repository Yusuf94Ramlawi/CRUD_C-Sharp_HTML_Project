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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EmployeeShifts/5
        public List<Employeesshift> Get(int id)
        {
            return bl.GetEmployeeShifts(id);

        }

        // POST: api/EmployeeShifts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EmployeeShifts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmployeeShifts/5
        public void Delete(int id)
        {
        }
    }
}
