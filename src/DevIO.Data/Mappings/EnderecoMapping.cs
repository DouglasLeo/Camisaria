using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Logradouro)
                    .HasColumnType("varchar(200)").IsRequired();

            builder.Property(p => p.Numero)
                    .HasColumnType("varchar(50)").IsRequired();

            builder.Property(p => p.Estado)
                    .HasColumnType("varchar(200)").IsRequired();

            builder.Property(p => p.Cep)
                    .HasColumnType("varchar(8)").IsRequired();

            builder.Property(p => p.Bairro)
                    .HasColumnType("varchar(100)").IsRequired();

            builder.Property(p => p.Cidade)
                    .HasColumnType("varchar(200)").IsRequired();

            builder.Property(p => p.Complemento)
                    .HasColumnType("varchar(250)");

            builder.ToTable("Enderecos");
        }
    }
}
