using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class SubjectServices
{
    private readonly DataContext _context;

    public SubjectServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<SubjectDto>> GetSubject()
    {
        return await _context.Subjects.Select(x => new SubjectDto(x.SubjectId,x.Name,x.Grade,x.Description)).ToListAsync();
    }

    public async Task AddSubject(SubjectDto subjectDto)
    {
        var add = new Subject(subjectDto.SubjectId,subjectDto.Name,subjectDto.Grade,subjectDto.Description);
        await _context.Subjects.AddAsync(add);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateSubjecte(SubjectDto subjectDto)
    {
        var update = new Subject(subjectDto.SubjectId,subjectDto.Name,subjectDto.Grade,subjectDto.Description);
        _context.Subjects.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteSubject(int id)
    {
        var delete = await _context.Subjects.FirstAsync(x => x.SubjectId == id);
        _context.Subjects.Remove(delete);
        await _context.SaveChangesAsync();
    }
}