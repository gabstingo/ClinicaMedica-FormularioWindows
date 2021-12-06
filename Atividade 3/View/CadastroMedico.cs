using Atividade_3.Controller;
using Atividade_3.View;
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

namespace Atividade_3
{
    public partial class CadastroMedico : FormBase
    {
        public CadastroMedico()
        {
            InitializeComponent();
        }
        private void AtualizarLista()
        {
            List<Medico> lista = MedicoController.Listar();
            dataGridView1.DataSource = lista;
        }

        private void CadastroMedico_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            Medico medico = new Medico();

            
            bool erros = false;

            if (txtNomeCompleto.Text == "")
            {
                errorProvider1.SetError(txtNomeCompleto, "Preencha este campo com o nome completo do medico");
                erros = true;
            }

            if (txtCRM.Text == "")
            {
                errorProvider1.SetError(txtCRM, "Preencha este campo com o CRM do medico");
                erros = true;
            }
            if (txtEspecialidade.Text == "")
            {
                errorProvider1.SetError(txtEspecialidade, "Preencha este campo com a especialidade do medico");
                erros = true;
            }
            if ((int)numericConsulta.Value <= 0 )
            {
                errorProvider1.SetError(numericConsulta, "o tempo de consulta não pode ser zero ou menor");
                erros = true;
            }
            if (erros == true)
                return;
            else if (erros == false)
            {
                medico.Crm = txtCRM.Text.Trim();
                medico.Especialidade = txtEspecialidade.Text.Trim();
                medico.Nome = txtNomeCompleto.Text.Trim();
                medico.TempoConsulta = (int)numericConsulta.Value;

                try
                {
                    MedicoController.Inserir(medico);
                    MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCompleto.Text = "";
                    txtCRM.Text = "";
                    txtEspecialidade.Text = "";
                    numericConsulta.Value = 0;
                    
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AtualizarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você quer realmente fechar a pagina de cadastro ?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
                return;
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                Medico item = (Medico)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult resposta = MessageBox.Show($"deseja realmente remover o livro '{item.Nome}'do Sistema ?",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        MedicoController.Remover(item);
                        MessageBox.Show("Cadastro Removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("houve um erro na remoção do Cadastro informado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            AtualizarLista();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Medico item = new Medico();
            item.Nome = txtPesquisa.Text.Trim();

            List<Medico> lista = MedicoController.Pesquisar(item);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                Medico item = (Medico)dataGridView1.SelectedRows[0].DataBoundItem;

                EditarMedico newForm = new EditarMedico(item);
                newForm.ShowDialog();
            }
        }
    }
}
