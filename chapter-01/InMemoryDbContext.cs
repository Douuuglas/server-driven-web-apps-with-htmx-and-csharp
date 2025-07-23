using chapter_01.Cats.Models;
using Microsoft.EntityFrameworkCore;

namespace chapter_01;

public class InMemoryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("InMemory");
    }

    public DbSet<Cat> Cats => Set<Cat>();
}
