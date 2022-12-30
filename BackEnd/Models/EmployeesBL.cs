using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public partial class EmployeeWithDepartment
    {
        public int ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int start_work_year { get; set; }
        public string department_name { get; set; }
    }
    public class EmployeesBL
    {
        masterEntities db = new masterEntities();

        public List<EmployeeWithDepartment> GetEmployees()
        {
            List<EmployeeWithDepartment> employees = (from emp in db.Employees
                                        join dep in db.Departments
                                        on emp.department_id equals dep.ID
                                        select new EmployeeWithDepartment
                                        {
                                            ID = emp.ID,
                                            first_name = emp.first_name,
                                            last_name = emp.last_name,
                                            start_work_year = emp.start_work_year,
                                            department_name = dep.name

                                        }).ToList();
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = db.Employees.Where(x => x.ID == id).FirstOrDefault();
            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            catch { }
        }

        public void EditEmployee(int id, Employee employee)
        {
            try
            {
                Employee current_employee = db.Employees.Where(x => x.ID == id).FirstOrDefault();

                current_employee.first_name = employee.first_name;
                current_employee.last_name = employee.last_name;
                current_employee.start_work_year = employee.start_work_year;
                current_employee.department_id = employee.department_id;
                db.SaveChanges();
            }
            catch { }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                Employee current_employee = db.Employees.Where(x => x.ID == id).FirstOrDefault();
                db.Employees.Remove(current_employee);
                db.SaveChanges();

                Employee_shift current_employee_shift = db.Employee_shift.Where(x => x.employee_id == id).FirstOrDefault();
                db.Employee_shift.Remove(current_employee_shift);
                db.SaveChanges();
            }
            catch { }
        }
    }
}