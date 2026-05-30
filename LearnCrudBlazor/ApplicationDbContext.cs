using Microsoft.EntityFrameworkCore;

namespace LearnCrudBlazor;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
    }

    public DbSet<Exemplo> Exemplos { get; set; }
    
}