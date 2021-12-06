using Atividade_3.Controller;
using ClinicaMedica.Controller;
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

namespace Atividade_3.View
{
    public partial class TestesMatheus : Form
    {
        public TestesMatheus()
        {
            InitializeComponent();
        }

        private void btnInserirPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.DataNascimento = new DateTime(1111, 1, 11);
            paciente.Nome = "Mario";
            paciente.Profissao = "Mecanico";
            paciente.Telefone = "33230011";

            ////Salvar
            try
            {
                PacienteController.Inserir(paciente);
                MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserirMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.Crm = "TesteCrm";
            medico.Especialidade = "Pediatra";
            medico.Nome = "Abraao";
            medico.TempoConsulta = 3;

            //Salvar
            try
            {
                MedicoController.Inserir(medico);
                MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.Nome = "Mario";

            List<Paciente> listaPaciente = PacienteController.Pesquisar(paciente);
        }

        private void btnPesquisarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = "Abraao";

            List<Medico> listaMedico = MedicoController.Pesquisar(medico);
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.ID = 1;
            paciente.DataNascimento = new DateTime(2222, 2, 22);
            paciente.Nome = "MarioAtualizado";
            paciente.Profissao = "Desenvolvedor";
            paciente.Telefone = "33230011";

            try
            {
                PacienteController.Atualizar(paciente);
                MessageBox.Show("Dados Editados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Falha ao atualizar os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.ID = 1;
            medico.Crm = "TesteCrm";
            medico.Especialidade = "Pediatra";
            medico.Nome = "JorgeTeste";
            medico.TempoConsulta = 3;

            try
            {
                MedicoController.Atualizar(medico);
                MessageBox.Show("Dados Editados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Falha ao atualizar os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagarPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.ID = 1;
            paciente.DataNascimento = new DateTime(2222, 2, 22);
            paciente.Nome = "MarioAtualizado";
            paciente.Profissao = "Desenvolvedor";
            paciente.Telefone = "33230011";

            try
            {
                PacienteController.Remover(paciente);
                MessageBox.Show("Paciente removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um erro na remoção do Paciente informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.ID = 1;
            medico.Crm = "TesteCrm";
            medico.Especialidade = "Pediatra";
            medico.Nome = "JorgeTeste";
            medico.TempoConsulta = 3;

            try
            {
                MedicoController.Remover(medico);
                MessageBox.Show("Medico removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um erro na remoção do Medico informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarPaciente_Click(object sender, EventArgs e)
        {
            List<Paciente> lista = PacienteController.Listar();
        }

        private void btnListarMedico_Click(object sender, EventArgs e)
        {
            List<Medico> lista = MedicoController.Listar();
        }

        private void btnVerificHorMed_Click(object sender, EventArgs e)
        {
            try
            {
                AgendaEconsulta item = new AgendaEconsulta();
                //DateTime dataEntrada = new DateTime(ano,mes,dia,hora,minuto,segundo);
                item.Anotacoes = "teste";
                item.HorarioInicioAtendimento = new DateTime(2021, 07, 04, 11, 00, 00);
                //'2021-07-04 11:11:16.6748639' and '2021-07-04 21:11:16.6748639'
                item.HorarioFimAtendimento = new DateTime(2021, 07, 06, 15, 00, 00);
                List<AgendaEconsulta> Verifica = AgendaEconsultaController.VerificHorMed(item);
            }
            catch
            {
                MessageBox.Show("Houve um erro na verificação dos horários do Medico informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestesMatheus_Load(object sender, EventArgs e)
        {
            CarregamentoIniciarController.iniciaBD();
        }

        private void btnListarAgendasEconsultas_Click(object sender, EventArgs e)
        {
            List<AgendaEconsulta> lista = AgendaEconsultaController.Listar();
        }

        private void btnApagarAgenConsu_Click(object sender, EventArgs e)
        {
            AgendaEconsulta agenCons = new AgendaEconsulta();

            agenCons.ID = 18;

            try
            {
                AgendaEconsultaController.Remover(agenCons);
                MessageBox.Show("agenCons removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um erro na remoção do agenCons informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarAgenConsu_Click(object sender, EventArgs e)
        {
            bool temAgendamento;
            AgendaEconsulta agenConsu = new AgendaEconsulta();

            agenConsu.ID = 20;
            agenConsu.Anotacoes = "teste4";

            try
            {
                temAgendamento = AgendaEconsultaController.Atualizar(agenConsu);

                //se temAgendamento for igual a false significa que nao encontrou nenhum agendamento neste horario e entao pode salvar
                if (temAgendamento == false)
                {
                    MessageBox.Show("Dados editados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (temAgendamento == true)
                {
                    MessageBox.Show("Já existe um paciente agendado para este médico neste horário, por favor tente um novo horário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Falha ao atualizar os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesqPacienMedic_Click(object sender, EventArgs e)
        {
            AgendaEconsulta pacienteEmedico = new AgendaEconsulta();
            Paciente pacienteAux = new Paciente();
            Medico medicoAux = new Medico();

            medicoAux.Nome = "acerola";
            pacienteAux.Nome = "Mario";
            pacienteEmedico.Medico = medicoAux;
            pacienteEmedico.Paciente = pacienteAux;

            List<AgendaEconsulta> listaPacienteEmedico = AgendaEconsultaController.PesquisarPaciente(pacienteEmedico);
        }

        private void btnGeracaoHoraMedic_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = "Jorge";
            //List<AgendaEconsulta> lista = AgendaEconsultaController.ListarHoraMedicoDia(medico);
        }
    }
}
