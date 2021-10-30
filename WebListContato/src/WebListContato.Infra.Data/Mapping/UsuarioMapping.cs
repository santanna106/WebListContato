using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebListContato.Domain.Entities;

namespace WebListContato.Infra.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("senha")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Login)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("login")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("email")
               .HasColumnType("varchar(100)");
        }
    }
}
