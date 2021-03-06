// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

using WebListContato.Infra.Data.Context;

namespace WebListContato.Infra.Data.Migrations
{
    [DbContext(typeof(MsSQLContext))]
    partial class MsSQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebListContato.Domain.Entities.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("celular");

                    b.Property<string>("DDDCelular")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dddcelular");

                    b.Property<string>("DDDTelefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dddtelefone");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime")
                        .HasColumnName("datanascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("WebListContato.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("login");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
