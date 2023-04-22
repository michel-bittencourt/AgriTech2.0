using AgriTechPlus.Infra.Data.OnModelCreating;
using AgriTechPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriTechPlus.Infra.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<AduboModel> AduboModels { get; set; }
    public DbSet<ComponentesModel> Componentes { get; set; }
    public DbSet<ComposicaoModel> Composicoes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        OnModelCreatingEntity.Configure(builder);
        OnModelCreatingAdubo.Configure(builder);
    }
}
