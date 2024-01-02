using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;

public class CollectionContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder ob)
    {
        string conString = @"server=localhost;port=3306;user=root;password=welcome;database=ecommerce";
        ob.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder md)
    {
        base.OnModelCreating(md);
        md.Entity<Department>((entity) =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.Property(e => e.Location);
        });
        md.Entity<Department>().ToTable("departments");
    }
}