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
    public class ShiftsController : ApiController
    {
        public static ShiftsBL bl = new ShiftsBL();

        // GET: api/Shifts
        public IEnumerable<Shift> Get()
        {
            return bl.GetShifts();
        }

        // GET: api/Shifts/5
        public List<Employee> Get(int id)
        {
            return bl.GetShift(id);
        }

        // POST: api/Shifts
        public void Post(Shift shift)
        {
            bl.AddShift(shift);
        }

        // PUT: api/Shifts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shifts/5
        public void Delete(int id)
        {
        }
    }
}
