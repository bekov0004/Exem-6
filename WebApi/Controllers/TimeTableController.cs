using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class TimeTableController
{
    private TimeTableServices _timeTableServices;

    public TimeTableController(TimeTableServices timeTableServices)
    {
        _timeTableServices = timeTableServices;
    }
    
    [HttpGet("GetTimeTable")]
    public async Task<List<TimeTableDto>> GetTimeTable()
    {
        return await _timeTableServices.GetTimeTable();
    }

    [HttpPost("AddTimeTable")]
    public async Task AddTimeTable(TimeTableDto timeTableDto)
    {
        await _timeTableServices.AddTimeTable(timeTableDto);
    }

    [HttpPut("UpdateTimeTable")]
    public async Task UpdateTimeTable(TimeTableDto timeTableDto)
    {
        await _timeTableServices.UpdateTimeTable(timeTableDto);
    }

    [HttpDelete("DeleteTimeTable")]
    public async Task DeleteTimeTable(int id)
    {
        await _timeTableServices.DeleteTimeTable(id);
    }
}