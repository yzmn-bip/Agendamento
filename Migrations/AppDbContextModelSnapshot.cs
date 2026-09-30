using System;
using Agendamento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agendamento.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "10.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Agendamento.Models.Medico", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));
                b.Property<string>("Crm").IsRequired().HasMaxLength(15).HasColumnType("character varying(15)");
                b.Property<string>("Especialidade").IsRequired().HasMaxLength(50).HasColumnType("character varying(50)");
                b.Property<string>("Nome").IsRequired().HasMaxLength(100).HasColumnType("character varying(100)");
                b.HasKey("Id");
                b.ToTable("Medicos");
            });

            modelBuilder.Entity("Agendamento.Models.Paciente", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("integer");
                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));
                b.Property<string>("Cpf").IsRequired().HasMaxLength(14).HasColumnType("character varying(14)");
                b.Property<DateTime>("DataNascimento").HasColumnType("date");
                b.Property<string>("Endereco").IsRequired().HasMaxLength(200).HasColumnType("character varying(200)");
                b.Property<string>("Nome").IsRequired().HasMaxLength(100).HasColumnType("character varying(100)");
                b.Property<string>("Telefone").IsRequired().HasMaxLength(20).HasColumnType("character varying(20)");
                b.HasKey("Id");
                b.ToTable("Pacientes");
                b.HasData(
                    new { Id = 1, Cpf = "123.456.789-00", DataNascimento = new DateTime(2000, 5, 10), Endereco = "Rua das Flores, 100", Nome = "Ana Martins", Telefone = "(17) 99999-1111" },
                    new { Id = 2, Cpf = "987.654.321-00", DataNascimento = new DateTime(1995, 8, 22), Endereco = "Avenida Brasil, 250", Nome = "Bruno Almeida", Telefone = "(17) 98888-2222" }
                );
            });
#pragma warning restore 612, 618
        }
    }
}
