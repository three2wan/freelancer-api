using Microsoft.EntityFrameworkCore;

namespace FreelancerApi.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Freelancer> Freelancers { get; set; }
}