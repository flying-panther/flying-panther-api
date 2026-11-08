using Flying.Panther.Domain.Orders;
using Flying.Panther.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Flying.Panther.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        DbInitializer.Initialize(builder);
    }
}
