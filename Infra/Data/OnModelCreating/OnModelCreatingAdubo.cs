using AgriTechPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriTechPlus.Infra.Data.OnModelCreating;

public class OnModelCreatingAdubo
{
    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<AduboModel>()
            .Property(x => x.Id).IsRequired();
        builder.Entity<AduboModel>()
            .Property(x => x.Nome).IsRequired().HasMaxLength(50);
        builder.Entity<AduboModel>()
            .Property(x => x.DescricaoMontagem).HasMaxLength(500);
        builder.Entity<AduboModel>()
            .Property(x => x.ObservacaoGeral).HasMaxLength(500);
    }
}