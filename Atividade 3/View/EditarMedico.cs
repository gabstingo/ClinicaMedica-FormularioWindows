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
using ClinicaMedica.Controller;
using Atividade_3.Controller;

namespace Atividade_3.View
{
    public partial class EditarMedico : FormBase
    {
        Medico MedicoAtual = null;
        public EditarMedico(Medico item)
        {
            MedicoAtual = item;
            InitializeComponent();
            if (MedicoAtual != null)
            {
                txtNomeCompleto.Text = item.Nome;
                txtEspecialidade.Text = item.Especialidade;
                txtCRM.Text = item.Crm;
                numericConsulta.Value = item.TempoConsulta;
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (this.txtNomeCompleto.ReadOnly == true)
            {
                this.txtNomeCompleto.ReadOnly = false;
                this.txtEspecialidade.ReadOnly = false;
                this.txtCRM.ReadOnly = false;
                this.numericConsulta.Enabled = true;
            }
            else if (this.txtNomeCompleto.ReadOnly == false)
            {
                this.txtNomeCompleto.ReadOnly = true;
                this.txtEspecialidade.ReadOnly = true;
                this.txtCRM.ReadOnly = true;
                this.numericConsulta.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            
            MedicoAtual.Crm = txtCRM.Text.Trim();
            MedicoAtual.Especialidade = txtEspecialidade.Text.Trim();
            MedicoAtual.Nome = txtNomeCompleto.Text.Trim();
            MedicoAtual.TempoConsulta = (int)numericConsulta.Value;

            bool erros = false;

            if (MedicoAtual.Nome == "")
            {
                errorProvider1.SetError(txtNomeCompleto, "Preencha este campo com o nome completo do medico");
                erros = true;
            }

            if (MedicoAtual.Crm == "")
            {
                errorProvider1.SetError(txtCRM, "Preencha este campo com o CRM do medico");
                erros = true;
            }
            if (MedicoAtual.Especialidade == "")
            {
                errorProvider1.SetError(txtEspecialidade, "Preencha este campo com a especialidade do medico");
                erros = true;
            }
            if (MedicoAtual.TempoConsulta <= 0)
            {
                errorProvider1.SetError(numericConsulta, "o tempo de consulta não pode ser zero ou menor");
                erros = true;
            }
            if (erros == true)
                return;
            else if (erros == false)
            {

                try
                {
                    
                    MedicoController.Atualizar(MedicoAtual);
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
