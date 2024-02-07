using Microsoft.EntityFrameworkCore;
using Tabler.Docs.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<MarketQuote> MarketQuotes { get; set; } = default!; // Add this line

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Country>().HasKey(x => x.Code);
        modelBuilder.Entity<Country>().OwnsOne(x => x.Medals);

        // If you need to configure anything specific for MarketQuote, you can do it here.
        modelBuilder.Entity<MarketQuote>().HasKey(mq => mq.id);
    }
}