using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ResultController
{
    private ResultServices _resultServices;

    public ResultController(ResultServices resultServices)
    {
        _resultServices = resultServices;
    }
    [HttpGet("GetResult")]
    public async Task<List<ResultDto>> GetResult()
    {
        return await _resultServices.GetResult();
    }

    [HttpPost("AddResult")]
    public async Task AddResult(ResultDto resultDto)
    {
        await _resultServices.AddResult(resultDto);
    }

    [HttpPut("UpdateResult")]
    public async Task UpdateResult(ResultDto resultDto)
    {
        await _resultServices.UpdateResult(resultDto);
    }

    [HttpDelete("DeleteResult")]
    public async Task DeleteResult(int id)
    {
        await _resultServices.DeleteResult(id);
    }
    
}