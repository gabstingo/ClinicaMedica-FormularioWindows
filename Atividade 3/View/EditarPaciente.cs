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
using ClinicaMedica.Controller;


namespace Atividade_3.View
{
    public partial class EditarPaciente : FormBase
    {
        private Paciente PacienteAtual = null;
        
        public EditarPaciente(Paciente item)
        {
            PacienteAtual = item;

            InitializeComponent();
            if (PacienteAtual != null)
            {
                txtNomeCompleto.Text = item.Nome;
                txtTelefone.Text = item.Telefone;
                txtProfissao.Text = item.Profissao;
                dateNascimento.Value = item.DataNascimento;
            }
            this.dateNascimento.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtNomeCompleto.ReadOnly == true)
            {
                this.txtNomeCompleto.ReadOnly = false;
                this.txtTelefone.ReadOnly = false;
                this.txtProfissao.ReadOnly = false;
                this.dateNascimento.Enabled = true;
            }
            else if (this.txtNomeCompleto.ReadOnly == false)
            {
                this.txtNomeCompleto.ReadOnly = true;
                this.txtTelefone.ReadOnly = true;
                this.txtProfissao.ReadOnly = true;
                this.dateNascimento.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            PacienteAtual.Nome = txtNomeCompleto.Text.Trim();
            PacienteAtual.Telefone = txtTelefone.Text.Trim();
            PacienteAtual.Profissao = txtProfissao.Text.Trim();
            PacienteAtual.DataNascimento = dateNascimento.Value;

            bool erros = false;

            if (PacienteAtual.Nome == "")
            {
                errorProvider1.SetError(txtNomeCompleto, "Preencha este campo com o nome completo do paciente");
                erros = true;
            }

            if (PacienteAtual.Telefone == "")
            {
                errorProvider1.SetError(txtTelefone, "Preencha este campo com o telefone do paciente");
                erros = true;
            }
            if (PacienteAtual.Profissao == "")
            {
                errorProvider1.SetError(txtProfissao, "Preencha este campo com a profissão do paciente");
                erros = true;
            }
            if (PacienteAtual.DataNascimento > DateTime.Today)
            {
                errorProvider1.SetError(dateNascimento, "data de nascimento não pode ser maior que a de hoje");
                erros = true;
            }
            if (erros == true)
            {
                return;
            }
            else
            {
                try
                {
                    PacienteController.Atualizar(PacienteAtual);
                    MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você quer realmente fechar a pagina de cadastro ?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
                return;
            this.Close();
        }
    }
}
