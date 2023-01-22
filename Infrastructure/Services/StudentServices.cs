using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class StudentServices
{
    private readonly DataContext _context;

    public StudentServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<StudentDto>> GetStudent()
    {
        return await _context.Students.Select(x => new StudentDto(x.StudentId,x.Email,x.Password,x.Name,x.DOB,x.Sex,x.Address,x.Phone,x.DateOfJoin,x.ParentName)).ToListAsync();
    }

    public async Task AddStudent(StudentDto studentDto)
    {
        var add = new Student(studentDto.StudentId,studentDto.Email,studentDto.Password,studentDto.Name,studentDto.DOB,studentDto.Sex,studentDto.Address,studentDto.Phone,studentDto.DateOfJoin,studentDto.ParentName);
        await _context.Students.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateStudent(StudentDto studentDto)
    {
        var update = new Student(studentDto.StudentId,studentDto.Email,studentDto.Password,studentDto.Name,studentDto.DOB,studentDto.Sex,studentDto.Address,studentDto.Phone,studentDto.DateOfJoin,studentDto.ParentName);
        _context.Students.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudent(int id)
    {
        var delete =await _context.Students.FirstAsync(x => x.StudentId == id); 
        _context.Students.Remove(delete);
        await _context.SaveChangesAsync();
    }
}