using chapter_03.Dogs.Models;
using Microsoft.EntityFrameworkCore;

namespace chapter_03;

public class InMemoryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("InMemory");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dog>()
            .HasKey(d => d.Id);
        modelBuilder.Entity<Dog>()
            .Property(d => d.Name);
        modelBuilder.Entity<Dog>()
            .Property(d => d.Breed);
    }

    public DbSet<Dog> Dogs => Set<Dog>();
}
