using FreelancerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class FreelancerController : ControllerBase
{
    private readonly DataContext _context;

    public FreelancerController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Freelancer>>> GetAllFreelancers()
    {
        return await _context.Freelancers.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Freelancer>> GetFreelancer(Guid id)
    {
        return await _context.Freelancers.FindAsync(id);
    }
}