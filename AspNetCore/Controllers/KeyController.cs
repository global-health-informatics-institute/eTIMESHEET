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
    [HttpGet("{ProjectId}")]
    public async Task<ActionResult<Team>> Get(int ProjectIdid)
    {
      return await _dbContext.Teams.FindAsync(ProjectIdid);
    }
  }
}