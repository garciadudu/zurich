using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seguros.Zurich.Domain.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros.Zurich.Infraestrutura.Repository.Base.EntityConfiguration
{
    public class ConfigurationSeguro : IEntityTypeConfiguration<Seguro>
    {
        public void Configure(EntityTypeBuilder<Seguro> builder)
        {
            builder.HasNoKey();
            builder.Property(x => x.premioComercial);
            builder.Property(x => x.premioPuro);
            builder.Property(x => x.premioRisco);
            builder.Property(x => x.taxaRisco);
            builder.Property(x => x.valorVeiculo);
        }
    }
}
