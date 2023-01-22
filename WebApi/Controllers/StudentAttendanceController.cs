using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentAttendanceController
{
    private StudentAttendanceServices _attendanceServices;

    public StudentAttendanceController(StudentAttendanceServices attendanceServices)
    {
        _attendanceServices = attendanceServices;
    }

    [HttpGet("GetAttendance")]
    public async Task<List<StudentAttendanceDto>> GetAttendance()
    {
       return await _attendanceServices.GetAttendance();
    }

    [HttpPost("AddAttendance")]
    public async Task AddAttendance(StudentAttendanceDto attendanceDto)
    {
        await _attendanceServices.AddAttendance(attendanceDto);
    }

    [HttpPut("UpdateAttendance")]
    public async Task UpdateAttendance(StudentAttendanceDto attendanceDto)
    {
        await _attendanceServices.UpdateAttendance(attendanceDto);
    }

    [HttpDelete("DeleteAttendance")]
    public async Task DeleteAttendance(int id)
    {
        await _attendanceServices.DeleteAttendance(id);
    }
}