using System;
using Agendamento.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Agendamento.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260930210000_AdicionarPacientes")]
    public partial class AdicionarPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    Telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "123.456.789-00", new DateTime(2000, 5, 10), "Rua das Flores, 100", "Ana Martins", "(17) 99999-1111" },
                    { 2, "987.654.321-00", new DateTime(1995, 8, 22), "Avenida Brasil, 250", "Bruno Almeida", "(17) 98888-2222" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Pacientes");
        }
    }
}
