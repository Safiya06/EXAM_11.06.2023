using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class EmployeeService
{
    private readonly DataContext _context;

    public EmployeeService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Employee>> GetEmployees()
    {
        return await  _context.Employees.ToListAsync(); //select all from quotes
    }
    public async Task<Employee>GetEmployeeById(int EmployeeId)
    {
        return await _context.Employees.FindAsync(EmployeeId);
    }
    public async Task< Employee> AddEmployee(Employee employee)
    {
        await  _context.Employees.AddAsync(employee);
        await  _context.SaveChangesAsync();
        return employee;
    }
    public async Task<Employee> UpdateEmployee(Employee employee)
    {
        var find = await _context.Employees.FindAsync(employee.EmployeeId);
        find.FirstName=employee.FirstName;
        find.LastName=employee.LastName;
        find.Email=employee.Email;
        find.PhoneNumber=employee.PhoneNumber;
        find.HireDate=employee.HireDate;
        find.JobId=employee.JobId;
        find.Job=employee.Job;
        find.Salary=employee.Salary;
        find.CommissionPct=employee.CommissionPct;
        find.DeprtmentId=employee.DeprtmentId;
        find.Department=employee.Department;
        await _context.SaveChangesAsync();
        return employee;
    }
    public async Task<bool> Delete (int EmployeeId)
    {
        var find = await _context.Employees.FindAsync(EmployeeId);
        _context.Employees.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
    
}