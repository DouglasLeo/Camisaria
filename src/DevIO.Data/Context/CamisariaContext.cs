using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevIO.Data.Context
{
    public class CamisariaContext : DbContext
    {
        public CamisariaContext(DbContextOptions options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CamisariaContext).Assembly);

            foreach (var relatioship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relatioship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            
            base.OnModelCreating(modelBuilder);

         modelBuilder.Entity<Produto>()
        .Property(p => p.Valor)
        .HasColumnType("decimal(18,4)");

        }
    }
}
