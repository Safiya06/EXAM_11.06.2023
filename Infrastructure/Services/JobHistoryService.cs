using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class JobHistoryService
{
    private readonly DataContext _context;

    public JobHistoryService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<JobHistory>> GetJobHistories()
    {
        return await  _context.JobHistories.ToListAsync(); //select all from quotes
    }
    public async Task<JobHistory>GetJobHistoryById(int Id)
    {
        return await _context.JobHistories.FindAsync(Id);
    }
    public async Task< JobHistory> AddJobHistory(JobHistory jobhistory)
    {
        await  _context.JobHistories.AddAsync(jobhistory);
        await  _context.SaveChangesAsync();
        return jobhistory;
    }
    public async Task<JobHistory> UpdateJobHistory(JobHistory jobhistory)
    {
        var find = await _context.JobHistories.FindAsync(jobhistory.Id);
        find.EmployeeId=jobhistory.EmployeeId;
        find.StartDate=jobhistory.StartDate;
        find.EndDate=jobhistory.EndDate;
        find.JobId=jobhistory.JobId;
        find.Job=jobhistory.Job;
        find.DepartmentId=jobhistory.DepartmentId;
        await _context.SaveChangesAsync();
        return jobhistory;
    }
    public async Task<bool> Delete (int Id)
    {
        var find = await _context.JobHistories.FindAsync(Id);
        _context.JobHistories.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
    
}