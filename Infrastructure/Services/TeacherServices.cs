using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TeacherServices
{
    private readonly DataContext _context;

    public TeacherServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<TeacherDto>> GetTeacher()
    {
        return await _context.Teachers.Select(x => new TeacherDto(x.TeacherId,x.Email,x.Password,x.Name,x.DOB,x.Sex,x.Address,x.Phone,x.DateOfJoin)).ToListAsync();
    }

    public async Task AddTeacher(TeacherDto teacherDto)
    {
        var add = new Teacher(teacherDto.TeacherId,teacherDto.Email,teacherDto.Password,teacherDto.Name,teacherDto.DOB,teacherDto.Sex,teacherDto.Address,teacherDto.Phone,teacherDto.DateOfJoin);
        await _context.Teachers.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateTeacher(TeacherDto teacherDto)
    {
        var update = new Teacher(teacherDto.TeacherId,teacherDto.Email,teacherDto.Password,teacherDto.Name,teacherDto.DOB,teacherDto.Sex,teacherDto.Address,teacherDto.Phone,teacherDto.DateOfJoin);
        _context.Teachers.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTeacher(int id)
    {
        var delete =await _context.Teachers.FirstAsync(x => x.TeacherId == id); 
        _context.Teachers.Remove(delete);
        await _context.SaveChangesAsync();
    }
}