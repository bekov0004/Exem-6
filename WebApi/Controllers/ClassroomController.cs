using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ClassroomController
{
    private ClassroomServices _classroomServices;

    public ClassroomController(ClassroomServices classroomServices)
    {
        _classroomServices = classroomServices;
    }
    
    [HttpGet("GetClassroom")]
    public async Task<List<ClassroomDto>> GetClassroom()
    {
        return await _classroomServices.GetClassroom();
    }

    [HttpPost("AddClassroom")]
    public async Task AddClassroom(ClassroomDto classroomDto)
    {
        await _classroomServices.AddClassroom(classroomDto);
    }

    [HttpPut("UpdateClassroom")]
    public async Task UpdateClassroom(ClassroomDto classroomDto)
    {
        await _classroomServices.UpdateClassroom(classroomDto);
    }

    [HttpDelete("DeleteClassroom")]
    public async Task DeleteClassroom(int id)
    {
        await _classroomServices.DeleteClassroom(id);
    }
}