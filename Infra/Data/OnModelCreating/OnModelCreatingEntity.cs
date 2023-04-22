using AgriTechPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriTechPlus.Infra.Data.OnModelCreating;

public class OnModelCreatingEntity
{
    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<EntityModel>()
            .Property(x => x.Id).IsRequired();
        builder.Entity<EntityModel>()
            .Property(x => x.LoginUsuario).IsRequired().HasMaxLength(25);
        builder.Entity<EntityModel>()
            .Property(x => x.NomeUsuario).IsRequired().HasMaxLength(25);
        builder.Entity<EntityModel>()
            .Property(x => x.TempoAtual).IsRequired().HasMaxLength(25);
        builder.Entity<EntityModel>()
            .Property(x => x.IpUsuario).IsRequired().HasMaxLength(25);
    }
}