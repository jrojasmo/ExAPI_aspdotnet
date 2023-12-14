
using Microsoft.EntityFrameworkCore;

namespace Api_ExampleASP.Models;

public class PeopleContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<User> Users { get; set; }

    public PeopleContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Person>()
            .Property(u => u.FullName)
            .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");
        modelBuilder.Entity<Person>()
           .Property(u => u.TypeNumID)
           .HasComputedColumnSql("[TypeID] + '-' + [NumberID]");
    }
}