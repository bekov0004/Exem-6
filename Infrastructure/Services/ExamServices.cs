using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ExamServices
{
    private readonly DataContext _context;

    public ExamServices(DataContext context)
    {
        _context = context;
    }
    
    public async Task<List<ExamDto>> GetExame()
    {
        return await _context.Exams.Select(x => new ExamDto(x.ExemId, x.Date, x.Name,x.Type)).ToListAsync();
    }

    public async Task AddExame(ExamDto examDto)
    {
        var add = new Exam(examDto.ExemId, examDto.Date, examDto.Name,examDto.Type);
        await _context.Exams.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateExam(ExamDto examDto)
    {
        var update = new Exam(examDto.ExemId, examDto.Date, examDto.Name,examDto.Type);
        _context.Exams.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteExame(int id)
    {
        var delete =await _context.Exams.FirstAsync(x => x.ExemId == id); 
        _context.Exams.Remove(delete);
        await _context.SaveChangesAsync();
    }
}