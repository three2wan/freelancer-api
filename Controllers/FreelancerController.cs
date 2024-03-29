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

    [HttpGet("GetHelloWorld")]
    public string GetHelloWorld()
    {
        return "Hello World!!";
    }


    [HttpGet]
    public async Task<ActionResult<List<Freelancer>>> GetAllFreelancers()
    {
        var fr = await _context.Freelancers.ToListAsync();

        return Ok(fr);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Freelancer>> GetFreelancer(Guid id)
    {
        var fr = await _context.Freelancers.FindAsync(id);

        if (fr == null)
        {
            return NotFound();
        }

        return Ok(fr);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Freelancer>> UpdateFreelancer(Guid id, Freelancer freelancer)
    {
        var fr = await _context.Freelancers.FindAsync(id);

        if (fr == null)
        {
            return NotFound();
        }

        fr.Username = freelancer.Username ?? fr.Username;
        fr.Email = freelancer.Email ?? fr.Email;
        fr.Phone = freelancer.Phone ?? fr.Phone;
        fr.Skillset = freelancer.Skillset ?? fr.Skillset;
        fr.Hobby = freelancer.Hobby ?? fr.Hobby;

        await _context.SaveChangesAsync();

        DateTime currDateTime = DateTime.Now;
        var dateTime = currDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        return Ok(new { Message = "Successful update data", DateTime = dateTime });
    }

    [HttpPost]
    public async Task<ActionResult<Freelancer>> CreateFreelancer([FromBody] Freelancer freelancer)
    {
        _context.Freelancers.Add(freelancer);
        await _context.SaveChangesAsync();

        DateTime currDateTime = DateTime.Now;
        var dateTime = currDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        return Ok(new { Message = "Successful added to database", DateTime = dateTime });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFreelancer(Guid id)
    {
        var fr = await _context.Freelancers.FindAsync(id);
        if (fr == null)
        {
            return NotFound();
        }

        _context.Freelancers.Remove(fr);
        await _context.SaveChangesAsync();

        DateTime currDateTime = DateTime.Now;
        var dateTime = currDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        return Ok(new { Message = "Successful delete the data", DateTime = dateTime });
    }

}