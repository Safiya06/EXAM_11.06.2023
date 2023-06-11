using DefaultNamespace;
using Microsoft.EntityFrameworkCore;


public class JobGradeService
{
    private readonly DataContext _context;

    public JobGradeService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<JobGrade>> GetJobGrades()
    {
        return await  _context.JobGrades.ToListAsync(); //select all from quotes
    }
    public async Task<JobGrade>GetJobGradeById(int Id)
    {
        return await _context.JobGrades.FindAsync(Id);
    }
    public async Task< JobGrade> AddJobGrade(JobGrade jobgrade)
    {
        await  _context.JobGrades.AddAsync(jobgrade);
        await  _context.SaveChangesAsync();
        return jobgrade;
    }
    public async Task<JobGrade> UpdateJobGrade(JobGrade jobgrade)
    {
        var find = await _context.JobGrades.FindAsync(jobgrade.Id);
        find.GradeLevel=jobgrade.GradeLevel;
        find.LowestSalary=jobgrade.LowestSalary;
        find.HighestService=jobgrade.HighestService;
        await _context.SaveChangesAsync();
        return jobgrade;
    }
    public async Task<bool> Delete (int Id)
    {
        var find = await _context.JobGrades.FindAsync(Id);
        _context.JobGrades.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
    
}