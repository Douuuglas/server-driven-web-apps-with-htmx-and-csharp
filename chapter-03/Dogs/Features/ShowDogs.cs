using chapter_03.Dogs.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace chapter_03.Dogs.Features;

internal sealed class ShowDogs
{
    public static async Task<RazorComponentResult<ShowDogsComponent>> Handle(InMemoryDbContext db)
    {
        var dogs = await db.Dogs.OrderBy(d => d.Name).ToListAsync();

        return new(new { Dogs = dogs });
    }
}
