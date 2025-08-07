using chapter_03.Dogs.Components;
using chapter_03.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace chapter_03.Dogs.Features;

internal sealed class EditDog
{
    public sealed record Request(string Name, string Breed);

    public static async Task<RazorComponentResult<ShowDogComponent>> Handle(InMemoryDbContext db,
        ISelectedDogService selectedDogService,
        HttpContext context,
        Guid id,
        [FromForm] Request request)
    {
        var dog = db.Dogs.Single(d => d.Id == id);

        dog.Name = request.Name;
        dog.Breed = request.Breed;

        await db.SaveChangesAsync();

        selectedDogService.SelectedId = null;
        context.Response.Headers["HX-Trigger"] = "selection-change";

        return new(new { Dog = dog, Updating = true });
    }
}
