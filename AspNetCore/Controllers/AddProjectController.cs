using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AddProjectController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public AddProjectController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<AddProject>>> Get()
    {
      return await _dbContext.AddProjects.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("{AddProjectid}")]
    public async Task<ActionResult<AddProject>> Get(int AddProjectid)
    {
      return await _dbContext.AddProjects.FindAsync(AddProjectid);
    }

    // POST api/foodrecords
    [HttpPost]
    public async Task Post(AddProject model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{AddProjectid}")]
    public async Task<ActionResult> Put(int AddProjectid, AddProject model)
    {
      var exists = await _dbContext.AddProjects.AnyAsync(f => f.AddProjectId == AddProjectid);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.AddProjects.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
  }
}