using Microsoft.EntityFrameworkCore;
using WringingAPi.Model;

namespace WringingAPi.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("ConexaoPadrao");
        }
    }
    public DbSet<Filme> Filmes { get; set; }
}