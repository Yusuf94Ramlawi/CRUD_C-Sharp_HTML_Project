using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class EmployeeShiftsBL
    {
        masterEntities db = new masterEntities();

        public List<Employeesshift> GetEmployeeShifts(int id)
        {
            IQueryable<Employeesshift> Employeesshift = (from employee in db.Employees
                                                         join emp_shift in db.Employee_shift
                                                         on employee.ID equals emp_shift.employee_id
                                                         select new Employeesshift
                                                         {
                                                             ID = employee.ID,
                                                             first_name = employee.first_name,
                                                             last_name = employee.last_name,
                                                             shift_id = emp_shift.shift_id
                                                         });
            return Employeesshift.Where(x => x.shift_id == id).ToList();

        }
    }
}