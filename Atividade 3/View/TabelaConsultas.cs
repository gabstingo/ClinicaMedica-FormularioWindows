using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClinicaMedica.Model;
using Atividade_3.Controller;
using ClinicaMedica.Controller;

namespace Atividade_3
{
    public partial class TabelaConsultas : FormBase
    {
        AgendaEconsulta item1 = new AgendaEconsulta();

        public void iniciar()
        {
            List<Medico> lista = MedicoController.Listar();
            comboBoxMedico.DataSource = lista;


            List<AgendaEconsulta> lista4 = AgendaEconsultaController.Listar();
            dataGridView1.DataSource = lista4;
        }
        public TabelaConsultas()
        {
            InitializeComponent();
        }

        private void TabelaConsultas_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            item1.Medico = (Medico)comboBoxMedico.SelectedItem;

            item1.MedicoId = item1.Medico.ID;
            item1.Medico = null;
            item1.DiaAtendimento = dataConsulta.Value.Date;

            List<AgendaEconsulta> lista4 = AgendaEconsultaController.ListarHoraMedicoDia(item1);
            dataGridView1.DataSource = lista4;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgendaEconsulta item2 = (AgendaEconsulta)dataGridView1.SelectedRows[0].DataBoundItem;

            Anotacoesmedico newForm = new Anotacoesmedico(item2);
            newForm.ShowDialog();
        }
    }
}
