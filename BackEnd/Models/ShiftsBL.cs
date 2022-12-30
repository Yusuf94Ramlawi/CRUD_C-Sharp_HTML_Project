using Microsoft.Ajax.Utilities;
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

    public class ShiftsBL
    {
        new masterEntities db = new masterEntities();

        public List<Shift> GetShifts()
        {
            try { 
            IQueryable<Shift> shifts = db.Shifts;
            return shifts.ToList();
            }
            catch { return null; }
        }
        public Shift GetShift(int id)
        {
            try
            {
                IQueryable<Shift> shifts = db.Shifts;
                return shifts.Where(x => x.ID == id).FirstOrDefault();
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