using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace;

public class JobService
{
    
    private readonly DataContext _context;

    public JobService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Job>> GetJobs()
    {
        return await  _context.Jobs.ToListAsync(); //select all from quotes
    }
    public async Task<Job>GetJobById(int JobId)
    {
        return await _context.Jobs.FindAsync(JobId);
    }
    public async Task< Job> AddJob(Job job)
    {
        await  _context.Jobs.AddAsync(job);
        await  _context.SaveChangesAsync();
        return job;
    }
    public async Task<Job> UpdateJob(Job job)
    {
        var find = await _context.Jobs.FindAsync(job.JobId);
        find.JobTitle=job.JobTitle;
        find.MinSalary=job.MinSalary;
        find.MaxSalary=job.MaxSalary;
        await _context.SaveChangesAsync();
        return job;
    }
    public async Task<bool> Delete (int JobId)
    {
        var find = await _context.Jobs.FindAsync(JobId);
        _context.Jobs.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}