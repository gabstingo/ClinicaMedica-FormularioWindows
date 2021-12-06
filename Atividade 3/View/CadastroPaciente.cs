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
using Atividade_3.View;
namespace Atividade_3
{
    public partial class CadastroPaciente : FormBase
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }
        private void AtualizarLsta()
        {
            List<Paciente> lista = PacienteController.Listar();
            dataGridView1.DataSource = lista;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            Paciente paciente = new Paciente();
         

            bool erros = false;

            if (txtNomeCompleto.Text == "")
            {
                errorProvider1.SetError(txtNomeCompleto, "Preencha este campo com o nome completo do paciente");
                erros = true;
            }

            if (txtTelefone.Text == "")
            {
                errorProvider1.SetError(txtTelefone, "Preencha este campo com o telefone do paciente");
                erros = true;
            }
            if (txtProfissao.Text == "")
            {
                errorProvider1.SetError(txtProfissao, "Preencha este campo com a profissão do paciente");
                erros = true;
            }
            if (dateNascimento.Value > DateTime.Today)
            {
                errorProvider1.SetError(dateNascimento, "data de nascimento não pode ser maior que a de hoje");
                erros = true;
            }
            if (erros == true)
            {
                return;
            }
            else if (erros == false)
            {
                try
                {
                    paciente.Nome = txtNomeCompleto.Text.Trim();
                    paciente.DataNascimento = dateNascimento.Value.Date;
                    paciente.Telefone = txtTelefone.Text.Trim();
                    paciente.Profissao = txtProfissao.Text.Trim();
                    PacienteController.Inserir(paciente);
                    MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCompleto.Text = "";
                    txtTelefone.Text = "";
                    txtProfissao.Text = "";

                }
                catch
                {
                    MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AtualizarLsta();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você quer realmente fechar a pagina de cadastro ?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
                return;
            this.Close();
        }
        private void CadastroPaciente_Load(object sender, EventArgs e)
        {
            AtualizarLsta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                Paciente item = (Paciente)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult resposta = MessageBox.Show($"deseja realmente remover o livro '{item.Nome}'do Sistema ?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        PacienteController.Remover(item);
                        MessageBox.Show("Cadastro Removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("houve um erro na remoção do Cadastro informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            AtualizarLsta();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            {
                Paciente item = new Paciente();
                item.Nome = txtPesquisa.Text.Trim();

                List<Paciente> lista = PacienteController.Pesquisar(item);
                dataGridView1.DataSource = lista;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
               Paciente item = (Paciente)dataGridView1.SelectedRows[0].DataBoundItem;

                EditarPaciente newForm = new EditarPaciente(item);
                newForm.ShowDialog();
            }
        }
    }
}
