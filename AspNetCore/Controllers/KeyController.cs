using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class KeyController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public KeyController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords/5
    [HttpGet]
    public async Task<ActionResult<List<Team>>> Get()
    {
      return await _dbContext.Teams.ToListAsync();
    }

    [HttpGet("{ProjectId}")]
    public async Task<ActionResult<Team>> Get(int ProjectId)
    {
      return await _dbContext.Teams.FindAsync(ProjectId);
    }
  }
}