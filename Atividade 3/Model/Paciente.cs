using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Model
{
    public class Paciente : Pessoa
    {
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Profissao { get; set; }
    }
}
