using AgriTechPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriTechPlus.Infra.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<ComposicaoModel> Composicoes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ComposicaoModel>()
            .Property(x => x.Nome).IsRequired().HasMaxLength(25);
        builder.Entity<ComposicaoModel>()
            .Property(x => x.Descricao).IsRequired().HasMaxLength(25);
        builder.Entity<ComposicaoModel>()
            .Property(x => x.ObservacaoGeral).IsRequired().HasMaxLength(25);
        //-------------------------------------------------------------
    }
}
