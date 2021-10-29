using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebListContato.Domain.Entities;

namespace WebListContato.Infra.Data.Context
{
    public class MsSQLContext : DbContext
    {
        public MsSQLContext(DbContextOptions<MsSQLContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder
                .Model
                .GetEntityTypes()
                .SelectMany(
                    e => e.GetProperties()
                        .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MsSQLContext).Assembly);
        }
    }
}
