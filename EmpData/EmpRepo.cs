using System;
using System.Collections.Generic;
using System.Linq;
using EmpCore.Entities;

namespace EmpData
{
    public class EmpRepo : IEmpRepo
    {
        public IEnumerable<Emp> GetAllEmployee()
        {
            var employees = new List<Emp> {
                new Emp { Id=1, Name="Anna", Designation=".NET Developer", Address="A Street", JoinDate = DateTime.Now.AddDays(-30)},
                new Emp { Id=2, Name="Bryant", Designation=".NET Developer", Address="B Street", JoinDate = DateTime.Now.AddDays(-50)},
                new Emp { Id=3, Name="Cindy", Designation="Scrum Master", Address="C Street", JoinDate = DateTime.Now.AddDays(-60)},
                new Emp { Id=4, Name="Daniel", Designation="Business Analyst", Address="D Street", JoinDate = DateTime.Now.AddDays(-30)},
            };

            return employees;
        }

        public Emp GetEmployeeById(int id)
        {
            var employee = GetAllEmployee().FirstOrDefault(e => e.Id == id);
            return employee;
        }

        public Emp UpdateEmployee(Emp employee)
        {
            var emp = GetAllEmployee().FirstOrDefault(e => e.Id == employee.Id);

            emp.Name = employee.Name;
            emp.Designation = emp.Designation;
            emp.Address = emp.Address;

            return emp;
        }

        public Emp AddEmployee(Emp employee)
        {
            return employee;
        }

        public void DeleteEmployee(Emp employee)
        {
            throw new NotImplementedException(); //Remove 
        }
    }
}
