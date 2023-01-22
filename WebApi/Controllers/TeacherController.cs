using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class TeacherController
{
    private TeacherServices _teacherServices;

    public TeacherController(TeacherServices teacherServices)
    {
        _teacherServices = teacherServices;
    }
    
    [HttpGet("GetTeacher")]
    public async Task<List<TeacherDto>> GetTeacher()
    {
        return await _teacherServices.GetTeacher();
    }

    [HttpPost("AddTeacher")]
    public async Task AddTeacher(TeacherDto teacherDto)
    {
        await _teacherServices.AddTeacher(teacherDto);
    }

    [HttpPut("UpdateTeacher")]
    public async Task UpdateTeacher(TeacherDto teacherDto)
    {
        await _teacherServices.UpdateTeacher(teacherDto);
    }

    [HttpDelete("DeleteTeacher")]
    public async Task DeleteTeacher(int id)
    {
        await _teacherServices.DeleteTeacher(id);
    }
}