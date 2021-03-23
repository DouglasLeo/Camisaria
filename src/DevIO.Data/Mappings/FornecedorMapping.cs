using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                    .HasColumnType("varchar(200)")
                    .IsRequired();

            builder.HasOne(f => f.Endereco)
                    .WithOne(e => e.Fornecedor)
                    .HasForeignKey<Endereco>(e => e.FornecedorId);

            builder.HasMany(f => f.Produtos)
                    .WithOne(p => p.Fornecedor)
                    .HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}
