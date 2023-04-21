using AgriTechPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriTechPlus.Infra.Data.OnModelCreating;

public class OnModelCreatingEntity : DbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Entity>()
            .Property(x => x.Id).IsRequired();
        builder.Entity<Entity>()
            .Property(x => x.LoginUsuario).IsRequired().HasMaxLength(25);
        builder.Entity<Entity>()
            .Property(x => x.NomeUsuario).IsRequired().HasMaxLength(25);
        builder.Entity<Entity>()
            .Property(x => x.TempoAtual).IsRequired().HasMaxLength(25);
        builder.Entity<Entity>()
            .Property(x => x.IpUsuario).IsRequired().HasMaxLength(25);
    }
}
