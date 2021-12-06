using Aula10MvcConexaoBaseDados.Data;
using ClinicaMedica.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Controller
{
    class PacienteController
    {
        public static DataContext dc = new DataContext();
        internal static void Inserir(Paciente paciente)
        {
            if (paciente.DataNascimento.ToString().Trim() == "")
                throw new Exception("Data nascimento inválido");

            if (paciente.Nome.Trim() == "")
                throw new Exception("Nome inválido");

            if (paciente.Profissao.Trim() == "")
                throw new Exception("Profissão inválido");

            if (paciente.Telefone.ToString().Trim() == "")
                throw new Exception("Telefone inválido");

            paciente.DataNascimento = paciente.DataNascimento.Date;

            if (paciente.DataNascimento > DateTime.Today)
                throw new Exception("Data de nascimento não pode ser uma data futura");

            using (DataContext dc = new DataContext())
            {
                dc.TBPaciente.Add(paciente);
                dc.SaveChanges();
            }
        }

        internal static List<Paciente> Pesquisar(Paciente paciente)
        {
            return dc.TBPaciente.Where(x => x.Nome.Contains(paciente.Nome)).ToList();
        }

        internal static void Atualizar(Paciente paciente)
        {
            if (paciente.DataNascimento.ToString().Trim() == "")
                throw new Exception("Data nascimento inválido");

            if (paciente.Nome.Trim() == "")
                throw new Exception("Nome inválido");

            if (paciente.Profissao.Trim() == "")
                throw new Exception("Profissão inválido");

            if (paciente.Telefone.ToString().Trim() == "")
                throw new Exception("Telefone inválido");

            paciente.DataNascimento = paciente.DataNascimento.Date;

            if (paciente.DataNascimento > DateTime.Today)
                throw new Exception("Data de nascimento não pode ser uma data futura");

            dc.TBPaciente.Update(paciente);
            dc.SaveChanges();
        }

        internal static void Remover(Paciente paciente)
        {
            dc.TBPaciente.Remove(paciente);
            dc.SaveChanges();
        }

        internal static List<Paciente> Listar()
        {
            return dc.TBPaciente.OrderBy(x => x.Nome).ToList();
        }
    }
}
