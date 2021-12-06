using Aula10MvcConexaoBaseDados.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3.Controller
{
    class CarregamentoIniciarController
    {
        internal static void iniciaBD()
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBMedico.Any();
            }
        }
    }
}
