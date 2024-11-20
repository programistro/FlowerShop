using FlowerShop.Core;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop.Data;

public class AppDbContext: DbContext
{
    public DbSet<Flower> Flowers => Set<Flower>();
    public DbSet<Pack> Packs => Set<Pack>();
    
    public DbSet<Toy> Toys => Set<Toy>();
    
    public AppDbContext(){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}