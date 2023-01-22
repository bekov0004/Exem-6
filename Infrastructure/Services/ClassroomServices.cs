using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ClassroomServices
{
    private readonly DataContext _context;

    public ClassroomServices(DataContext context)
    {
        _context = context;
    }
    
    public async Task<List<ClassroomDto>> GetClassroom()
    {
        return await _context.Classrooms.Select(x => new ClassroomDto(x.ClassroomId, x.Section, x.Grade,x.TeacherId)).ToListAsync();
    }
    
    public async Task AddClassroom(ClassroomDto classroomDto)
    {
        var add = new Classroom(classroomDto.ClassroomId,classroomDto.Section,classroomDto.Grade,classroomDto.Teacher_Id);
        await _context.Classrooms.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateClassroom(ClassroomDto classroomDto)
    {
        var update = new Classroom(classroomDto.ClassroomId,classroomDto.Section,classroomDto.Grade,classroomDto.Teacher_Id);
        _context.Classrooms.Update(update);
        await  _context.SaveChangesAsync();
    }
    
    public async Task DeleteClassroom(int id)
    {
        var delete = await _context.Classrooms.FirstAsync(x => x.ClassroomId == id); 
        _context.Classrooms.Remove(delete);
        await _context.SaveChangesAsync();
    }
}