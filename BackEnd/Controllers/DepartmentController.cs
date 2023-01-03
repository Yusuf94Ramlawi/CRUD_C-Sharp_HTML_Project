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
    public class DepartmentController : ApiController
    {
        DepartmentBL bl = new DepartmentBL();

        // GET: api/Department
        public IEnumerable<Departments> Get()
        {
            List<Departments> departmentList = bl.GetDepartments();
            return departmentList;
        }

        // GET: api/Department/5
        public Department Get(int id)
        {
            Department Getdepartment = bl.GetDepartment(id);
            return Getdepartment;
        }

        // POST: api/Department
        public void Post(Department department)
        {
            bl.AddDepartment(department);
        }

        // PUT: api/Department/5
        public void Put(int id, Department department)
        {
            bl.EditDepartment(id, department);
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
            bl.DeleteDepartment(id);
        }
    }
}
