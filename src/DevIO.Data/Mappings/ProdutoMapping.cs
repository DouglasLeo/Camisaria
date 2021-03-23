﻿using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

            builder.Property(p => p.Imagem)
                    .HasColumnType("varchar(100)");

            builder.ToTable("Produtos");
        }
    }
}