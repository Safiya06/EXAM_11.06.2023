using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class JobGradeController
{
    
    private readonly JobGradeService _jobGradeServiceService;

    public JobGradeController(JobGradeService jobGradeService)
    {
        _jobGradeServiceService = jobGradeService;
    }

    [HttpGet("getJobGrades")]
    public async Task<List<JobGrade>> GetJobGrades()
    {
        return await  _jobGradeServiceService.GetJobGrades();
    }

    [HttpGet("GetJobGradeById")]
    public async Task<JobGrade> GetJobGradeById(int Id)
    {
        return await _jobGradeServiceService.GetJobGradeById(Id);
    }

    [HttpPost("AddJobGrade")]
    public async Task<JobGrade> AddJobGrade(JobGrade job)
    {
        return await _jobGradeServiceService.AddJobGrade(job);
    }
    [HttpPut("UpdateJobGrade")]
    public async Task<JobGrade> UpdateJobGrade(JobGrade job)
    {
        return await _jobGradeServiceService.UpdateJobGrade(job);
    }
    
    [HttpDelete("DeleteJobGrade")]
    public async Task<bool> DeleteJobGrade(int Id)
    {
        return await _jobGradeServiceService.Delete(Id);
    }
}