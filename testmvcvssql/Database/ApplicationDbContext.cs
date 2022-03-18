using testmvcvssql.Models;
using Microsoft.EntityFrameworkCore;
namespace testmvcvssql.Database;
public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext
    (DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Category { get; set; }
    public DbSet<Product> Product { get; set; }
}