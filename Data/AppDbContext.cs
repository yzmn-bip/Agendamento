using Agendamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paciente>().HasData(
                new Paciente
                {
                    Id = 1,
                    Nome = "Ana Martins",
                    Cpf = "123.456.789-00",
                    Telefone = "(17) 99999-1111",
                    Endereco = "Rua das Flores, 100",
                    DataNascimento = new DateTime(2000, 5, 10)
                },
                new Paciente
                {
                    Id = 2,
                    Nome = "Bruno Almeida",
                    Cpf = "987.654.321-00",
                    Telefone = "(17) 98888-2222",
                    Endereco = "Avenida Brasil, 250",
                    DataNascimento = new DateTime(1995, 8, 22)
                }
            );
        }
    }
}
