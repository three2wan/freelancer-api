using FreelancerApi.Models;

public class DataSeed
{
    public static async Task Seed(DataContext context)
    {
        if (context.Freelancers.Any())
            return;

        var freelancer = new List<Freelancer>
        {
            new Freelancer
            {
                Username = "SyazwanJamil",
                Email = "syazwan_jamil88@yahoo.com",
                Phone = "017-2342869",
                Skillset = "Web App Development, Games Development",
                Hobby = "Playing video games"
            },
            new Freelancer
            {
                Username = "JohnDoe",
                Email = "john.doe@example.com",
                Phone = "123-456-7890",
                Skillset = "Web Development, UX/UI Design",
                Hobby = "Photography"
            },
            new Freelancer
            {
                Username = "JaneSmith",
                Email = "jane.smith@example.com",
                Phone = "987-654-3210",
                Skillset = "Mobile App Development, Graphic Design",
                Hobby = "Reading"
            },
        };

        await context.Freelancers.AddRangeAsync(freelancer);
        await context.SaveChangesAsync();
    }
}