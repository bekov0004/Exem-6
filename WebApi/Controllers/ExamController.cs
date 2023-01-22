using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ExamController
{
    private ExamServices _examServices;

    public ExamController(ExamServices examServices)
    {
        _examServices = examServices;
    }
    
    [HttpGet("GetExam")]
    public async Task<List<ExamDto>> GetExam()
    {
        return await _examServices.GetExame();
    }

    [HttpPost("AddExam")]
    public async Task AddExam(ExamDto examDto)
    {
        await _examServices.AddExame(examDto);
    }

    [HttpPut("UpdateExam")]
    public async Task UpdateExam(ExamDto examDto)
    {
        await _examServices.UpdateExam(examDto);
    }

    [HttpDelete("DeleteExam")]
    public async Task DeleteExam(int id)
    {
        await _examServices.DeleteExame(id);
    }
}