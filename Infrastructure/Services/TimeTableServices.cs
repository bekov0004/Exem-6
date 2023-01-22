using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TimeTableServices
{
    private readonly DataContext _context;

    public TimeTableServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<TimeTableDto>> GetTimeTable()
    {
        return await _context.TimeTables.Select(x => new TimeTableDto(x.TTId,x.Day,x.Time,x.Subject)).ToListAsync();
    }

    public async Task AddTimeTable(TimeTableDto timeTableDto)
    {
        var add = new TimeTable(timeTableDto.TTId,timeTableDto.Day,timeTableDto.Time,timeTableDto.Subject);
        await _context.TimeTables.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateTimeTable(TimeTableDto timeTableDto)
    {
        var update = new TimeTable(timeTableDto.TTId,timeTableDto.Day,timeTableDto.Time,timeTableDto.Subject);
        _context.TimeTables.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTimeTable(int id)
    {
        var delete =await _context.TimeTables.FirstAsync(x => x.TTId == id); 
        _context.TimeTables.Remove(delete);
        await _context.SaveChangesAsync();
    }
}