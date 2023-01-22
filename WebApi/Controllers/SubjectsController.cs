using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class SubjectsController
{
    private SubjectServices _subjectServices;

    public SubjectsController(SubjectServices subjectServices)
    {
        _subjectServices = subjectServices;
    }

    [HttpGet("GetSubject")]
        public async Task<List<SubjectDto>> GetSubject()
        {
           return await _subjectServices.GetSubject();
        }
    
        [HttpPost("AddSubject")]
        public async Task AddSubject(SubjectDto subjectDto)
        {
            await _subjectServices.AddSubject(subjectDto);
        }
    
        [HttpPut("UpdateSubject")]
        public async Task UpdateSubject(SubjectDto subjectDto)
        {
            await _subjectServices.UpdateSubjecte(subjectDto);
        }
    
        [HttpDelete("DeleteSubject")]
        public async Task DeleteSubject(int id)
        {
            await _subjectServices.DeleteSubject(id);
        }
}