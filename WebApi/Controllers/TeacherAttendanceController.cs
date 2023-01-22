using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class TeacherAttendanceController
{
    private TeacherAttendanceServices _attendanceServices;

    public TeacherAttendanceController(TeacherAttendanceServices teacherAttendanceServices)
    {
        _attendanceServices = teacherAttendanceServices;
    }

    [HttpGet("GetAttendance")]
    public async Task<List<TeacherAttendanceDto>> GetAttendance()
    {
       return await _attendanceServices.GetAttendance();
    }

    [HttpPost("AddAttendance")]
    public async Task AddAttendance(TeacherAttendanceDto attendanceDto)
    {
        await _attendanceServices.AddAttendance(attendanceDto);
    }

    [HttpPut("UpdateAttendance")]
    public async Task UpdateAttendance(TeacherAttendanceDto attendanceDto)
    {
        await _attendanceServices.UpdateAttendance(attendanceDto);
    }

    [HttpDelete("DeleteAttendance")]
    public async Task DeleteAttendance(int id)
    {
        await _attendanceServices.DeleteAttendance(id);
    }
}