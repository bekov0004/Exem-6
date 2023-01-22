using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class IssuesController
{
  private IssuesServices _issuesServices;

  public IssuesController(IssuesServices issuesServices)
  {
    _issuesServices = issuesServices;
  }
  
  [HttpGet("GetIssues")]
  public async Task<List<IssuesDto>> GetIssues()
  {
    return await _issuesServices.GetIssues();
  }

  [HttpPost("AddIssues")]
  public async Task AddIssues(IssuesDto issuesDto)
  {
    await _issuesServices.AddIssues(issuesDto);
  }

  [HttpPut("UpdateIssues")]
  public async Task UpdateIssues(IssuesDto issuesDto)
  {
    await _issuesServices.UpdateIssues(issuesDto);
  }

  [HttpDelete("DeleteIssues")]
  public async Task DeleteIssues(int id)
  {
    await _issuesServices.DeleteIssues(id);
  }
}