using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ResultServices
{
    private readonly DataContext _context;

    public ResultServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<ResultDto>> GetResult()
    {
        return await _context.Results.Select(x => new ResultDto(x.ExamId,x.StudentId,x.SubjectId,x.Marks)).ToListAsync();
    }

    public async Task AddResult(ResultDto resultDto)
    {
        var add = new Result(resultDto.ExemId, resultDto.StudentId, resultDto.SubjectId,resultDto.Marks);
        await _context.Results.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateResult(ResultDto resultDto)
    {
        var update = new Result(resultDto.ExemId, resultDto.StudentId, resultDto.SubjectId,resultDto.Marks);
        _context.Results.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteResult(int id)
    {
        var delete =await _context.Results.FirstAsync(x => x.StudentId == id); 
        _context.Results.Remove(delete);
        await _context.SaveChangesAsync();
    }
}