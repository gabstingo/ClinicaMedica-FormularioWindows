using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Model
{
    public class Pessoa
    {
        public int? ID { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
