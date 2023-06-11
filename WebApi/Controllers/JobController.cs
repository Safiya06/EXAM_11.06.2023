using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class JobController
{
    
    private readonly JobService _jobService;

    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet("getJobs")]
    public async Task<List<Job>> GetJobs()
    {
        return await  _jobService.GetJobs();
    }

    [HttpGet("GetJobById")]
    public async Task<Job> GetJobById(int JobId)
    {
        return await _jobService.GetJobById(JobId);
    }

    [HttpPost("AddJob")]
    public async Task<Job> AddJob(Job job)
    {
        return await _jobService.AddJob(job);
    }
    [HttpPut("UpdateJob")]
    public async Task<Job> UpdateJob(Job job)
    {
        return await _jobService.UpdateJob(job);
    }
    
    [HttpDelete("DeleteJob")]
    public async Task<bool> DeleteJob(int JobId)
    {
        return await _jobService.Delete(JobId);
    }
    
}