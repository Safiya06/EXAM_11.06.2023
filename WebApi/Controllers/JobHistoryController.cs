using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class JobHistoryController
{    
    private readonly JobHistoryService _jobHistoryService;

    public JobHistoryController(JobHistoryService jobHistoryService)
    {
        _jobHistoryService = jobHistoryService;
    }
    [HttpGet("getJobHistories")]
    public async Task<List<JobHistory>> GetJobHistory()
    {
        return await  _jobHistoryService.GetJobHistories();
    }
    [HttpGet("GetJobHistoryById")]
    public async Task<JobHistory> GetJobHistoryById(int Id)
    {
        return await _jobHistoryService.GetJobHistoryById(Id);
    }
    [HttpPost("AddJobHistory")]
    public async Task<JobHistory> AddJobHistory(JobHistory job)
    {
        return await _jobHistoryService.AddJobHistory(job);
    }
    [HttpPut("UpdateJobHistory")]
    public async Task<JobHistory> UpdateJobHistory(JobHistory job)
    {
        return await _jobHistoryService.UpdateJobHistory(job);
    }
    [HttpDelete("DeleteJobHistory")]
    public async Task<bool> DeleteJobGrade(int Id)
    {
        return await _jobHistoryService.Delete(Id);
    }
}