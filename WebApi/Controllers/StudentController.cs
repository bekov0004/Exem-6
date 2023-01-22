using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController
{
    private StudentServices _studentServices;

    public StudentController(StudentServices studentServices)
    {
        _studentServices = studentServices;
    }
    
    [HttpGet("GetStudent")]
    public async Task<List<StudentDto>> GetStudent()
    {
        return await _studentServices.GetStudent();
    }

    [HttpPost("AddStudent")]
    public async Task AddStudent(StudentDto studentDto)
    {
        await _studentServices.AddStudent(studentDto);
    }

    [HttpPut("UpdateStudent")]
    public async Task UpdateStudent(StudentDto studentDto)
    {
        await _studentServices.UpdateStudent(studentDto);
    }

    [HttpDelete("DeleteStudent")]
    public async Task DeleteStudent(int id)
    {
        await _studentServices.DeleteStudent(id);
    }
}