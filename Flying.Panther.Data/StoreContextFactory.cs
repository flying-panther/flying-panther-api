using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Flying.Panther.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

       optionsBuilder.UseSqlite(
    "Data Source=FlyingPanther.sqlite",
    options => options.MigrationsAssembly("Flying.Panther.Api"));

        return new StoreContext(optionsBuilder.Options);
    }
}