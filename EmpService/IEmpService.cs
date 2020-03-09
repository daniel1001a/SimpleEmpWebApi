using System.Collections.Generic;
using EmpCore.Entities;

namespace EmpService
{
    public interface IEmpService
    {
        IEnumerable<Emp> GetAllEmployee();

        Emp AddEmployee(Emp employee);

        void DeleteEmployee(Emp employee);

        Emp UpdateEmployee(Emp employee);

        Emp GetEmployeeById(int id);
    }
}
