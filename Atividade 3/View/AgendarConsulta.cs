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
    public partial class AgendarConsulta : FormBase
    {
        public void Atualizar()
        {
            List<Medico> lista = MedicoController.Listar();
            comboBoxMedico.DataSource = lista;


            List<Paciente> lista2 = PacienteController.Listar();
            comboBoxPaciente.DataSource = lista2;


            List<Medico> lista3 = MedicoController.Listar();
            comboBoxPesquisa.DataSource = lista3;

            List<AgendaEconsulta> lista4 = AgendaEconsultaController.Listar();
            dataGridView1.DataSource = lista4;
        }
        public AgendarConsulta()
        {
            InitializeComponent();
            List<Medico> lista = MedicoController.Listar();
            List<Paciente> lista2 = PacienteController.Listar();
            if (lista2 == null)
            {
                comboBoxPaciente.DisplayMember = String.Empty;
                comboBoxPaciente.ValueMember = String.Empty;
                comboBoxPaciente.SelectedIndex = -1;
            }
            if(lista == null)
            {
                comboBoxMedico.DisplayMember = String.Empty;
                comboBoxMedico.ValueMember = String.Empty;
                comboBoxMedico.SelectedIndex = -1;

                comboBoxPesquisa.DisplayMember = "";
                comboBoxPesquisa.ValueMember = "";
                comboBoxPesquisa.SelectedIndex = -1;
            }
            Atualizar();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você quer realmente fechar a página de agendamento ?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
                return;
            this.Close();
        }

        private void AgendarConsulta_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool temAgendamento;
            AgendaEconsulta consulta = new AgendaEconsulta();


            bool erros = false;

            if (comboBoxMedico.Text == String.Empty)
            {
                errorProvider1.SetError(comboBoxPaciente, "escolha um paciente");
                erros = true;
            }
            if (comboBoxPaciente.Text == "")
            {
                errorProvider1.SetError(comboBoxMedico, "escolha um médico");
                erros = true;
            }
            if (dataConsulta.Value < DateTime.Today)
            {
                errorProvider1.SetError(dataConsulta, "o dia do atendimento não pode ser antes de hoje");
                erros = true;
            }
            if (dataConsulta.Value == DateTime.Today)
            {
                if (dataConsulta.Value < DateTime.Now)
                {
                    errorProvider1.SetError(HoraConsulta, "o horario de atendimento não pode ser menor que o de agora");
                    erros = true;
                }
            }
            if (erros == true)
            {
                return;
            }
            if (erros == false)
            {
                try
                {
                    consulta.Paciente = (Paciente)comboBoxPaciente.SelectedItem;
                    consulta.Medico = (Medico)comboBoxMedico.SelectedItem;
                    consulta.HorarioInicioAtendimento = HoraConsulta.Value;
                    consulta.DiaAtendimento = dataConsulta.Value.Date;
                    temAgendamento = AgendaEconsultaController.Inserir(consulta);

                    //se temAgendamento for igual a false significa que nao encontrou nenhum agendamento neste horario e entao pode salvar
                    if (temAgendamento == false)
                    {
                        MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Atualizar();
                    }
                    else if (temAgendamento == true)
                    {
                        MessageBox.Show("Já existe um paciente agendado para este médico neste horário, por favor tente um novo horário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroPaciente().ShowDialog();
            Atualizar();
        }

        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AgendaEconsulta item = new AgendaEconsulta();
            item.Medico = (Medico)comboBoxPesquisa.SelectedItem;

            List<AgendaEconsulta> lista = AgendaEconsultaController.PesquisarMedico(item);
            dataGridView1.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                AgendaEconsulta item = (AgendaEconsulta)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult resposta = MessageBox.Show("deseja realmente remover da consulta do sistema  ?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        AgendaEconsultaController.Remover(item);
                        MessageBox.Show("consulta removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Atualizar();
                    }
                    catch
                    {
                        MessageBox.Show("Houve um erro na remoção da consulta informada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
