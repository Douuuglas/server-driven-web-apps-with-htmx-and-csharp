using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace chapter_01.Cats.Features;

public class ShowCats
{
    public static async Task<RazorComponentResult<ShowCatsComponent>> Handle(InMemoryDbContext db)
    {
        var cats = await db.Cats.ToListAsync();

        return new RazorComponentResult<ShowCatsComponent>(new { Cats = cats });
    }
}
