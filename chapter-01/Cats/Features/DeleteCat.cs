namespace chapter_01.Cats.Features;

internal sealed class DeleteCat
{
    public static async Task<IResult> Handle(InMemoryDbContext db, Guid Id)
    {
        var cat = db.Cats.SingleOrDefault(cat => cat.Id == Id);
        if (cat is null)
        {
            return Results.NotFound();
        }

        db.Cats.Remove(cat);
        await db.SaveChangesAsync();

        // Returning Ok instead of NoContent due to: https://github.com/bigskysoftware/htmx/issues/1130
        return Results.Ok();
    }
}
