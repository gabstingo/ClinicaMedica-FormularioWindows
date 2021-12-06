using Aula10MvcConexaoBaseDados.Data;
using ClinicaMedica.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_3.Controller
{
    class AgendaEconsultaController
    {
        public static DataContext dc = new DataContext();
        internal static bool Inserir(AgendaEconsulta consulta)
        {
            List<AgendaEconsulta> listaTemAgendamento;
            int tempoConsultaMedico = consulta.Medico.TempoConsulta;

            if (consulta.Paciente.Nome.Trim() == "")
                throw new Exception("Título inválido");

            if (consulta.Medico.Nome.Trim() == "")
                throw new Exception("Título inválido");

            consulta.HorarioFimAtendimento = consulta.HorarioInicioAtendimento.Value.AddMinutes(tempoConsultaMedico);

            consulta.MedicoId = consulta.Medico.ID;
            consulta.Medico = null;

            consulta.PacienteId = consulta.Paciente.ID;
            consulta.Paciente = null;

            try
            {
                //se listaTemAgendamento for igual a null significa que nao encontrou nenhum agendamento neste horario e entao pode salvar
                listaTemAgendamento = AgendaEconsultaController.VerificHorMed(consulta);
            }
            catch
            {
                throw new Exception("Houve um erro na verificação dos horários do Medico informado");
            }

            if (listaTemAgendamento.Count == 0)
            {
                //se listaTemAgendamento for igual a 0(vazia) significa que nao encontrou nenhum agendamento neste horario e entao pode salvar
                //se variavel bool temAgendamento na view AgendarConsulta for igual a false
                //significa que nao encontrou nenhum agendamento neste horario e entao pode salvar

                dc.TBAgendaEconsulta.Add(consulta);
                dc.SaveChanges();
                return false;
            }
            else if (listaTemAgendamento.Count > 0)
            {
                return true;
            }

            //Esse return nao deveria estar aqui, era para ter so os dois dos ifs
            //mas eu tive que por ele pois se não dava erro, mas o executavel nunca chega nele e ele nunca é executado...
            return true;
        }

        internal static List<AgendaEconsulta> VerificHorMed(AgendaEconsulta item)
        {
            string consulta =
                " select A.* " +
                " from TBAgendaEconsulta A inner join TBMedico M on A.MedicoId = M.ID " +
                " where ( A.HorarioInicioAtendimento between ";

            List<object> parametros = new List<object>();

            if (item.HorarioInicioAtendimento != null)
            {
                consulta += " @HorarioInicioAtendimento ";
                parametros.Add(new SqlParameter("HorarioInicioAtendimento", item.HorarioInicioAtendimento));
            }

            if (item.HorarioFimAtendimento != null)
            {
                consulta += " AND @HorarioFimAtendimento ";
                parametros.Add(new SqlParameter("HorarioFimAtendimento", item.HorarioFimAtendimento));
            }
            //------------
            //Aqui eu repito o que fiz anteriormente só que o between antes era para verificar o inicio
            //E agora é para verificar o fim
            if (item.HorarioInicioAtendimento != null)
            {
                consulta += " or A.HorarioFimAtendimento between @HorarioInicioAtendimento2 ";
                parametros.Add(new SqlParameter("HorarioInicioAtendimento2", item.HorarioInicioAtendimento));
            }

            if (item.HorarioFimAtendimento != null)
            {
                consulta += " AND @HorarioFimAtendimento2 ) ";
                parametros.Add(new SqlParameter("HorarioFimAtendimento2", item.HorarioFimAtendimento));
            }
            //------------

            if (item.MedicoId != null)
            {
                consulta += " AND M.ID = @MedicoId ";
                parametros.Add(new SqlParameter("MedicoId", item.MedicoId));
            }

            if (item.DiaAtendimento != null)
            {
                consulta += " AND A.DiaAtendimento = @DiaAtendimento ";
                parametros.Add(new SqlParameter("DiaAtendimento", item.DiaAtendimento));
            }

            return dc.TBAgendaEconsulta.FromSqlRaw(consulta, parametros.ToArray()).ToList();
        }

        internal static List<AgendaEconsulta> Listar()
        {
            return dc.TBAgendaEconsulta.Include(m => m.Medico).Include(p => p.Paciente).OrderBy(x => x.DiaAtendimento).ToList();
        }

        internal static void Remover(AgendaEconsulta agenCons)
        {
            dc.TBAgendaEconsulta.Remove(agenCons);
            dc.SaveChanges();
        }

        internal static bool Atualizar(AgendaEconsulta consulta)
        {
            dc.TBAgendaEconsulta.Update(consulta);
            dc.SaveChanges();
            return false;
        }

        internal static List<AgendaEconsulta> PesquisarMedico(AgendaEconsulta pacienteEmedico)
        {
            return dc.TBAgendaEconsulta.Where(x => x.Medico.Nome.Contains(pacienteEmedico.Medico.Nome)).ToList();
        }

        internal static List<AgendaEconsulta> PesquisarPaciente(AgendaEconsulta pacienteEmedico)
        {
            return dc.TBAgendaEconsulta.Where(x => x.Paciente.Nome.Contains(pacienteEmedico.Paciente.Nome)).ToList();
        }
        internal static List<AgendaEconsulta> ListarHoraMedicoDia(AgendaEconsulta item)
        {
            string consulta =
                " select A.* " +
                " from TBAgendaEconsulta A inner join TBMedico M on A.MedicoId = M.ID " +
                " where A.DiaAtendimento = ";

            List<object> parametros = new List<object>();

            if (item.DiaAtendimento != null)
            {
                consulta += " @DiaAtendimento ";
                parametros.Add(new SqlParameter("DiaAtendimento", item.DiaAtendimento));
            }

            if (item.MedicoId != null)
            {
                consulta += " AND M.ID = @MedicoId ";
                parametros.Add(new SqlParameter("MedicoId", item.MedicoId));
            }

            return dc.TBAgendaEconsulta.FromSqlRaw(consulta, parametros.ToArray()).ToList();
        }
    }
}
