using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class EmployeeController
{
    
    private readonly EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("getEmployees")]
    public async Task<List<Employee>> GetEmployees()
    {
        return await  _employeeService.GetEmployees();
    }

    [HttpGet("GetEmployeeById")]
    public async Task<Employee> GetEmployeeById(int EmployeeId)
    {
        return await _employeeService.GetEmployeeById(EmployeeId);
    }

    [HttpPost("AddEmployee")]
    public async Task<Employee> AddEmployee(Employee employee)
    {
        return await _employeeService.AddEmployee(employee);
    }
    [HttpPut("UpdateEmployee")]
    public async Task<Employee> UpdateEmployee(Employee employee)
    {
        return await _employeeService.UpdateEmployee(employee);
    }
    
    [HttpDelete("DeleteEmployee")]
    public async Task<bool> DeleteEmployee(int EmployeeId)
    {
        return await _employeeService.Delete(EmployeeId);
    }
}