using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Model
{
    public class AgendaEconsulta
    {
        public int ID { get; set; }

        public Paciente Paciente { get; set; }

        [NotMapped]
        public string NomePaciente
        {
            get {
                if (Paciente == null) 
                    return "";
                return Paciente.Nome; 
            }
        }

        public int? PacienteId { get; set; }

        public Medico Medico { get; set; }

        [NotMapped]
        public string NomeMedico
        {
            get
            {
                if (Medico == null)
                    return "";
                return Medico.Nome;
            }
        }

        public int? MedicoId { get; set; }

        [Required]
        public DateTime? DiaAtendimento { get; set; }

        [Required]
        public DateTime? HorarioInicioAtendimento { get; set; }

        [Required]
        public DateTime? HorarioFimAtendimento { get; set; }

        public string Anotacoes { get; set; }
    }
}
