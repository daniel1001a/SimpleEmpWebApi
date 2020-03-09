using System;
using System.Collections.Generic;
using EmpCore.Entities;
using EmpData;

namespace EmpService
{
    public class DEmpService : IEmpService
    {
        private readonly IEmpRepo _empRep;

        public DEmpService(IEmpRepo employeeRepository)
        {
            _empRep = employeeRepository;
        }
        public Emp AddEmployee(Emp employee)
        {
            return _empRep.AddEmployee(employee);
        }

        public void DeleteEmployee(Emp employee)
        {
            _empRep.DeleteEmployee(employee);
        }

        public IEnumerable<Emp> GetAllEmployee()
        {
            return _empRep.GetAllEmployee();
        }

        public Emp GetEmployeeById(int id)
        {
            return _empRep.GetEmployeeById(id);
        }

        public Emp UpdateEmployee(Emp employee)
        {
            return _empRep.UpdateEmployee(employee);
        }
    }
}