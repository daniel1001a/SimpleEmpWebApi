using System;
using System.Collections.Generic;
using EmpCore.Entities;

namespace EmpData
{
    public interface IEmpRepo
    {
        IEnumerable<Emp> GetAllEmployee();

        Emp GetEmployeeById(int id);

        Emp AddEmployee(Emp employee);

        void DeleteEmployee(Emp employee);

        Emp UpdateEmployee(Emp employee);

        
    }
}
