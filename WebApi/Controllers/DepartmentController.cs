using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class DepartmentController
{
    private readonly DepartmentService _departmentService;

    public DepartmentController(DepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet("getdepartments")]
    public async Task<List<Department>> GetDepartments()
    {
        return await  _departmentService.GetDepartments();
    }

    [HttpGet("GetDepartmentById")]
    public async Task<Department> GetDepartmentById(int DepartmentId)
    {
        return await _departmentService.GetDepartmentById(DepartmentId);
    }

    [HttpPost("AddDepartment")]
    public async Task<Department> AddDepartment(Department department)
    {
        return await _departmentService.AddDepartment(department);
    }
    [HttpPut("UpdateDepartment")]
    public async Task<Department> UpdateDepartment(Department department)
    {
        return await _departmentService.UpdateDepartment(department);
    }
    
    [HttpDelete("DeleteDepartment")]
    public async Task<bool> DeleteDepartment(int DepartmentId)
    {
        return await _departmentService.Delete(DepartmentId);
    }
}