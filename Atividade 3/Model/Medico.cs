using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Model
{
    public class Medico : Pessoa
    {
        [Required]
        public string Crm { get; set; }

        [Required]
        public string Especialidade { get; set; }

        [Required]
        public int TempoConsulta { get; set; }
    }
}
