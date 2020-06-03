using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaBlazor.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
            
        {
            _db = db;

        }

        // CRUD 

        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

       public string Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Success";
        }


        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }


        public string UpdateEmployee(EmployeeInfo objEmmployee)
        {
            _db.Employees.Update(objEmmployee);
            _db.SaveChanges();
            return "update";
        }


        public string DeleteEmpInfo(EmployeeInfo objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delete";
                
        }
    }
}
