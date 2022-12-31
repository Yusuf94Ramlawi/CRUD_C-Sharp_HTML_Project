using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Employeesshift
    {
        public int ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int shift_id { get; set; }
    }

    public class EmployeeShiftsBL
    {
        masterEntities db = new masterEntities();

        public List<Employeesshift> GetEmployeesShifts()
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
            return Employeesshift.ToList();

        }

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

        public void AddEmployeeShifts(Employee_shift empShift)
        {
            db.Employee_shift.Add(empShift);
            db.SaveChanges();

        }

        public void DeleteEmployeeShifts(int id)
        {
            List<Employee_shift> Employeesshift = db.Employee_shift.Where(x => x.employee_id == id).ToList();
            Employeesshift.ForEach(task => db.Employee_shift.Remove(task));
            db.SaveChanges();

        }
    }
}