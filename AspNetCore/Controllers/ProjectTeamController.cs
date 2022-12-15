using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProjectTeamController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public ProjectTeamController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<ProjectTeam>>> Get()
    {
      return await _dbContext.ProjectTeams.ToListAsync();
    }
  }
}