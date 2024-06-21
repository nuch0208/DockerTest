using Demoapp.Data;
using Demoapp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Demoapp.Controllers;

[ApiController]
[Route("[controller]")]
public class DrviersController : ControllerBase
{
    private readonly ILogger<DrviersController>_logger;
    private readonly ApiDbContext _context; //inject ApiDbcontext

    public DrviersController(
        ILogger<DrviersController> logger,
        ApiDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetAllDrivers")]
    public async Task<IActionResult> Get()
    {
        var driver = new Driver()
        {
            DriverNumber = 44,
            Name = "Sir Lewis Hailton"
        };

        _context.Add(driver);
        await _context.SaveChangesAsync();

        var GetAllDrivers = await _context.Drives.ToListAsync();
        return Ok(GetAllDrivers);
    }
}
