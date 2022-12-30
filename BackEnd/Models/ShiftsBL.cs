using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class ShiftsBL
    {
        new masterEntities db = new masterEntities();

        public List<Shift> GetShifts()
        {
            List<Shift> shifts = db.Shifts.ToList();
            return shifts;
        }
        public List<Employee> GetShift(int id)
        {
            try {
                List<Employee> Employeesshift = (from emp_shift in db.Employee_shift
                                                 join employee in db.Employees on
                                                 emp_shift.employee_id equals employee.ID
                                                 where emp_shift.shift_id == id
                                                 select employee
                                              ).ToList();
                return Employeesshift;

            }
            catch { return null; }

        }

        public void AddShift(Shift shift)
        {
            try
            {
                db.Shifts.Add(shift);
                db.SaveChanges();
            }
            catch { }
        }



    }
}