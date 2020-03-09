using System;
using EmpCore.Entities;
using EmpService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmpController : ControllerBase
    {
        private readonly IEmpService _employeeService;
        public EmpController(IEmpService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet]
        [Route("")]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployee();
            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAllEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateEmployee(Emp employee)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(new { errors = "check validation errors" });
            }
            var emp = _employeeService.AddEmployee(employee);

            // need to return 201 created instead of 200
            return Ok(employee);
        }

        [HttpPut]
        [Route("")]
        public IActionResult UpdateEmployee(Emp employee)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(new { errors = "check validation errors" });
            }
            var emp = _employeeService.UpdateEmployee(employee);

            return Ok(emp);
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DeleteEmployee(Emp employee)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(new { errors = "check validation errors" });
            }
            _employeeService.DeleteEmployee(employee);

            return Ok();
        }
    }
}
