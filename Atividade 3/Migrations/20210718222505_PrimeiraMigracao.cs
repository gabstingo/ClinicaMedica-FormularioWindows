using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Atividade_3.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBMedico",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoConsulta = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBMedico", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBPaciente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPaciente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBAgendaEconsulta",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    DiaAtendimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioInicioAtendimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioFimAtendimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Anotacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAgendaEconsulta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBAgendaEconsulta_TBMedico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "TBMedico",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBAgendaEconsulta_TBPaciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "TBPaciente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAgendaEconsulta_MedicoId",
                table: "TBAgendaEconsulta",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAgendaEconsulta_PacienteId",
                table: "TBAgendaEconsulta",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAgendaEconsulta");

            migrationBuilder.DropTable(
                name: "TBMedico");

            migrationBuilder.DropTable(
                name: "TBPaciente");
        }
    }
}
