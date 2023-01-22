using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TeacherAttendanceServices
{
    private readonly DataContext _context;

    public TeacherAttendanceServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<TeacherAttendanceDto>> GetAttendance()
    {
        return await _context.TeacherAttendances.Select(x => new TeacherAttendanceDto(x.UserId, x.Date, x.Status,x.TeacherId)).ToListAsync();
    }

    public async Task AddAttendance(TeacherAttendanceDto attendanceDto)
    {
        try
        {
            var add = new TeacherAttendance(attendanceDto.UserId, attendanceDto.Date, attendanceDto.Status,attendanceDto.TeacherId);
            await _context.TeacherAttendances.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }
    
    public async Task UpdateAttendance(TeacherAttendanceDto attendanceDto)
    {
        var update = new TeacherAttendance(attendanceDto.UserId, attendanceDto.Date, attendanceDto.Status,attendanceDto.TeacherId);
         _context.TeacherAttendances.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAttendance(int id)
    {
        var delete =await _context.TeacherAttendances.FirstAsync(x => x.UserId == id); 
        _context.TeacherAttendances.Remove(delete);
        await _context.SaveChangesAsync();
    }
}