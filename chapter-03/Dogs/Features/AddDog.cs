using chapter_03.Dogs.Components;
using chapter_03.Dogs.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace chapter_03.Dogs.Features;

internal sealed class AddDog
{
    public sealed record Request(string Name, string Breed);

    public static async Task<RazorComponentResult<ShowDogComponent>> Handle(InMemoryDbContext db, [FromForm] Request request)
    {
        var dog = Dog.New(request.Name, request.Breed);

        await db.Dogs.AddAsync(dog);
        await db.SaveChangesAsync();

        return new(new { Dog = dog });
    }
}
