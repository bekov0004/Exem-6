using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class StudentAttendanceServices
{
    private readonly DataContext _context;

    public StudentAttendanceServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<StudentAttendanceDto>> GetAttendance()
    {
        return await _context.Attendances.Select(x => new StudentAttendanceDto(x.UserId, x.Date, x.Status,x.StudentId)).ToListAsync();
    }

    public async Task AddAttendance(StudentAttendanceDto attendanceDto)
    {
        try
        {
            var add = new StudentAttendance(attendanceDto.UserId, attendanceDto.Date, attendanceDto.Status,attendanceDto.StudentId);
            await _context.Attendances.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }
    
    public async Task UpdateAttendance(StudentAttendanceDto attendanceDto)
    {
        var update = new StudentAttendance(attendanceDto.UserId, attendanceDto.Date, attendanceDto.Status,attendanceDto.StudentId);
         _context.Attendances.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAttendance(int id)
    {
        var delete =await _context.Attendances.FirstAsync(x => x.UserId == id); 
        _context.Attendances.Remove(delete);
        await _context.SaveChangesAsync();
    }
}