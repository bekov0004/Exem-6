using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class IssuesServices
{
    private readonly DataContext _context;

    public IssuesServices(DataContext context)
    {
        _context = context;
    }

    public async Task<List<IssuesDto>> GetIssues()
    {
        return await _context.Issues.Select(x => new IssuesDto(x.IssueId,x.Type,x.Details,x.IsResolved)).ToListAsync();
    }

    public async Task AddIssues(IssuesDto issuesDto)
    {
        var add = new Issues(issuesDto.IssueId, issuesDto.Type,issuesDto.Details,issuesDto.IsResolved);
        await _context.Issues.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateIssues(IssuesDto issuesDto)
    {
        var update = new Issues(issuesDto.IssueId, issuesDto.Type,issuesDto.Details,issuesDto.IsResolved);
        _context.Issues.Update(update);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteIssues(int id)
    {
        var delete =await _context.Issues.FirstAsync(x => x.IssueId == id); 
        _context.Issues.Remove(delete);
        await _context.SaveChangesAsync();
    }
}