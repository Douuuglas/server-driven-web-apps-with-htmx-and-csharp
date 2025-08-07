namespace chapter_03.Dogs.Features;

internal sealed class DeleteDog
{
    public static async Task Handle(InMemoryDbContext db, Guid id)
    {
        var dog = db.Dogs.Single(d => d.Id == id);

        db.Dogs.Remove(dog);
        await db.SaveChangesAsync();
    }
}
