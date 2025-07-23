namespace chapter_01.Cats.Models;

public class Cat
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Breed { get; init; }
}
