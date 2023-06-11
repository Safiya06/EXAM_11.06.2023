using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class DepartmentService
{
    private readonly DataContext _context;

    public DepartmentService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Department>> GetDepartments()
    {
        return await  _context.Departments.ToListAsync(); //select all from quotes
    }
    public async Task<Department>GetDepartmentById(int DepartmantId)
    {
        return await _context.Departments.FindAsync(DepartmantId);
    }
    public async Task< Department> AddDepartment(Department department)
    {
        await  _context.Departments.AddAsync(department);
        await  _context.SaveChangesAsync();
        return department;
    }
    public async Task<Department> UpdateDepartment(Department department)
    {
        var find = await _context.Departments.FindAsync(department.DepartmantId);
        find.DepartmentName=department.DepartmentName;
        find.LocationId=department.LocationId;
        await _context.SaveChangesAsync();
        return department;
    }
    public async Task<bool> Delete (int DepartmantId)
    {
        var find = await _context.Departments.FindAsync(DepartmantId);
        _context.Departments.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}