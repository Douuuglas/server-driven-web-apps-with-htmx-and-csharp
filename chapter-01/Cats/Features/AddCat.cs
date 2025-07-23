using chapter_01.Cats.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace chapter_01.Cats.Features;

public class AddCat
{
    public record Request(string Name, string Breed);

    // Use [FromForm] to make sure the request works
    public static async Task<RazorComponentResult<AddCatComponent>> Handle(InMemoryDbContext db, [FromForm] Request request)
    {
        var cat = new Cat()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Breed = request.Breed
        };

        await db.Cats.AddAsync(cat);
        await db.SaveChangesAsync();

        return new RazorComponentResult<AddCatComponent>(new { Cat = cat });
    }
}
