using Aula10MvcConexaoBaseDados.Data;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3.Controller
{
    class MedicoController
    {
        public static DataContext dc = new DataContext();
        internal static void Inserir(Medico medico)
        {
            if(medico.Crm.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            if (medico.Especialidade.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            if (medico.Nome.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            if (medico.TempoConsulta.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            using (DataContext dc = new DataContext())
            {
                dc.TBMedico.Add(medico);
                dc.SaveChanges();
            }
        }

        internal static List<Medico> Pesquisar(Medico medico)
        {
            return dc.TBMedico.Where(x => x.Nome.Contains(medico.Nome)).ToList();
        }

        internal static void Atualizar(Medico medico)
        {
            if (medico.Crm.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            if (medico.Especialidade.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            if (medico.Nome.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            if (medico.TempoConsulta.ToString().Trim() == "")
                throw new Exception("Crm inválido");

            dc.TBMedico.Update(medico);
            dc.SaveChanges();
        }

        internal static void Remover(Medico medico)
        {
            dc.TBMedico.Remove(medico);
            dc.SaveChanges();
        }

        internal static List<Medico> Listar()
        {
            return dc.TBMedico.OrderBy(x => x.Nome).ToList();
        }
    }
}
