using CaseManagement.Domain.Entities;
using CaseManagement.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaseManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CasesController : ControllerBase
{
    private readonly CaseManagementDbContext _dbContext;

    public CasesController(CaseManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Case>>> GetCases()
    {
        var cases = await _dbContext.Cases
            .OrderByDescending(c => c.CreatedAt)
            .ToListAsync();

        return Ok(cases);
    }

    [HttpPost]
    public async Task<ActionResult<Case>> CreateCase(Case @case)
    {
        _dbContext.Cases.Add(@case);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCases), new { id = @case.Id }, @case);
    }
}
