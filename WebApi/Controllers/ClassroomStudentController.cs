using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ClassroomStudentController
{
    private ClassroomStudentServices _classroomStudentServices;

    public ClassroomStudentController(ClassroomStudentServices classroomStudentServices)
    {
        _classroomStudentServices = classroomStudentServices;
    }
    
    [HttpGet("GetClassroomStudent")]
    public async Task<List<ClassroomStudentDto>> GetClassroomStudent()
    {
        return await _classroomStudentServices.GetClassroomStudent();
    }

    [HttpPost("AddClassroomStudent")]
    public async Task AddClassroomStudent(ClassroomStudentDto classroomStudentDto)
    {
        await _classroomStudentServices.AddClassroomStudent(classroomStudentDto);
    }

    [HttpPut("UpdateClassroomStudent")]
    public async Task UpdateClassroomStudent(ClassroomStudentDto classroomStudentDto)
    {
        await _classroomStudentServices.UpdateClassroomStudent(classroomStudentDto);
    }

    [HttpDelete("DeleteClassroomStudent")]
    public async Task DeleteClassroomStudent(int id)
    {
        await _classroomStudentServices.DeleteClassroomStudent(id);
    }
    
}