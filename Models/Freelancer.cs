namespace FreelancerApi.Models;

public class Freelancer
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Skillset { get; set; }
    public string? Hobby { get; set; }

}