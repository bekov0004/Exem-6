using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ClassroomStudentServices
{
    private readonly DataContext _context;

    public ClassroomStudentServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<ClassroomStudentDto>> GetClassroomStudent()
    {
        return await _context.ClassroomStudents.Select(x => new ClassroomStudentDto(x.StudentId, x.ClassroomId )).ToListAsync();
    }

    public async Task AddClassroomStudent(ClassroomStudentDto classroomStudentDto)
    {
        var add = new ClassroomStudent(classroomStudentDto.StudentId,classroomStudentDto.ClassroomId);
        await _context.ClassroomStudents.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateClassroomStudent(ClassroomStudentDto classroomStudentDto)
    {
        var update = new ClassroomStudent(classroomStudentDto.StudentId,classroomStudentDto.ClassroomId);
        _context.ClassroomStudents.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteClassroomStudent(int id)
    {
        var delete =await _context.ClassroomStudents.FirstAsync(x => x.ClassroomId == id ); 
        _context.ClassroomStudents.Remove(delete);
        await _context.SaveChangesAsync();
    }
}