using AgriTechPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriTechPlus.Infra.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Entity> Entities { get; set; }
    public DbSet<AduboModel> AduboModels { get; set; }
    public DbSet<Componentes> Componentes { get; set; }
    public DbSet<Composicao> Composicaos { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
