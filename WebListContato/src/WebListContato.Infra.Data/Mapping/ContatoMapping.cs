using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebListContato.Domain.Entities;

namespace WebListContato.Infra.Data.Mapping
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("email")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DDDCelular)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("dddcelular")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Celular)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("celular")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DDDTelefone)
           .HasConversion(prop => prop.ToString(), prop => prop)
           .IsRequired()
           .HasColumnName("dddtelefone")
           .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Telefone)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("telefone")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Logradouro)
              .HasConversion(prop => prop.ToString(), prop => prop)
              .IsRequired()
              .HasColumnName("logradouro")
              .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataNascimento)
            .HasColumnName("datanascimento")
            .HasColumnType("datetime");
        }
    }
}
