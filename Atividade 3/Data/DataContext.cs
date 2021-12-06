using ClinicaMedica.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10MvcConexaoBaseDados.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conexão BD Matheus
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS,1433;Database=ClinicaMedica;User=sa;Password=123;MultipleActiveResultSets=true");

            //Conexão BD Gabriel
            //optionsBuilder.UseSqlServer("Server=localhost,1401;Database=ClinicaMedica;User=sa;Password=Senh@123;MultipleActiveResultSets=true");

            //Conexão BD Everton
            //optionsBuilder.UseSqlServer("Server=localhost,1401;Database=ClinicaMedica;User=sa;Password=Teste;MultipleActiveResultSets=true");
        }

        public DbSet<AgendaEconsulta> TBAgendaEconsulta { get; set; }

        public DbSet<Medico> TBMedico { get; set; }

        public DbSet<Paciente> TBPaciente { get; set; }
    }
}
