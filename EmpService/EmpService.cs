using System;
using System.Collections.Generic;
using EmpCore.Entities;
using EmpData;

namespace EmpService
{
    public class EmpService : IEmpService
    {
        private readonly IEmpRepo _employeeRepository;
        public EmpService(IEmpRepo employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Emp AddEmployee(Emp employee)
        {
            return _employeeRepository.AddEmployee(employee);
        }

        public void DeleteEmployee(Emp employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }

        public IEnumerable<Emp> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }

        public Emp GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public Emp UpdateEmployee(Emp employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }
    }
}
