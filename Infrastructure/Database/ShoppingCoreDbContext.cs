using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class ShoppingCoreDbContext : DbContext
{
    public ShoppingCoreDbContext(DbContextOptions<ShoppingCoreDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
}