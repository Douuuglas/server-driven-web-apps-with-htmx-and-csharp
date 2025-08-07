using chapter_03.Dogs.Models;

namespace chapter_03;

public static class SeedDatabaseExtensions
{
    private static readonly List<Dog> seedDogs =
    [
        Dog.New("Comet", "Whippet"),
        Dog.New("Oscar", "German Shorthaired Pointer")
    ];

    public static void SeedDatabase(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<InMemoryDbContext>();
        dbContext.Dogs.AddRange(seedDogs);
        dbContext.SaveChanges();
    }
}
