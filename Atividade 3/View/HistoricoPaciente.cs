using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedica.Model;
using Atividade_3.Controller;
using ClinicaMedica.Controller;

namespace Atividade_3
{
    public partial class HistoricoPaciente : FormBase
    {
        public void Atualizar()
        {
            List<Paciente> lista = PacienteController.Listar();
            comboBoxMedico.DataSource = lista;

            List<AgendaEconsulta> lista4 = AgendaEconsultaController.Listar();
            dataGridView1.DataSource = lista4;
        }
        public HistoricoPaciente()
        {
            InitializeComponent();
            Atualizar();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AgendaEconsulta item = new AgendaEconsulta();
            item.Paciente = (Paciente)comboBoxMedico.SelectedItem;

            List<AgendaEconsulta> lista = AgendaEconsultaController.PesquisarPaciente(item);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgendaEconsulta item = (AgendaEconsulta)dataGridView1.SelectedRows[0].DataBoundItem;

            Anotacoesmedico newForm = new Anotacoesmedico(item);
            newForm.ShowDialog();
        }
    }
}
