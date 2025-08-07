namespace chapter_03.Dogs.Models;

public class Dog
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }

    private Dog(string name, string breed)
    {
        Id = Guid.NewGuid();
        Name = name;
        Breed = breed;
    }

    public static Dog New(string name, string breed)
    {
        return new Dog(name, breed);
    }
}
