using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProject.Models
{
    public class Departments
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int manager_id { get; set; }
        public string manager_name { get; set; }
    }

    public class DepartmentBL
    {
        masterEntities db = new masterEntities();

        public List<Departments> GetDepartments()
        {
            List<Departments> departments = new List<Departments>();
            try
            {

                departments = (from dep in db.Departments
                              join emp in db.Employees on dep.manager_id equals emp.ID
                              select new Departments
                              {
                                  ID = dep.ID,
                                  name = dep.name,
                                  manager_id = dep.manager_id,
                                  manager_name = emp.first_name + " " + emp.last_name
                              }).ToList();
            }
            catch { }

            return departments;
        }

        public Department GetDepartment(int id)
        {
            Department current_department = db.Departments.Where(x=> x.ID == id).FirstOrDefault();
            return current_department;
        }
        
        public void AddDepartment(Department department)
        {
            try
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }
            catch { }

        }

        public void EditDepartment(int id, Department department)
        {
            try
            {
                Department current_department = db.Departments.Where(x => x.ID == id).FirstOrDefault();
                current_department.manager_id = department.manager_id;
                current_department.name = department.name;
                db.SaveChanges();
            }
            catch { }

        }

        public void DeleteDepartment(int id)
        {
            try
            {
                List<Department> isEmployee = (from dep in db.Departments
                                               join emp in db.Employees on
                                               dep.ID equals emp.department_id
                                               where dep.ID == id
                                               select dep).ToList();
                if (isEmployee.Count == 0)
                {
                    Department current_department = db.Departments.Where(x => x.ID == id).FirstOrDefault();
                    db.Departments.Remove(current_department);
                    db.SaveChanges();
                }
            }
            catch { }
        }

    }
}