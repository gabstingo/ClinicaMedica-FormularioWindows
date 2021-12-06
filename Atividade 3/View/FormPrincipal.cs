using Atividade_3.Controller;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_3
{
    public partial class FormPrincipal : FormBase
    {
        public FormPrincipal()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroMedico().ShowDialog();
        }

        private void btnCadastroPaciente_Click(object sender, EventArgs e)
        {
            new CadastroPaciente().ShowDialog();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            new AgendarConsulta().ShowDialog();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            new HistoricoPaciente().ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            new TabelaConsultas().ShowDialog();
        }
    }
}
